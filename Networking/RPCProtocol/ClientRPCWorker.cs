using Model.Model;
using Problem11.Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Networking
{
    public class ClientRPCWorker : Observer
    {
        private IServices server;

        private TcpClient connection;

        private NetworkStream stream;
        private IFormatter formatter;
        private volatile bool connected;
        public ClientRPCWorker(IServices services,TcpClient conn)
        {
            this.server = services;
            this.connection = conn;
            try
            {
                stream = connection.GetStream();
                formatter = new BinaryFormatter();
                connected = true;
            }catch (ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public virtual void run()
        {
            while (connected)
            {
                try
                {
                    object request = formatter.Deserialize(stream);
                    object response = handleRequest((Request)request);
                    if (response != null)
                    {
                        sendResponse((Response)response);
                    }
                }catch(ServerException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                try
                {
                    Thread.Sleep(1000);
                }catch(ServerException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            try
            {
                stream.Close();
                connection.Close();

            }catch(ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        private void sendResponse(Response response)
        {
            Console.WriteLine("Sending respons" + response.type);
            formatter.Serialize(stream, response);
            stream.Flush();
        }
        private Response handleRequest(Request request)
        {
            Response response = null;
            if (request.type == RequestType.LOGIN)
            {
                Console.WriteLine("Login request ");
                DTOAngajat angajat = (DTOAngajat)request.data;
                try
                {
                    lock (server)
                    {
                        server.login(angajat, this);
                    }
                    return new Response(ResponseType.OK);
                }catch(ServerException e)
                {
                    connected = false;
                    return new Response(ResponseType.ERROR,e.Message);
                }
            }
            if (request.type == RequestType.LOGOUT)
            {
                Console.WriteLine("Logout request ");
                DTOAngajat angajat = (DTOAngajat)request.data;
                try
                {
                    lock (server)
                    {
                        server.logout(angajat, this);
                    }
                    connected = false;
                    return new Response(ResponseType.OK);
                }catch (ServerException e)
                {
                    return new Response(ResponseType.ERROR, e.Message);
                }
            }
            if (request.type == RequestType.GET_CURRENT_CURSE)
            {
                Console.WriteLine("Get current races request");
                try
                {
                    lock (server)
                    {
                        DTOBJCursa[] curse = server.getCurrentRaces();
                        return new Response(ResponseType.GET_DISP_CURSE, curse);
                    }
                }catch(ServerException e)
                {
                    return new Response(ResponseType.ERROR, e.Message);
                }
            }
            if (request.type == RequestType.SEARCH_BY_TEAM)
            {
                Console.WriteLine("Search by team request");
                string team = (string)request.data;
                try
                {
                    lock (server)
                    {
                        DTOBJPart[] dTOBJPart = server.searchbyteam(team);
                        return new Response(ResponseType.GET_SEARCH_RESULT, dTOBJPart);
                    }
                }catch(ServerException e)
                {
                    return new Response(ResponseType.ERROR, e.Message);
                }
            }
            if (request.type == RequestType.SUBMIT_INSC)
            {
                Console.WriteLine("Handling submit request");
                DTOInfoSubmit infoSubmit = (DTOInfoSubmit)request.data;
                try
                {
                    lock (server)
                    {
                        server.submitInsc(infoSubmit);
                        return new Response(ResponseType.OK);
                    }
                }catch (ServerException e)
                {
                    return new Response(ResponseType.ERROR, e.Message);
                }

            }
            return response;
        }
        public virtual void AngajatSubmitted(DTOBJCursa[] curse)
        {
            Console.WriteLine("Angajat Submitted invoked from Worker");
            try
            {
                sendResponse(new Response(ResponseType.NEW_SUBMIT, curse));
            }catch(ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}

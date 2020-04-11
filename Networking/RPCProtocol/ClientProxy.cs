
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
    public class ClientProxy : IServices
    {
        private string host;
        private int port;

        private Observer client;
        private NetworkStream stream;

        private IFormatter formatter;
        private TcpClient connection;

        private Queue<Response> responses;
        private volatile bool finished;
        private EventWaitHandle waitHandle;

        public ClientProxy(string host,int port)
        {
            this.host = host;
            this.port = port;
            responses = new Queue<Response>();
        }
        private void initializeConnection()
        {
            try
            {
                connection = new TcpClient(host, port);
                stream = connection.GetStream();
                formatter = new BinaryFormatter();
                finished = false;
                waitHandle = new AutoResetEvent(false);
                startReader();
            }catch(ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        private void sendRequest(Request request)
        {
            try
            {
                formatter.Serialize(stream, request);
                stream.Flush();
            }catch(ServerException e)
            {
                throw new ServerException("Could now send request" + e);
            }
        }
        private Response ReadResponse()
        {
            Response response = null;
            try
            {
                waitHandle.WaitOne();
                lock (responses)
                {
                    response = responses.Dequeue();
                }
            }catch(ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return response;
        }
        private void startReader()
        {
            Thread thread = new Thread(run);
            thread.Start();
        }

        private void closeConnection()
        {
            finished = true;
            try
            {
                stream.Close();
                connection.Close();
                waitHandle.Close();
                client = null;
            }catch(ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        private bool isUpdate(Response response)
        {
            return response.type == ResponseType.NEW_SUBMIT;
        }
        private void handleUpdate(Response response)
        {
            DTOBJCursa[] curse =(DTOBJCursa[])response.data;
            Console.WriteLine("Emoployee submitted from handleUpdate invoked");
            try
            {
                client.AngajatSubmitted(curse);
            }catch(ServerException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public virtual DTOBJCursa[] getCurrentRaces()
        {
            Request request = new Request(RequestType.GET_CURRENT_CURSE);
            sendRequest(request);
            Response response = ReadResponse();
            if (response.type == ResponseType.ERROR)
            {
                string err = response.data.ToString();
                throw new ServerException("Error getting all the races" + err);
            }

            return (DTOBJCursa[])response.data;
        }

        public virtual void login(DTOAngajat angajat, Observer client)
        {
            initializeConnection();
            Request request = new Request(RequestType.LOGIN, angajat);
            sendRequest(request);
            Response response = ReadResponse();
            Console.WriteLine(response.type);
            if (response.type == ResponseType.OK)
            {
                this.client = client;
                return;
            }
            if (response.type == ResponseType.ERROR)
            {
                string err = response.data.ToString();
                closeConnection();
                throw new ServerException("Error login response"+err);
            }
        }


        public virtual void logout(DTOAngajat angajat, Observer client)
        {
            Request request = new Request(RequestType.LOGOUT, angajat);
            sendRequest(request);
            Response response = ReadResponse();
            closeConnection();
            if (response.type == ResponseType.ERROR)
            {
                string err = response.data.ToString();
                throw new ServerException("Error logout response" + err);
            }
        }

        public virtual DTOBJPart[] searchbyteam(string team)
        {
            Request request = new Request(RequestType.SEARCH_BY_TEAM,team);
            sendRequest(request);
            Response response = ReadResponse();
            if (response.type == ResponseType.ERROR)
            {
                string err = response.data.ToString();
                throw new ServerException("Error search request" + err);
            }
            return (DTOBJPart[])response.data;

        }

        public virtual void submitInsc(DTOInfoSubmit infoSubmit)
        {
            Request request = new Request(RequestType.SUBMIT_INSC, infoSubmit);
            sendRequest(request);
            Response response = ReadResponse();
            if (response.type == ResponseType.OK)
            {
                Console.WriteLine("Succesfully submitted");
            }
            if (response.type == ResponseType.ERROR)
            {
                string err = response.data.ToString();
                throw new ServerException("Error submitting " + err);

            }

        }
        
        public virtual void run()
        {
            while (!finished)
            {
                try
                {
                    object response =formatter.Deserialize(stream);
                    Console.WriteLine("Response received" + response);
                    if (isUpdate((Response)response))
                    {
                        handleUpdate((Response)response);
                    }
                    else
                    {
                        lock (responses)
                        {
                            responses.Enqueue((Response)response);
                        }
                        waitHandle.Set();
                    }
                }catch(ServerException E)
                {
                    Console.WriteLine("Reading error" + E);
                }catch(System.IO.IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }catch (System.Runtime.Serialization.SerializationException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}

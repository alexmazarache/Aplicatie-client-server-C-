﻿using Networking.Utils;
using Problem11.Repositories;
using Problem11.Service;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesImplementation
{
    public class StartServer
    {
        static void Main()
        {
            AngajatRepository angajatRepository = new AngajatRepository();
            CursaRepository cursaRepository = new CursaRepository();
            EchipaRepository echipaRepository = new EchipaRepository();
            InscriereRepository inscriereRepository = new InscriereRepository();
            ParticipantRepository participantRepository = new ParticipantRepository();
            Service service = new Service(angajatRepository, cursaRepository, echipaRepository, inscriereRepository, participantRepository);
            IServices serviceImpl = new ServicesImplementation(service);
            Console.WriteLine(service.LocalLogin("mgar1992","12234"));
            SerialServer server = new SerialServer("127.0.0.1", 55555, serviceImpl);
            server.Start();
            Console.WriteLine("Server started ...");
            Console.ReadLine();
        }
    }
}

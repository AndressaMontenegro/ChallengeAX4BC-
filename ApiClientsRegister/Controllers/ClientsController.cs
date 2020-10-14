using ApiClientsRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiClientsRegister.Controllers
{
    public class ClientsController : ApiController
    {
        private static List<Client> clients = new List<Client>();

        public List<Client> Get()
        {
            return clients;
        }

        public void Post (string name, string email, string address, int idClient)
        {
            if (idClient != 0)
                clients.Add(new Client(name, email, address, idClient));
        }

        public void Delete (string name, string email, string address, int idClient)
        {
            clients.RemoveAt(clients.IndexOf(clients.First(x => x.IdClient.Equals(idClient))));
        }
    }
}

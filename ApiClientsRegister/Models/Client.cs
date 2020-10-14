using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClientsRegister.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int IdClient { get; set; }

        public Client (string name, string email, string address, int idClient)
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
            IdClient = idClient++;
        }
            

    }
}
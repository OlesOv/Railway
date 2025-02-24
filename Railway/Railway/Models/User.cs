﻿using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Railway.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public ICollection<Ticket> Tickets { get; set; }
    }
}

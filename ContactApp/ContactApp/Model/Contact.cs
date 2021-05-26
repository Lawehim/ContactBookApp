﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Model
{
    public class Contact
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhotoUrl { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Occupation { get; set; }

        public Address Address { get; set; }
    }
}

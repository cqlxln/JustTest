﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.WebUI.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
    }
    public enum Role
    {
        Admin, User, Guest
    }
}

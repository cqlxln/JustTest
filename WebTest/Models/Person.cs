using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin, User, Guest
    }
}
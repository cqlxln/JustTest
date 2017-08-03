using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebTest.Infrastructure;

namespace WebTest.Models
{
    [NoJoeOnMondays]
    public class Appointment
    {
        public string ClientName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [MustBeTrue(ErrorMessage ="you must accept the terms!!!")]
        public bool TermsAccepted { get; set; }
    }
}
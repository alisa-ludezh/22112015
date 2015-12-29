using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication2
{
    public class Person
    {
        private string personFIO;
        private string personUID;
        private string Job;

        public Person(
            string personUID,
            string personFIO,
            string Job)
        {
            this.personUID = personUID;
            this.personFIO = personFIO;
            this.Job = Job;
        }
    }
}
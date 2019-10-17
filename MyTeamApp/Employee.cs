using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTeamApp
{
    class Employee
    {

        public string Name { get; set; }
        public string Number { get; set; }
        public string Employee_ID { get; set; }
        public string Email_ID { get; set; }
    }

    class Votante
    {

        public string Nombres{ get; set; }
        public string Apellidos { get; set; }
        public string Cedula_ID { get; set; }
        public string Candidato { get; set; }
        public DateTime Fecha { get; set; }
    }

    class EmpConstants
    {
        private const string DOMAIN_NAME = "xyz.com";
    }
}

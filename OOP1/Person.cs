using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Person
    {
        private string _firstname;

        public string Firstname { get => _firstname; set => _firstname = value; }

        public string Lastname { get; set; }

        public string GetFullName()
        {
            return Firstname + " " + Lastname;
        }
    }
}

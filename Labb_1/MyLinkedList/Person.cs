using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    internal class Person
    {
        private string firstName, lastName;
        private Int64 pnr;

        public Person(string firstName, string lastName, Int64 pnr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pnr = pnr;
        }

        public string Name { get { return $"{firstName} {lastName}"; } }

        public Int64 Pnr { get { return pnr; } }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public override string ToString() 
        {
            return $"Namn: {Name}, Pnr: {Pnr}";
        }

    }
}

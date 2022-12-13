using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCshap3
{
    internal class Person
    {
        private int _currentID { get;  set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
        public Person(string firstname,
            string lastName,
            string city,
            string state)
        {
            this.ID = GetNextId();
            this.FirstName = firstname;
            this.LastName = lastName;
            this.City = city;
            this.State = state;
        }

        private int GetNextId() => ++_currentID;

        public void Descontruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }
    }
}

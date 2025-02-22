using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_people
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string DataString()
        {
            return Id + ";" + Surname + ";" + Name;
        }
        public Person() { }
        public Person(string id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}

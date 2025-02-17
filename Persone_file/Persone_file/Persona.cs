using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Persone_file
{
    internal class Persona
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string surname;
        public string Surname { get { return surname; } set { surname = value; } }
        private string listtext;
        public string Listtext { get { return listtext; } }

        public void OttieniLista()
        {
           listtext = Id + " - " + Name + " - " + Surname;
        }
        public Persona(string id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;

        }
    }
}

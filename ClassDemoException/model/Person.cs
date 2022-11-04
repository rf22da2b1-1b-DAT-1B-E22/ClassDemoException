using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoException.model
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string adr)
        {
            Name = name;
            Adr = adr;
        }

        public string Name { get; set; }
        public string Adr { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Adr)}={Adr}}}";
        }
    }
}

using ClassDemoException.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoException.kataloger
{
    public class PersonKatalog
    {
        private List<Person> _personer;

        public PersonKatalog()
        {
            _personer = new List<Person>();
        }

        public List<Person> GetAll()
        {
            return new List<Person>(_personer);
        }


        public void Add(Person p)
        {
            _personer.Add(p);
        }


    }
}

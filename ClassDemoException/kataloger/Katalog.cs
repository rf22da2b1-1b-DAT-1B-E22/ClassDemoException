using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoException.kataloger
{
    public class Katalog<T>
    {
        private List<T> _elementer;


        public Katalog()
        {
            _elementer = new List<T>();
        }



        public List<T> GetAll()
        {
            return new List<T>(_elementer);
        }


        public void Add(T element)
        {
            _elementer.Add(element);
        }
    }
}

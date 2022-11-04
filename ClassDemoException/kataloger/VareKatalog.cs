using ClassDemoException.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoException.kataloger
{
    public class VareKatalog
    {
        private List<Vare> _varer;

        public VareKatalog()
        {
            _varer = new List<Vare>();
        }

        public List<Vare> GetAll()
        {
            return new List<Vare>(_varer);
        }


        public void Add(Vare v)
        {
            _varer.Add(v);
        }

    }
}

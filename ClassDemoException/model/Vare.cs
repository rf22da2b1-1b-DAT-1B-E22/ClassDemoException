using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoException.model
{
    public class Vare
    {
        // instans felter
        private string _navn;
        private double _pris;
        private int _antalPåLager;


        // properties
        public string Navn
        {
            get { return _navn; }
            set { 

                if (value is null || value.Length < 4)
                {
                    throw new ArgumentException("navnet skal være over 3 tre tegn langt");
                }
                _navn = value; 
            }
        }

        public double Pris { 
            get { return _pris; }
            set { 
                if (value < 0)
                {
                    throw new ArgumentException("Prisen må ikke være negativ");
                }
                _pris = value; 
            }
        }

        public int AntalPåLager
        {
            get { return _antalPåLager; }
            set {

                if (value >= 0)
                {
                    _antalPåLager = value;
                }
                else
                {
                    throw new ArgumentException("Vi kan ikke have et negativt lager");
                }
            }
        }



        // konstruktør
        public Vare():this("dummy", 0, 0)
        {

        }

        public Vare(string navn, double pris, int lager)
        {
            _navn = navn;
            _pris = pris;
            _antalPåLager = lager;
        }




        // to string
        public override string ToString()
        {
            return $"Navn={_navn} Pris={_pris} varer på lager={_antalPåLager}";
        }
    }
}

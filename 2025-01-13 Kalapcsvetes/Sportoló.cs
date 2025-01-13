using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_13_Kalapcsvetes
{
    internal class Sportoló
    {
        public string Helyezés { get; set; }
        public string Eredmény { get; set; }
        public string SportolóNeve { get; set; }
        public string SportolóKódja { get; set; }
        public string Helyszín { get; set; }
        public string Dátum { get; set; }


        public Sportoló(string sor)
        {
            sor.Split(";");   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWEBProject
{
    internal class  Immo                                                                                                                                        
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string straat { get; set; }
        public int huisnummer { get; set; }
        public int gemeente { get; set; }
        public double prijs { get; set; }
        public int bouwjaar { get; set; }
        public int kamers { get; set; }
        public int grootte { get; set; }
        public string tuin { get; set; }
        public string type { get; set; }
    }
}

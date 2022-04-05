using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeezaalLib
{
    public class Reader
    {
        public  int ReferenceNumber { get; set; }
        public  Random rnd { get; set; } = new Random();

        public int HatIndex 
        {
            get
            {
                return rnd.Next(Hat.Hats().Length);
            }
        }
        public Magazine Magazin { get; set; }=new Magazine();
        

    }
}

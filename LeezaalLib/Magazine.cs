using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeezaalLib
{
    public class Magazine
    {
        public Random rng { get; set; }=new Random();
        public string[] ColorList { get; set; } = MagazineColors.Colors();

        public int Kleur 
        {
            get
            {
                return rng.Next(ColorList.Length);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeezaalLib
{
    public class Person
    {
        Random random = new Random();
        public int Age
        {
            get
            {
                return random.Next(12, 71);
            }
        }
        public string Name { get; set; }
    }
}

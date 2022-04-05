using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeezaalLib
{
    public class ReadingRoom
    {
        public List<string> Readers = new List<string>();
        public List<string> Add(int chiffre)
        {
            Readers = new List<string>();

            for (int i = 0; i <= chiffre; i++)
            {
                Readers.Add(i.ToString());
            }
            return Readers;
        }
    }
}

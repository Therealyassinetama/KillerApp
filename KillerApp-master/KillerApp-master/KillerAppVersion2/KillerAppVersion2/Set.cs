using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppVersion2
{
    internal class Set
    {
        public Set(string Setname)
        {
            name = Setname;

            for(int i = 1; i <= 10; i++)
            {
                Serie serie = new Serie("Serie " + i.ToString());
                series.Add(serie);
            }
        }

        

        public string name { get; set; }
        public int value { get; set; }


        public List<Serie> series = new List<Serie>();

        public override string ToString()
        {
            return name;
        }
    }
}

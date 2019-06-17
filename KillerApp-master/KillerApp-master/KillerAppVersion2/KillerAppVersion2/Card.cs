using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppVersion2
{
    class Card
    {
        public Card(string naam)
        {
            name = naam;
        }

        public string name { get; set; }
        public int value { get; set; }

        
        public override string ToString()
        {
            return name;
        }
    }
}

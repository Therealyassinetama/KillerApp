using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppVersion2
{
    class Serie
    {
        public Serie(string serienr)
        {
            name = serienr;
            for (int i = 1; i <= 10; i++)
            {
                Card card = new Card(("card " + i.ToString()));
                cards.Add(card);
            }
        }

        public string name { get; set; }
        public int value { get; set; }



        public List<Card> cards = new List<Card>();

        public override string ToString()
        {
            return name;
        }
    }
}

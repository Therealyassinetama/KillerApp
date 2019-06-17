using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppVersion2
{
    class User
    {
        private string Username;
        private string Password;

        public List<Card> collectedcards = new List<Card>();

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string username { get { return Username; } set { } }
        public string password { get; set; }
    }
}

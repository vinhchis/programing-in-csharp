using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS03
{
    public delegate void CallEvent(string s);
    public delegate void CallMethod();

    internal class CardList : IEnumerable
    {
        public List<PhoneCard> List { get; set; }
        public event CallEvent ShowMessage;

        public CardList()
        {
            List = new List<PhoneCard>();
            ShowMessage += Warning; 
        }

        private void Warning(string s)
        {
            Console.WriteLine("Erorr: " + s);
        }

        public void AddNew()
        {
            var card = new PhoneCard();

            card.Input();
            List.Add(card);
            Console.WriteLine("\tAdded Successfully!!!");
        }

        public void Show()
        {
            if (List.Count == 0)
            {
                ShowMessage("No things to display");
                
            }
            Console.WriteLine("\tList Phone Card:");
            foreach (PhoneCard card in this)
            {
                Console.WriteLine(card);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}

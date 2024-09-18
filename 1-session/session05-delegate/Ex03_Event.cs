using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05_Delegate
{
    internal class Ex03_Event
    {
        delegate void ChangeLabel();
        event ChangeLabel onClick;

        void toSave()
        {
            Console.WriteLine("+ Save");
        }

        void toAdd()
        {
            Console.WriteLine("+ Add New");
        }

        static void Main(string[] args)
        {
            var events = new Ex03_Event();
            events.onClick += events.toSave; //Literal
            events.onClick += new ChangeLabel(events.toAdd); //Constructor

            Console.WriteLine("Event Lists: ");
            events.onClick.Invoke();

            Console.WriteLine("Event lists after Removing toAdd: ");
            events.onClick -= events.toAdd;
            events.onClick();
            Console.ReadKey();
        }
    }
}



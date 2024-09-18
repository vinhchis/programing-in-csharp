using System;
using System.Text;


namespace Session01
{
    internal class Ex03_Enumeration
    {
        
        String hang = "Nga";
        enum phoneNo : int { Max = 12, Min = 8}
        enum Day { Mon, Tue, Wed, Thur, Fri, Sat, Sun}

        public Ex03_Enumeration()
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Hằng {hang}");
        }
        void getPhone()
        {
            int max = (int)phoneNo.Max;
            int min = (int)phoneNo.Min;
            Console.WriteLine($"Phone no is in {min} and {max}");
            Console.WriteLine("Name of limition: ");
            foreach (string phone in Enum.GetNames(typeof(phoneNo))) {
                Console.WriteLine(phone);
                    }
            foreach(int phone in Enum.GetValues(typeof(phoneNo))) {  Console.WriteLine(phone); }
        }

        void translate(Day day)
        {
            switch (day) {
                case Day.Mon:
                    Console.WriteLine("Thu Hai");
                    break;
                case Day.Tue:
                    Console.WriteLine("Thu Ba");
                    break;
                case Day.Wed:
                    Console.WriteLine("Thu Tu");
                    break;
                case Day.Thur:
                    Console.WriteLine("Thu Nam");
                    break;
                case Day.Fri:
                    Console.WriteLine("Thu Sau");
                    break;
                case Day.Sat:
                    Console.WriteLine("Thu Bay");
                    break;
                case Day.Sun:
                    Console.WriteLine("Chu nhat");
                    break;
            }
        }

        void display()
        {
            Console.WriteLine("All days: ");
            foreach(Day day in Enum.GetValues(typeof (Day)))
            {
                Console.WriteLine(day.ToString());
            }
        }
        public static void Main(string[] args)
        {
            var ex03 = new Ex03_Enumeration();
            ex03.getPhone();
            ex03.translate(Day.Tue);
            ex03.display();
            Console.ReadKey();
        }
    }
}

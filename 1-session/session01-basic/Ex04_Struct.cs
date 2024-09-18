using System;


namespace Session01
{
    public struct Student {
        public string name;
        public string subject;
        public float marks;

        public Student(string name, string subject, float marks)
        {
            this.name = name;
            this.subject = subject;
            this.marks = marks;
        }
    }
    internal class Ex04_Struct
    {

         static void Main(string[] args)
        {
            var sv = new Student("Le Van A", "C#", 100.0f);
            Console.WriteLine("==========Student Information==========");
            Console.WriteLine($"{sv.name} - {sv.subject} - {sv.marks}");
            Console.ReadKey();
        }
    }
}

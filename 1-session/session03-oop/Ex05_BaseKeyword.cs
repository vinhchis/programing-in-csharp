using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    class SupperClass
    {
        protected int marks;
        
        public SupperClass() {
            Console.WriteLine("Supper class is running....");
            Console.WriteLine("----------------------------");
        }

        public virtual int getMarks()
        {
            return marks;
        }

        public virtual void makeReport(int n)
        {
            Console.WriteLine("1st Exam (Fail cao): 39");
            Console.WriteLine($"2nd Exam: {n} marks");
        }
    }
    internal class Ex05_BaseKeyword: SupperClass
    {
        public Ex05_BaseKeyword(): base() { }
        //public override int getMarks(){}
        public void setMarks(int n)
        {
            marks = n;
        }
        public override void makeReport(int n)
        {
            Console.WriteLine("Child class call makeReport() from Parent class");
            base.makeReport(n);
        }
        static void Main(string[] args)
        {
            var ex05 = new Ex05_BaseKeyword();
            Console.WriteLine("Enter student marks: ");
            ex05.setMarks(int.Parse(Console.ReadLine()));
            ex05.makeReport(ex05.getMarks());

            Console.ReadKey();
        }
    }
}

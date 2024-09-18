using System;


namespace Session04_Properties
{
    internal class Ex05_Exception
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a whole number: ");
                int num = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException oe) {
                Console.WriteLine(oe.Message);
            }
            finally
            {
                Console.WriteLine("Saving your works.....");
            }
        }
    }
}

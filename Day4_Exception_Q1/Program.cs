using System.Globalization;

namespace Day4_Exception_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter the start date(dd/MM/yyyy hh:mm:ss tt): ");
                DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);

                Console.Write("Enter the end date(dd/MM/yyyy hh:mm:ss tt): ");
                DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);

                Console.WriteLine("Starting Date: " + startDate);
                Console.WriteLine("Ending Date: " + endDate);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid date format...");
            }
        }
    }
}

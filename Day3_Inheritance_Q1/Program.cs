using System;

namespace Day3_Inheritence
{
    internal class Program
    {
        public class Customer
        {
            public int CustomerAge { get; set; }
            public string CustomerName { get; set; }

            public string CustomerMobile { get; set; }
            public string CustomerCity { get; set; }

            public void DisplayCustomer()
            {
                Console.WriteLine("Name :" + CustomerName + "\nAge :" + CustomerAge + "\nMobile :" + CustomerMobile + "\nCity :" + CustomerCity);

            }

            public virtual double GenerateBillAmount(int amount)
            {
                return amount;
            }



        }


        public class SeniorCitizenCustomer : Customer
        {
            public override double GenerateBillAmount(int amount)
            {
                double total = amount - (amount * 0.12);
                return total;
            }

        }

        public class PrivilegeCustomer : Customer
        {

            public override double GenerateBillAmount(int amount)
            {
                double total = (amount) - (amount * 0.3);
                return total;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1.Previlege Customer\n2.Senior Citizen customer\nEnter Customer Type");
            int custType = int.Parse(Console.ReadLine());

            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter the City: ");
            string city = Console.ReadLine();

            Console.Write("Enter the Mobile Number: ");
            string mobile = Console.ReadLine();

            Console.Write("Enter the Purchased Amount: ");
            int purchase = int.Parse(Console.ReadLine());


            Console.WriteLine("\n\nBILL DETAILS");

            Customer customer = new Customer();
            customer.CustomerName = name; customer.CustomerAge = age; customer.CustomerCity = city; customer.CustomerMobile = mobile;

            customer.DisplayCustomer();


            if (custType == 1)
            {
                Customer pcust = new PrivilegeCustomer();
                Console.WriteLine("Your bill amount is Rs " + purchase);
                Console.WriteLine("Your bill amount is discount under privilege customer You have to pay Rs " + pcust.GenerateBillAmount(purchase));


            }
            else if (custType == 2)
            {
                Customer scust = new SeniorCitizenCustomer();
                Console.WriteLine("Your bill amount is Rs " + purchase);
                Console.WriteLine("Your bill amount is discount under Senior customer You have to pay Rs " + scust.GenerateBillAmount(purchase));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}

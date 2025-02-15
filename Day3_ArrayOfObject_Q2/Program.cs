namespace Day3_ArrayOfObject_Q2
{
    internal class Program
    {
        class Customer
        {
            public double FeedbackRating { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }

            public Customer(double feed,string name, string mob)
            {
                this.FeedbackRating = feed;
                this.Name = name;
                this.Mobile = mob;
                
            }





        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of customers :");
            int totalCust=int.Parse(Console.ReadLine());

            Customer[] arr = new Customer[totalCust];
            double tRating = 0;

            for (int i = 0; i < totalCust; i++)
            {
                Console.WriteLine("Enter Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Mobile no. :");
                string mob = Console.ReadLine();
                Console.WriteLine("Enter rating out of 5 :");
                double rate=double.Parse(Console.ReadLine());

                arr[i] =new Customer(rate, name, mob);
            }

            Console.WriteLine("=====================================");

            for (int i = 0; i < totalCust; i++)
            {
                Console.WriteLine($"Customer {i + 1}: {arr[i].FeedbackRating} out of 5");
                tRating += arr[i].FeedbackRating;
            }

            Console.WriteLine("=====================================");

            double avgRating = tRating/totalCust;
            Console.WriteLine($"\n\nAverage Rating is {avgRating} out of 5");

        }
    }
}

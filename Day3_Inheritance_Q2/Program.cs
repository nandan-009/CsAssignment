namespace Day3_Inheritance_Q2
{
    public class Account
    {
        private string holderName;
        private long accountNumber;
        private string IFSCCode;
        private long contactNumber;

        public Account(string holderName, long accountNumber, string IFSCCode, long contactNumber)
        {
            this.holderName = holderName;
            this.accountNumber = accountNumber;
            this.contactNumber = contactNumber;
            this.IFSCCode = IFSCCode;

        }
        public Account()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Your Contact Details\nHolder name :{holderName}\nAccount Number :{accountNumber}\nIFSC Code :{IFSCCode}\nContact Number :{contactNumber}");


        }
    }

    public class SavingAccount : Account
    {
        private double intrestRate;

        public SavingAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, double interestRate) : base(holderName, accountNumber, IFSCCode, contactNumber)
        {
            this.intrestRate = interestRate;
        }



        public void Display()
        {
            base.Display();
            Console.WriteLine("Intrest rate :" + intrestRate);
        }
    }

    public class CurrentAccount : Account
    {
        private string organizationName;
        private long TIN;

        public CurrentAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, string organizationName, long TIN) : base(holderName, accountNumber, IFSCCode, contactNumber)
        {
            this.organizationName = organizationName;
            this.TIN = TIN;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Organization Name :{organizationName}\nTIN :{TIN}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
            string name = Console.ReadLine();
            long acc = long.Parse(Console.ReadLine());
            string ifsc = Console.ReadLine();
            long contact = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter account Type");
            string accType = Console.ReadLine();
            if (accType == "current")
            {
                Console.WriteLine("Enter Organization Name");
                string oname = Console.ReadLine();
                Console.WriteLine("Enterv TIN number");
                int tin = int.Parse(Console.ReadLine());

                CurrentAccount ca = new CurrentAccount(name, acc, ifsc, contact, oname, tin);

                ca.Display();

            }
            else if (accType == "saving")
            {
                Console.WriteLine("Enter Intrest Rate");
                double ir = double.Parse(Console.ReadLine());

                SavingAccount sa = new SavingAccount(name, acc, ifsc, contact, ir);

                sa.Display();
            }
        }
    }
}

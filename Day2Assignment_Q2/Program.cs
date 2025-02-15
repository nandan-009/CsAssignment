namespace Day2Assignment_Q2
{
    internal class Program
    {
        class Account
        {
            public int AccountNo;
            public string CustName;
            public string AccType;
            public string TrasactionType;
            public double Balance;

            public Account(int accno,string name, string actype,string ttype,double bal) 
            {
                this.AccountNo = accno; 
                this.CustName = name;
                this.AccType = actype;
                this.TrasactionType = ttype;
                this.Balance = bal;

            }

            public void DoTransaction(int accNo, string accType, string transacType, double amt)
            {
                if (transacType == "d" || transacType == "D")
                {
                    Credit(amt);
                }
                else if (transacType == "W" || transacType == "w")
                {
                    Debit(amt);
                }
                else
                {
                    Console.WriteLine("Invalid transaction Type");
                }
            }

            public void Credit(double amt) {
                Balance = Balance + amt;
            }

           public void Debit(double amt) {
                Balance = Balance - amt;
            }

            public void showData()
            {
                Console.WriteLine($"Account No :{AccountNo}\nAccount Name :{CustName}\nAccount type :{AccType}\nBalance :{Balance}");
            }
        }
        static void Main(string[] args)
        {
            Account account = new Account(1,"abc","savings","d",4000);
            int op = 0;
            do
            {
                Console.WriteLine("1.To transaction\n2.To Display\n3.To Exit");
                op = int.Parse(Console.ReadLine());
                if(op == 1)
                {
                    account.DoTransaction(1,"savings","d",300);
                }
                else if (op == 2)
                {
                    account.showData();
                }
                else
                {
                    Console.WriteLine("Ivalid");
                }

            } while (op == 3);
        }
    }
}

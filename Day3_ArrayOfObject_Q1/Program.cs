namespace Day3_ArrayOfObject_Q1
{
    internal class Program
    {

        class Employee
        {
            public int Ecode { get; set; }
            public string Ename { get; set; }
            public int Salary { get; set; }
            public int DeptId { get; set; }

            public Employee(int ecode,string ename, int sal,int dept)
            {
                this.Ecode = ecode;
                this.Ename = ename;
                this.Salary = sal;
                this.DeptId = dept;
            }

            public override string ToString()
            {
                return $"Employee ID :{Ecode}\nEmployee Name :{Ename}\nSalary :{Salary}\nDeptId :{DeptId}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter total emps :");
            int etotal = int.Parse(Console.ReadLine());


            Employee[] emps = new Employee[etotal];
            int totalSal = 0;


            for (int i = 0; i < etotal; i++)
            {
                Console.WriteLine($"Enter Employee {i + 1} Code :");
                int ecode = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Employee {i + 1} Name :");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter Employee {i + 1} Salary :");
                int sal = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Employee {i + 1} Dept :");
                int dept = int.Parse(Console.ReadLine());

                //Employee emp = new Employee(ecode, name, sal, dept);

                //emps[i] = emp;

                emps[i] = new Employee(ecode, name, sal, dept);


            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < emps.Length; i++)
            {

                Console.WriteLine(emps[i].ToString());
                totalSal += emps[i].Salary;
                Console.WriteLine("===========================================");
            }


            Console.WriteLine($"Total salary : {totalSal}");
        }
    }
}

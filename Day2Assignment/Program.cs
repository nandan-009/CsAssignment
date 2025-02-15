using System.ComponentModel.DataAnnotations;

namespace Day2Assignment
{

    class Person
    {
        string name;
        string city;

        void Display()
        {
            Console.WriteLine("Name :"+name+" City :"+city);
        }
    }

    class Student : Person
    {
        int total_Marks;
        public bool IsOutstanding(int total_Marks)
        {
            if (total_Marks > 90)
            {
                return true;
            }
            return false;
        }
    }

    class Faculty : Person
    {
        int no_of_book_published;

        public bool IsOutstanding(int no_of_book_published)
        {
            if (no_of_book_published > 5)
            {
                return true;
            }
            return false;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Faculty faculty = new Faculty();

            Console.Write("Enter marks: ");
            int marks=int.Parse(Console.ReadLine());

            Console.Write("Enter books published: ");
            int nob=int.Parse(Console.ReadLine());


            if (student.IsOutstanding(marks))
            {
                Console.WriteLine("Marks is Outstanding");
            }

            if (faculty.IsOutstanding(nob))
            {
                Console.WriteLine("faculty is Outstanding");
            }

        }
    }


}

﻿namespace Day5_LINQ_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of courseed:");
            int num = int.Parse(Console.ReadLine());

            List<Course> courses = new List<Course>();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Course{i + 1} Details");

                Console.WriteLine("Enter the id");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the category");
                string cat = Console.ReadLine();
                Console.WriteLine("Enter the price");
                int price = int.Parse(Console.ReadLine());

                courses.Add(new Course(id, name, cat, price));
            }
            Console.WriteLine("Enter the price limit");
            Console.WriteLine("Enter the min limit");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the min limit");
            int max = int.Parse(Console.ReadLine());

            var filcourse = courses.Where(c => c._price >= min && c._price <= max).ToList();

            if (filcourse.Count > 0)
            {
                Console.WriteLine($"Course which is limit {min} to {max}");
                foreach (var course in filcourse)
                {
                    Console.WriteLine($"Course {courses.IndexOf(course) + 1} Details");
                    Console.WriteLine(course);
                }
            }
            else
            {
                Console.WriteLine("No course available in this limit");
            }
        }
    }
    public class Course
    {
        private string _id;
        private string _name;
        private string _category;
        public int _price;

        public Course(string id, string name, string category, int price)
        {
            _id = id;
            _name = name;
            _category = category;
            _price = price;

        }
        public override string ToString()
        {
            return $"Course id:{_id}\nCourse Name: {_name}\nCourse Category: {_category}\nCourse Price:{_price}";
        }
    }
}

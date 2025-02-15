namespace Day5_LINQ
{
    class Book
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string PublisherName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public Book(string Code,string name,string publisher,string author,double price)
        {
            this.BookCode = Code;
            this.BookName = name;
            this.PublisherName = publisher;
            this.AuthorName = author;
            this.Price = price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            list.Add(new Book("ASPNA", "ASP.NET Professinal", "Wrox", "Bill Evjen,Matt Gibbs", 750));
            list.Add(new Book("ASPNB", "Beginning ASP.NET", "TechMedia", "Dan Wahlin,Dave Reed", 545));
            list.Add(new Book("LNQA", "Learning LINQ", "APress", "Steve  Eichert", 400));
            list.Add(new Book("CSPN", "C# Developers Guide", "Tata McGrow", "dan Manhary", 675));

            var book = list;

            string str = Console.ReadLine();
            string str2 = str.ToUpper();

            var result = from e in book
                         where e.BookCode ==  str2
                         select e;

            

            foreach (var r in result)
            {
                Console.WriteLine($"{r.BookCode}\t{r.BookName}\t{r.PublisherName}\t{r.AuthorName}\t{r.Price}");

            }

            Console.WriteLine("===============================");

            var result2 = from p in book
                         where p.Price > 200 && p.Price <600
                         select p;


            foreach (var r in result2)
            {
                Console.WriteLine($"{r.BookCode}\t{r.BookName}\t{r.PublisherName}\t{r.AuthorName}\t{r.Price}");

            }
        }
    }
}

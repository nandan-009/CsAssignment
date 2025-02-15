namespace Day4_Collection
{
    class Product : IComparable<Product>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string description, double price)
        {
            this.ProductId = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;

        }

        public override string ToString()
        {
            return ProductId + "  " + Name + "  " + Description + "  " + Price;
        }

        public int CompareTo(Product? other)
        {
            if (this.ProductId > other.ProductId)
            {
                return 1;
            }
            else if (this.ProductId < other.ProductId)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class NameSort : IComparer<Product>
    {
        public  int Compare(Product? x, Product? y)
        {
            if (x.Name.CompareTo(y.Name) == 0)
            {
                return x.Description.CompareTo(y.Description);
            }
            else
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }

    class PriceSort : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else if (x.Price < y.Price)
            {
                return -1;
            }
            else
            {
                if (x.ProductId > y.ProductId)
                {
                    return 1;
                }
                else if (x.ProductId < y.ProductId)
                {
                    return -1;

                }
                else { return 0; }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(200, "Dell", "15 inch Monitor", 3400.44);
            Product p2 = new Product(120, "Dell", "Laptop", 45000.00);
            Product p3 = new Product(150, "Microsoft", "Windows 7", 7000.50);
            Product p4 = new Product(100, "Logitech", "Optical Mouse", 540.00);


            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            Console.WriteLine("1.Default sort\n2.Name Sort\n3.Price sort");
            int inp = int.Parse(Console.ReadLine());

            switch (inp)
            {
                case 1:
                    {
                        products.Sort();
                        break;
                    }
                case 2:
                    {
                        products.Sort(new NameSort());
                        break;
                    }
                case 3:
                    {
                        products.Sort(new PriceSort());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error input");
                        break;
                    }


            }
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}

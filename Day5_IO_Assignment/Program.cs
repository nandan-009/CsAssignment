namespace Day5_IO_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadTextFormat();
        }



        static void ReadTextFormat()
        {
            FileStream fs1 = null;
            FileStream fs2 = null;
            try
            {
                fs1 = new FileStream("products.txt", FileMode.Open, FileAccess.Read);
                fs2 = new FileStream("products_updated.txt", FileMode.Create, FileAccess.Write);

                StreamReader sr = new StreamReader(fs1); 
                StreamWriter sw = new StreamWriter(fs2);


                string str = sr.ReadLine();

                while (!String.IsNullOrEmpty(str))
                {
                    //Console.WriteLine(str);
                    
                    string[] cols = str.Split(",");
                    double price = double.Parse(cols[2]);
                    if (price < 1000)
                    {
                        price = price + (price * 0.1);
                    }
                    else if(price >1000 && price < 5000)
                    {
                        price = price - (price * 0.05);
                    }
                    else { }

                    cols[2] = " "+price;

                    string str2 = string.Join(", ", cols);


                    sw.WriteLine(str2);

                    

                    str = sr.ReadLine();
              
                }
                sr.Close();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs1.Close();
                fs2.Close();
            }
        }

    }
}

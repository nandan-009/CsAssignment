namespace Day4_Exception_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the booking Details");
                string sd = Console.ReadLine();
                Console.WriteLine("Enter the seat number to Book: ");
                int sn = int.Parse(Console.ReadLine());

                if (sd[sn - 1].Equals('0'))
                {
                    Console.WriteLine("Seat Booked");
                }
                else
                {
                    throw new SeatNotAvailableException("Seat Booked already");
                }
            }
            catch (SeatNotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        class SeatNotAvailableException : Exception
        {
            public SeatNotAvailableException(string message) : base(message)
            {

            }
        }
    }
}

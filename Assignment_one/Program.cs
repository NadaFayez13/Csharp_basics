namespace Assignment_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
// question one 
            Book book;
            book  = new Book();

            object obj = book;

            Console.WriteLine(obj);

// question two
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

// question three

            //int pages = "464";
            //Compile-time error — you can't put text (string) into an int variable. 
            //int pages = 464;

// question four
            try
            {
                int x = 10; int y = 0;
                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally { Console.WriteLine("done"); }

// question five
            int pages = 300;
            double Pages = pages;

// question six
            double Price = 49.99;
            int int_Price = (int)Price;
        }
    }
}

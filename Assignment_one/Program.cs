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

        }
    }
}

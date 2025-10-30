namespace Assignment_3_Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("1", "python", new[] {"ali"}, new DateTime(2008, 8, 1), 450m),
                new Book("2", "java", new[] {"amr"}, new DateTime(1999, 10, 30), 500m),
                new Book("3", "c#", new[] {"tone"}, new DateTime(2018, 10, 16), 300m)
            };

          
            LibraryEngine.ProcessBooks(books, new LibraryEngine.BookFunctionPointer(BookFunctions.GetTitle));

       
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

    
            LibraryEngine.ProcessBooks(books, delegate (Book B)
            {
                return $"Price: {B.Price}";
            });

           
            
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Adv
{
    internal static class LibraryEngine
    {
        
        public delegate string BookFunctionPointer(Book B);

        
        public static void ProcessBooks(List<Book> bList, BookFunctionPointer fPtr)
        {
            foreach (Book B in bList)
                Console.WriteLine(fPtr(B));
        }

       
        public static void ProcessBook(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
                Console.WriteLine(fPtr(B));
        }
    }
}

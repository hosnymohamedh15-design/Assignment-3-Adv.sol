using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Adv
{
    internal static class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Title: {B.Title}";
        }

        public static string GetAuthors(Book B)
        {
            return $"Authors: {string.Join(", ", B.Authors)}";
        }

        public static string GetPrice(Book B)
        {
            return $"Price: {B.Price:C}";
        }
    }
}

using _2_8_lesson_inpdp.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class BookPriceExtensionMethods
    {
        public static double TotalPrice(this List<Book> books)
        {
            double totalPrice = 0;
            foreach (var book in books)
            {
                totalPrice += book.Price;
            }
            return totalPrice;  
        }
    }
}

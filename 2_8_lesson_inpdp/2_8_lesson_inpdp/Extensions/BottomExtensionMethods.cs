using System;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class BottomExtensionMethods
    {
        public static void GetBottom(this int bottomNumber)
        {
            var countBottomNumber = 0;
            for (var i = 1; i <= bottomNumber; i++)
            {
                if (bottomNumber % i == 0)
                {
                    countBottomNumber++;
                }
            }
            if (countBottomNumber == 2)
            {
                Console.WriteLine("tub son"); 
            }
            else
            {
                Console.WriteLine("tub son emas");
            }
        }
    }
}

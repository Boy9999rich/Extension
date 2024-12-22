using System;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class IntExtensionMethods
    {
        public static int GetRooms(this int number)
        {
            return Convert.ToString(number).Length;
        }
        public static void DecreaseValue(this ref int number, int value)
        {
            number += value;
        }
    }
}

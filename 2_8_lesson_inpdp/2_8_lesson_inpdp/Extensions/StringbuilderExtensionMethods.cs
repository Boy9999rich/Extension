using System.Text;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class StringbuilderExtensionMethods
    {
        public static int GetCountDigits(this StringBuilder sb)
        {
            var countDigit = 0;
            for (var i = 0; i < sb.Length; i++)
            {
                if (char.IsDigit(sb[i]))
                {
                    countDigit++;
                }
            }
            return countDigit;
        }
    }
}

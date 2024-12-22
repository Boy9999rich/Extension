using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class CapitalExtensionMethod
    {
        public static int GetCapitalLetter(this StringBuilder countLetter)
        {
            var countCapitalLetter = 0;
            for (var i = 0; i < countLetter.Length; i++)
            {
                if (char.IsUpper(countLetter[i]))
                {
                    countCapitalLetter++;
                }
            }
            return countCapitalLetter;
        }
    }
}

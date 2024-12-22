using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class GetEvenExtensionMethod
    {
        public static bool GetEven(this int even)
        {
            
            if (even % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}

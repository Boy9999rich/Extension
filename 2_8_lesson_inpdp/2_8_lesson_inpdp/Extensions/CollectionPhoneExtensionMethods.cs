using _2_8_lesson_inpdp.Module;
using System.Collections.Generic;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class CollectionPhoneExtensionMethods
    {
        public static double GetTotalWeight(this List<Phone> phoneList)
        {
            double totalWeight = 0;

            foreach (var phone in phoneList)
            {
                totalWeight += phone.Weight;

            }
            return totalWeight;
          
        }
    }
}

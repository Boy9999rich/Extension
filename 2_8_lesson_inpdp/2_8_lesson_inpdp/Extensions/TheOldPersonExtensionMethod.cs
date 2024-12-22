using _2_8_lesson_inpdp.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_lesson_inpdp.Extensions
{
    public static class TheOldPersonExtensionMethod
    {
        public static int GetOldPerson(this List<Person> persons)
        {
            if (persons == null || persons.Count == 0)
            {
                throw new Exception("you must work right");
            }

            var maxPerson = persons[0];
            for (var i = 0; i < persons.Count(); i++)
            {
                if (persons[i].Age > maxPerson.Age)
                {
                    maxPerson = persons[i];
                }
            }
            return maxPerson.Age;
        }
    }
}

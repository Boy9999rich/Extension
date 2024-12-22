using _2_8_lesson_inpdp.Extensions;
using _2_8_lesson_inpdp.Module;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace _2_8_lesson_inpdp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("book1 ", 20 ),
                new Book ("book2 ", 14),
                new Book("book3", 58),
            };
            var res = books.TotalPrice();
            Console.WriteLine(res);


            //List<Person> list = new List<Person>();
            //list.Add(new Person
            //{
            //    Name = "suhrob",
            //    Age = 98,
            //});

            //list.Add(new Person
            //{
            //    Name = "boyka",
            //    Age = 148,
            //});

            //list.Add(new Person
            //{
            //    Name = "moyka",
            //    Age = 1,
            //});

            //var res = list.GetOldPerson();
            //Console.WriteLine(res);


            // for CapitalLetter

            //StringBuilder sb =new StringBuilder(" boyka moyka TOYKA");
            //var res = sb.GetCapitalLetter();
            //Console.WriteLine(res);


            // for capitalLetter

            //Console.WriteLine("Enter firstNumber");
            //var res = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //var secondRes = double.Parse(Console.ReadLine());
            //var result = res.AddNumber(secondRes);
            //Console.WriteLine(result);




            // for bottom

            //var bottom = 20;
            //bottom.GetBottom();
            //Console.WriteLine(bottom);




            // for even

            //int evenValue = 135;
            //var res = evenValue.GetEven();
            //Console.WriteLine(res);








            //StringBuilder life = new StringBuilder("hello 45 45 ok");
            //Console.WriteLine(life);
            //var result = life.GetCountDigits();
            //Console.WriteLine(result);

            //int intValue = 45678;
            //Console.WriteLine(intValue.GetRooms());
            //intValue.DecreaseValue(65);
            //Console.WriteLine(intValue);

            //List<Phone> phones = new List<Phone>();
            //phones.Add(new Phone
            //{
            //    Model = "iphone",
            //    Weight = 210,
            //});

            //phones.Add(new Phone
            //{
            //    Model = "Redmi",
            //    Weight = 350,
            //});
            //var res = phones.GetTotalWeight();
            //Console.WriteLine(res);

        }

        
    }

}

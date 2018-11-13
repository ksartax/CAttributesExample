using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CAtributesExample
{
    class Program
    {
        public class C
        {
            [Display(Name = "Wiek")]
            public int Age { get; set; }
        }

        private static PropertyInfo[] GetProperties(object obj)
        {
            return obj.GetType().GetProperties();
        }

        static void Main(string[] args)
        {
            var a = new C() { Age = 1 };

            var properties = GetProperties(a);
            foreach (var p in properties)
            {
                string name = p.Name;
                var sa = p.GetCustomAttribute(typeof(DisplayAttribute));
                var cc = ((DisplayAttribute)sa).Name;
                var value = p.GetValue(a, null);
            }

            //Console.WriteLine("Hello World!");

            //Contact contact = new Contact()
            //{
            //    FirstName = "Damian",
            //    AgeInYears = 23
            //};

            //var damianWriter = new ContactConsoleWriter(contact);
            //damianWriter.Write();

            //Console.ReadLine();
        }
    }
}

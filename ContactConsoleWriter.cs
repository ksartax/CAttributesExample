using System;
using System.Diagnostics;
using System.Reflection;

namespace CAtributesExample
{
    public class ContactConsoleWriter
    {
        private readonly Contact contact;
        public ConsoleColor Color { get; set; }

        public ContactConsoleWriter(Contact contact)
        {
            this.contact = contact;
        }

        public void Write()
        {
            WriteFirstName();
            WriteAge();
        }

        private void WriteAge()
        {
            Console.WriteLine(contact.FirstName);
        }

        private void WriteFirstName()
        {
            PropertyInfo firstNamePropertyInfo = typeof(Contact).GetProperty(nameof(Contact.FirstName));
            DisplayAttribute displayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(firstNamePropertyInfo, typeof(DisplayAttribute));

            var color = displayAttribute.Color;


            OutputDebugInfo();
            Console.WriteLine(contact.AgeInYears);
        }

        [Conditional("DEBUG")]
        private void OutputDebugInfo()
        {
            Console.WriteLine("GEBUG");
        }
    }
}

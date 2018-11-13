using System.Diagnostics;

namespace CAtributesExample
{
    [DebuggerDisplay("First Name = {FirstName} and Age = {AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    public class Contact
    {
        [Display("Test", System.ConsoleColor.Black)]
        public string FirstName { get; set; }
        public int AgeInYears { get; set; }
    }
}
        
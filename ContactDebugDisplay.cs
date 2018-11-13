namespace CAtributesExample
{
    internal class ContactDebugDisplay
    {
        private readonly Contact contact;

        public ContactDebugDisplay(Contact contact)
        {
            this.contact = contact;
        }

        public string UpperName => contact.FirstName.ToUpperInvariant();
        public int AgeIncrement => contact.AgeInYears + 1;
    }
}
using System;

namespace CAtributesExample
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayAttribute : Attribute
    {
        public string Label { get; }
        public ConsoleColor Color { get; }

        public DisplayAttribute(string label, ConsoleColor color)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Color = color;
        }
    }
}

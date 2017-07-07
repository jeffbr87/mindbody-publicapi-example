using System;

namespace PublicApiApp.Models
{
    public class SimpleClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int AvailableSlots { get; set; }

        public override string ToString() => $"{Name} - {StartDateTime} to {EndDateTime}";
    }
}

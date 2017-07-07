using PublicApiApp.ClassService;
using PublicApiApp.Models;

namespace PublicApiApp.Mappers
{
    public class ClassMapper
    {
        public static SimpleClass Map(Class src)
        {
            return new SimpleClass
            {
                Id = src.ID.GetValueOrDefault(),
                Name = src.ClassDescription.Name,
                StartDateTime = src.StartDateTime.GetValueOrDefault(),
                EndDateTime = src.EndDateTime.GetValueOrDefault(),
                AvailableSlots = src.MaxCapacity.GetValueOrDefault() - src.TotalBooked.GetValueOrDefault()
            };

        }
    }
}

using PublicApiApp.ClientService;
using PublicApiApp.Models;

namespace PublicApiApp.Mappers
{
    public class VisitMapper
    {
        public static SimpleVisit Map(Visit src)
        {
            return new SimpleVisit
            {
                Id = src.ID,
                ClassId = src.ClassID,
                Name = src.Name,
                Date = src.StartDateTime.Date.ToShortDateString(),
                Day = src.StartDateTime.DayOfWeek.ToString(),
                Start = src.StartDateTime.ToShortTimeString(),
                End = src.EndDateTime.ToShortTimeString(),
                SignedIn = src.SignedIn,
                Location = src.Location?.Name,
                Staff = src.Staff?.Name,
                Service = src.Service?.Name
            };

        }
    }
}

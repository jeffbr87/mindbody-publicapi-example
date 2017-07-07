namespace PublicApiApp.Models
{
    public class SimpleVisit
    {
        public long Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public bool? SignedIn { get; set; }
        public string Location { get; set; }
        public string Staff { get; set; }
        public string Service { get; set; }
    }
}

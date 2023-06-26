namespace WebApplication9.Models
{
    public class Desk
    {
        public int DeskID { get; set; }
        public string DeskName { get; set; }
        public string Location { get; set; }
        public bool AvailabilityStatus { get; set; }

        // Navigation property
        public ICollection<Booking> Bookings { get; set; }
    }
}

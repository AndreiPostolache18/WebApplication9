namespace WebApplication9.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime BookingStartTime { get; set; }
        public DateTime BookingEndTime { get; set; }

        // Foreign key
        public int UserID { get; set; }
        public int DeskID { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Desk Desk { get; set; }
    }
}

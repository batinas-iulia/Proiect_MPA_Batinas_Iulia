namespace Proiect_MPA_Batinas_Iulia.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }

        public int Price { get; set; }
        
        public MovieSchedule MovieSchedules { get; set; }
        public Client Clients { get; set; }
    }
}

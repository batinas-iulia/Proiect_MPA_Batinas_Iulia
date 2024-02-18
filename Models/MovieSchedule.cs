namespace Proiect_MPA_Batinas_Iulia.Models
{
    public class MovieSchedule
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public ICollection <Ticket> Tickets { get; set; }

        public Movie Movie { get; set; }
        public Auditorium Auditorium { get; set; }  
    }
}

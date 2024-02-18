namespace Proiect_MPA_Batinas_Iulia.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}

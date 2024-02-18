namespace Proiect_MPA_Batinas_Iulia.Models
{
    public class Auditorium
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<MovieSchedule> MovieSchedules { get; set; }
    }
}

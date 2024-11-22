namespace BECapstoneIronAssist.Models
{
    public class Jobsite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Report> Reports { get; set; } = new List<Report>();
        public List<Equipment> Equipment { get; set; }

    }
}

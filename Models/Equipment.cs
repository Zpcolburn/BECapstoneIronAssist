namespace BECapstoneIronAssist.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int JobsiteId { get; set; }
        public Jobsite Jobsite { get; set; }
        public List<User> Users { get; set; }

    }
}

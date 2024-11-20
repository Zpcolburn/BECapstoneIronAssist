namespace BECapstoneIronAssist.Models
{
    public class Jobsite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public int ReportId { get; set; }
        public Report Report { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

    }
}

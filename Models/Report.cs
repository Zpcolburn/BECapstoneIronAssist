namespace BECapstoneIronAssist.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int ReportDate { get; set; }
        public string Description { get; set; }
        public bool ISPublic { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Assign { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int JobsiteId { get; set; }
        public Jobsite Jobsite { get; set; }
    }
}

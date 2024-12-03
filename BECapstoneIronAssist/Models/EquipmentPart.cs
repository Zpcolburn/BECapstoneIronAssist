namespace BECapstoneIronAssist.Models
{
    public class EquipmentPart
    {
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int PartId { get; set; }
        public Part Parts { get; set; }

        public int QuantityUsed { get; set; }
        public DateTime? MaintenanceDate { get; set; }
    }
}

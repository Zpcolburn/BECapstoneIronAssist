namespace BECapstoneIronAssist.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }

        public List<EquipmentPart> EquipmentParts { get; set; }
    }
}

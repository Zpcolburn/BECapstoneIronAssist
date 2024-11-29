using BECapstoneIronAssist.Models;


namespace BECapstoneIronAssist.Data
{
    public class PartData
    {
        public static List<Part> Parts = new()
        {
            new Part
            {
                Id = 1,
                Name = "Hydraulic Pump",
                Description = "A hydraulic pump that provides hydraulic fluid for the operation of machinery.",
                PartNumber = "HP-1001",
                Price = 1289,
                Location = "Aisle 1, Shelf 1" 
            },
            new Part
            {
                Id = 2,
                Name = "Engine Oil Filter",
                Description = "A filter that removes impurities from engine oil, ensuring smooth engine performance.",
                PartNumber = "EOF-2002",
                Price = 53,
                Location = "Aisle 2, Shelf 3"
            },
            new Part
            {
                Id = 3,
                Name = "Tracks",
                Description = "Tracks for heavy equipment with superior durability and wear resistance.",
                PartNumber = "TS-3003",
                Price = 10000,
                Location = "Aisle 3, Shelf 2"
            },
            new Part
            {
                Id = 4,
                Name = "Fuel Injector",
                Description = "High-performance fuel injector that ensures proper fuel distribution in engines.",
                PartNumber = "FI-4004",
                Price = 110,
                Location = "Aisle 4, Shelf 5"
            },
            new Part
            {
                Id = 5,
                Name = "Hydraulic Cylinder",
                Description = "A hydraulic cylinder that provides linear motion through hydraulic pressure.",
                PartNumber = "HC-5005",
                Price = 3000,
                Location = "Aisle 1, Shelf 4" 
            }
        };
    }
}

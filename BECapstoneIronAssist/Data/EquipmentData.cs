using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Data
{
    public class EquipmentData
    {
        public static List<Equipment> Equipment = new()
        {
            new Equipment
            {
                Id = 1,
                Make = "Cat",
                Model = "140 AWD",
                Type = "Motor Grader",
                Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20191003-252bf-484fe?$cc-g$&fmt=pjpeg",
                JobsiteId = 1, // Nashville Zoo
                Description = "The Cat 140 Motor Grader gives you more precise grading in a comfortable cab. With a range of technology options, you can improve grading accuracy and save on materials. With extended maintenance intervals, the 140 Motor Grader sets the pace for low operating costs, while maintaining productivity and efficiency."
            },
            new Equipment
            {
                Id = 2,
                Make = "Cat",
                Model = "D5",
                Type = "Dozer",
                Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20181218-38347-48970?$cc-g$&fmt=pjpeg",
                JobsiteId = 2, // Readyville Fire Station
                Description = "The Cat D5 succeeds the renowned D6N with superior performance, a fully automatic transmission and the broadest choice of technology features to help you get the most from your dozer. Nimble and responsive, it has power for dozing and finesse for grading."
            },
            new Equipment
            {
                Id = 3,
                Make = "410",
                Model = "John Deere",
                Type = "Backhoe",
                Image = "https://www.deere.com/assets/images/common/products/backhoes/410-p-tier/410p_backhoe_r4x001871_large_0761ae4bc0243aa4f8eb1ceaeb32dd202388291a.jpg",
                JobsiteId = 3,
                Description = "Why run two machines when one will do? Whether you're loading trucks, busting up blacktop, placing pipe, digging trenches, or moving materials, John Deere Backhoe Loaders are more than up to your toughest tasks. Designed with real-world customer input to provide the outstanding loader performance, backhoe trenching capability, and multifunction versatility you need with none of the extras you don't, these machines can help you get more done, get on to the next job, and look ahead to the big things in store for your operation."
            },
            new Equipment
            {
                Id = 4,
                Make = "Cat",
                Model = "306 CR",
                Type = "Excavator",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9F3f1oHybwJ1Yb3WvNVk9bs8Rrljf-LI-4g&s",
                JobsiteId = 4,
                Description = "The Cat® 306 CR Mini Excavator delivers maximum power and performance in a mini size to help you work in a wide range of applications."
            },
            new Equipment
            {
                Id = 5,
                Make = "Cat",
                Model = "336",
                Type = "Excavator",
                Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20180212-41328-33143?wid=750&hei=600&op_sharpen=1&qlt=100",
                JobsiteId = 1,
                Description = "The Cat® 336 is a high-productivity, low-owning-and-operating cost excavator that will generate more prosperity for you and your business."
            },
            new Equipment
            {
                Id = 6,
                Make = "Kubota",
                Model = "SVL97-2",
                Type = "Track Loader",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDMvAEl0NHmUmZ2jHJudSeXq0b7dtCOhsNXA&s",
                JobsiteId = 4,
                Description = "Be the solution you’re searching for as you power through obstacles in your path and adapt to the conditions at hand in the Kubota SVL97-2. Rugged terrain? No problem. The SVL97-2 and its 96.4 horsepower are ready to move ground and make sure you’re working in comfort and in confidence. Factor in its dominant tipping load, breakout force and advanced hydraulic system and we think you and the SVL97-2 are going to get along nicely. A workhorse, a go-getter, a friend-- the Kubota SVL97-2."
            },
            new Equipment
            {
                Id = 7,
                Make = "Cat",
                Model = "CP11",
                Type = "Vibratory Soil Compactor",
                Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20210105-a8564-f105e",
                JobsiteId = 3,
                Description = "The Cat® CP11 Vibratory Soil Compactor features a padfoot drum and is ideally suited for cohesive and semi-cohesive soil applications. A reliable propel system improves performance and efficiency and compaction technology solutions help you reach target density faster."
            },
            new Equipment
            {
                Id = 8,
                Make = "Cat",
                Model = "740 EJ",
                Type = "Articulated Truck",
                Image = "https://www.pon-cat.com/application/files/4115/3552/9792/CM20180618-58323-47147.jpg",
                JobsiteId = 2,
                Description = "The Cat® 740 EJ features a world-class cab design, re-engineered using global operator feedback to advance comfort and ease of operation. Enhancements include new controls, transmission-protection features, hoist-assist system, advanced automatic traction control system, stability-assist machine rollover warning system, and a fuel saving ECO mode."
            }
        };
    }
}

using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Data
{
    public class JobsiteData
    {
        public static List<Jobsite> Jobsites = new()
        {
            new Jobsite
            {
                Id = 001,
                Name = "Nashville Zoo",
                Location = "Nashville, TN",
                Image = "https://media.bizj.us/view/img/12716500/parking-garage-2024-jim-bartoo38-copy*900xx5472-3078-0-285.jpg",
                UserId = 01,
                ReportId = 0001,
                EquipmentId = 1
            },
            new Jobsite
            {
                Id = 002,
                Name = "Readyville Fire Station",
                Location = "Readyville, TN",
                Image = "https://amconst-v1671219631.websitepro-cdn.com/wp-content/uploads/2022/06/Readyville-drone-images-5-scaled-e1697459492957-480x480.jpg",
                UserId = 01,
                ReportId = 0002,
                EquipmentId = 2
            },
            new Jobsite
            {
                Id = 003,
                Name = "Opry Mills Hotel",
                Location = "Nashville, TN",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6sJ2e1aN0fX7VM3luuMBqGtcZjxiojP99Tg&s",
                UserId = 01,
                ReportId = 0003,
                EquipmentId = 3
            },
            new Jobsite
            {
                Id = 004,
                Name = "TSU Farm",
                Location = "Nashville, TN",
                Image = "https://davidson.tennessee.edu/wp-content/uploads/sites/193/2020/01/Agriculture-block-image-aspect-ratio-300x360-aspect-ratio-300x360-1.jpg",
                UserId = 02,
                ReportId = 0004,
                EquipmentId = 4
            }
        };
    }
}

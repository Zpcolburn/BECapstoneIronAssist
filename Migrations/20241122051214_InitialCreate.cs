using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BECapstoneIronAssist.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobsites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobsites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobsites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Make = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    JobsiteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Jobsites_JobsiteId",
                        column: x => x.JobsiteId,
                        principalTable: "Jobsites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentUser",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentUser", x => new { x.EquipmentId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_EquipmentUser_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReportDate = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Assign = table.Column<bool>(type: "boolean", nullable: false),
                    EquipmentId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    JobsiteId = table.Column<int>(type: "integer", nullable: false),
                    JobsiteId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Jobsites_JobsiteId",
                        column: x => x.JobsiteId,
                        principalTable: "Jobsites",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Jobsites_JobsiteId1",
                        column: x => x.JobsiteId1,
                        principalTable: "Jobsites",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Role", "Uid" },
                values: new object[,]
                {
                    { 1, "colburn.zach7@gmail.com", "Zach", "Colburn", "Operator", "C0wunKp1sIQRM9YR48JnQPlNXt92" },
                    { 2, "jane.smith@example.com", "Jane", "Smith", "Mechanic", "D1zpqWr2bJUPO7YP39LkWPqMYu64" }
                });

            migrationBuilder.InsertData(
                table: "Jobsites",
                columns: new[] { "Id", "Image", "Location", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "https://media.bizj.us/view/img/12716500/parking-garage-2024-jim-bartoo38-copy*900xx5472-3078-0-285.jpg", "Nashville, TN", "Nashville Zoo", 1 },
                    { 2, "https://amconst-v1671219631.websitepro-cdn.com/wp-content/uploads/2022/06/Readyville-drone-images-5-scaled-e1697459492957-480x480.jpg", "Readyville, TN", "Readyville Fire Station", 1 },
                    { 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6sJ2e1aN0fX7VM3luuMBqGtcZjxiojP99Tg&s", "Nashville, TN", "Opry Mills Hotel", 1 },
                    { 4, "https://davidson.tennessee.edu/wp-content/uploads/sites/193/2020/01/Agriculture-block-image-aspect-ratio-300x360-aspect-ratio-300x360-1.jpg", "Nashville, TN", "TSU Farm", 2 }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Description", "Image", "JobsiteId", "Make", "Model", "Type" },
                values: new object[,]
                {
                    { 1, "The Cat 140 Motor Grader gives you more precise grading in a comfortable cab. With a range of technology options, you can improve grading accuracy and save on materials. With extended maintenance intervals, the 140 Motor Grader sets the pace for low operating costs, while maintaining productivity and efficiency.", "https://s7d2.scene7.com/is/image/Caterpillar/CM20191003-252bf-484fe?$cc-g$&fmt=pjpeg", 1, "Cat", "140 AWD", "Motor Grader" },
                    { 2, "The Cat D5 succeeds the renowned D6N with superior performance, a fully automatic transmission and the broadest choice of technology features to help you get the most from your dozer. Nimble and responsive, it has power for dozing and finesse for grading.", "https://s7d2.scene7.com/is/image/Caterpillar/CM20181218-38347-48970?$cc-g$&fmt=pjpeg", 2, "Cat", "D5", "Dozer" },
                    { 3, "Why run two machines when one will do? Whether you're loading trucks, busting up blacktop, placing pipe, digging trenches, or moving materials, John Deere Backhoe Loaders are more than up to your toughest tasks. Designed with real-world customer input to provide the outstanding loader performance, backhoe trenching capability, and multifunction versatility you need with none of the extras you don't, these machines can help you get more done, get on to the next job, and look ahead to the big things in store for your operation.", "https://www.deere.com/assets/images/common/products/backhoes/410-p-tier/410p_backhoe_r4x001871_large_0761ae4bc0243aa4f8eb1ceaeb32dd202388291a.jpg", 3, "410", "John Deere", "Backhoe" },
                    { 4, "The Cat® 306 CR Mini Excavator delivers maximum power and performance in a mini size to help you work in a wide range of applications.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9F3f1oHybwJ1Yb3WvNVk9bs8Rrljf-LI-4g&s", 4, "Cat", "306 CR", "Excavator" },
                    { 5, "The Cat® 336 is a high-productivity, low-owning-and-operating cost excavator that will generate more prosperity for you and your business.", "https://s7d2.scene7.com/is/image/Caterpillar/CM20180212-41328-33143?wid=750&hei=600&op_sharpen=1&qlt=100", 1, "Cat", "336", "Excavator" },
                    { 6, "Be the solution you’re searching for as you power through obstacles in your path and adapt to the conditions at hand in the Kubota SVL97-2. Rugged terrain? No problem. The SVL97-2 and its 96.4 horsepower are ready to move ground and make sure you’re working in comfort and in confidence. Factor in its dominant tipping load, breakout force and advanced hydraulic system and we think you and the SVL97-2 are going to get along nicely. A workhorse, a go-getter, a friend-- the Kubota SVL97-2.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDMvAEl0NHmUmZ2jHJudSeXq0b7dtCOhsNXA&s", 4, "Kubota", "SVL97-2", "Track Loader" },
                    { 7, "The Cat® CP11 Vibratory Soil Compactor features a padfoot drum and is ideally suited for cohesive and semi-cohesive soil applications. A reliable propel system improves performance and efficiency and compaction technology solutions help you reach target density faster.", "https://s7d2.scene7.com/is/image/Caterpillar/CM20210105-a8564-f105e", 3, "Cat", "CP11", "Vibratory Soil Compactor" },
                    { 8, "The Cat® 740 EJ features a world-class cab design, re-engineered using global operator feedback to advance comfort and ease of operation. Enhancements include new controls, transmission-protection features, hoist-assist system, advanced automatic traction control system, stability-assist machine rollover warning system, and a fuel saving ECO mode.", "https://www.pon-cat.com/application/files/4115/3552/9792/CM20180618-58323-47147.jpg", 2, "Cat", "740 EJ", "Articulated Truck" }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Assign", "Description", "EquipmentId", "Image", "IsPublic", "JobsiteId", "JobsiteId1", "Priority", "ReportDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, false, "The cutting edges on the blade need to be flipped, and the ripper teeth need to be replaced.", 1, "https://test.com", true, 2, null, "Low", 2009, "Backlog", 1 },
                    { 2, false, "Thrown right track, needs to be put back on.", 2, "https://test.com", true, 2, null, "High", 1998, "Backlog", 1 },
                    { 3, true, "Front bucket cylinder shaft bent.", 3, "https://test.com", true, 3, null, "High", 1997, "Closed", 2 },
                    { 4, true, "Front glass broken, looks like from a rock.", 4, "https://test.com", true, 4, null, "low", 1989, "Closed", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_JobsiteId",
                table: "Equipment",
                column: "JobsiteId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUser_UsersId",
                table: "EquipmentUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobsites_UserId",
                table: "Jobsites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_EquipmentId",
                table: "Reports",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_JobsiteId",
                table: "Reports",
                column: "JobsiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_JobsiteId1",
                table: "Reports",
                column: "JobsiteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentUser");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Jobsites");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

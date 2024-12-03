using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BECapstoneIronAssist.Migrations
{
    public partial class AddPartsEquipmentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Jobsites_JobsiteId1",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "EquipmentUser");

            migrationBuilder.DropIndex(
                name: "IX_Reports_JobsiteId1",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "JobsiteId1",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Equipment",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PartNumber = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentParts",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "integer", nullable: false),
                    PartId = table.Column<int>(type: "integer", nullable: false),
                    QuantityUsed = table.Column<int>(type: "integer", nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentParts", x => new { x.PartId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_EquipmentParts_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentParts_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "Description", "Location", "Name", "PartNumber", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "A hydraulic pump that provides hydraulic fluid for the operation of machinery.", "Aisle 1, Shelf 1", "Hydraulic Pump", "HP-1001", 1289, 0 },
                    { 2, "A filter that removes impurities from engine oil, ensuring smooth engine performance.", "Aisle 2, Shelf 3", "Engine Oil Filter", "EOF-2002", 53, 0 },
                    { 3, "Tracks for heavy equipment with superior durability and wear resistance.", "Aisle 3, Shelf 2", "Tracks", "TS-3003", 10000, 0 },
                    { 4, "High-performance fuel injector that ensures proper fuel distribution in engines.", "Aisle 4, Shelf 5", "Fuel Injector", "FI-4004", 110, 0 },
                    { 5, "A hydraulic cylinder that provides linear motion through hydraulic pressure.", "Aisle 1, Shelf 4", "Hydraulic Cylinder", "HC-5005", 3000, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_EquipmentId",
                table: "Users",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UserId",
                table: "Equipment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentParts_EquipmentId",
                table: "EquipmentParts",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Users_UserId",
                table: "Equipment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Equipment_EquipmentId",
                table: "Users",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Users_UserId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Equipment_EquipmentId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "EquipmentParts");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Users_EquipmentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_UserId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "JobsiteId1",
                table: "Reports",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Reports_JobsiteId1",
                table: "Reports",
                column: "JobsiteId1");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUser_UsersId",
                table: "EquipmentUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Jobsites_JobsiteId1",
                table: "Reports",
                column: "JobsiteId1",
                principalTable: "Jobsites",
                principalColumn: "Id");
        }
    }
}

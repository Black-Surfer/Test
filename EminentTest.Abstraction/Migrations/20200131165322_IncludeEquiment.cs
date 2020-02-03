using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EminentTest.Abstraction.Migrations
{
    public partial class IncludeEquiment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("03cb976d-002e-4adc-8f66-28484f5480fe"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("436b35d2-3eb8-4ba3-a98e-4a62d57480d6"));

            migrationBuilder.AddColumn<int>(
                name: "LookupValue",
                table: "Lookups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusName = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    TypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "LookupDescription", "LookupName", "LookupType", "LookupValue" },
                values: new object[,]
                {
                    { new Guid("6621072c-5025-426e-9925-103f7ec23878"), "Male", "Gender", "Gender", 1 },
                    { new Guid("d745ab15-3c96-4753-8502-c9dcbc8a6e12"), "Female", "Gender", "Gender", 0 },
                    { new Guid("add0d0ed-ad4e-4370-a909-0e8e463b7627"), "Active", "StatusName", "Status", 10 },
                    { new Guid("645b8841-a741-4e6f-8f6c-a83e9cc07531"), "Inactive", "StatusName", "Status", 20 },
                    { new Guid("9e866bf0-7617-493b-9fdc-d518aab468be"), "Indoor", "EquipmentTypeName", "EquipmentType", 30 },
                    { new Guid("25418a27-5c46-43e5-9066-b81b76b56209"), "Outdoor", "EquipmentTypeName", "EquipmentType", 60 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("25418a27-5c46-43e5-9066-b81b76b56209"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("645b8841-a741-4e6f-8f6c-a83e9cc07531"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("6621072c-5025-426e-9925-103f7ec23878"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("9e866bf0-7617-493b-9fdc-d518aab468be"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("add0d0ed-ad4e-4370-a909-0e8e463b7627"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("d745ab15-3c96-4753-8502-c9dcbc8a6e12"));

            migrationBuilder.DropColumn(
                name: "LookupValue",
                table: "Lookups");

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "LookupDescription", "LookupName", "LookupType" },
                values: new object[] { new Guid("436b35d2-3eb8-4ba3-a98e-4a62d57480d6"), "Male", "Gender", "Gender" });

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "LookupDescription", "LookupName", "LookupType" },
                values: new object[] { new Guid("03cb976d-002e-4adc-8f66-28484f5480fe"), "Female", "Gender", "Gender" });
        }
    }
}

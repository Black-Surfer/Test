using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EminentTest.Abstraction.Migrations
{
    public partial class SeedLookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "LookupDescription", "LookupName", "LookupType" },
                values: new object[] { new Guid("436b35d2-3eb8-4ba3-a98e-4a62d57480d6"), "Male", "Gender", "Gender" });

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "LookupDescription", "LookupName", "LookupType" },
                values: new object[] { new Guid("03cb976d-002e-4adc-8f66-28484f5480fe"), "Female", "Gender", "Gender" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("03cb976d-002e-4adc-8f66-28484f5480fe"));

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: new Guid("436b35d2-3eb8-4ba3-a98e-4a62d57480d6"));
        }
    }
}

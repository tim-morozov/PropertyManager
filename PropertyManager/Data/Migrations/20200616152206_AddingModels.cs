using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Data.Migrations
{
    public partial class AddingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29fe96c4-4ee2-4095-8f02-d19227a5c35e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd6f428-b5c0-4d34-8cdd-25715626a05b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41d9a836-e22c-4224-85ba-7d34f3c8f780");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b932a433-2ee5-49c0-bbe2-332b71057776");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0407d75d-2805-47dd-a217-d341337e1b2b", "8bde36eb-95f4-4f4a-81ec-a0a9fcefe8ba", "Admin", "ADMIN" },
                    { "b1791bc1-bef0-4180-9f48-7287fe7a4f7d", "8df02d68-5467-485c-9acd-e11bd34f6283", "Tenant", "TENANT" },
                    { "b7252b42-87e0-4b5d-9a9b-a9ad72e344ee", "f70b9150-3200-494f-ad64-7292daf04108", "Contractor", "CONTRACTOR" },
                    { "b8133371-93f5-4037-a751-558be6e24d49", "d503f0e4-907c-4bc0-8a0e-7b9042f9cedb", "Analyst", "ANALYST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0407d75d-2805-47dd-a217-d341337e1b2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1791bc1-bef0-4180-9f48-7287fe7a4f7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7252b42-87e0-4b5d-9a9b-a9ad72e344ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8133371-93f5-4037-a751-558be6e24d49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41d9a836-e22c-4224-85ba-7d34f3c8f780", "d6f20502-7955-4c77-8613-c453a654e581", "Admin", "ADMIN" },
                    { "3dd6f428-b5c0-4d34-8cdd-25715626a05b", "2954f519-ad8b-4348-9336-a3ea7a22ba60", "Tenant", "TENANT" },
                    { "b932a433-2ee5-49c0-bbe2-332b71057776", "a40f22d4-eef4-4b29-a330-e6d394651398", "Contractor", "CONTRACTOR" },
                    { "29fe96c4-4ee2-4095-8f02-d19227a5c35e", "0da1b857-fc2c-4627-ae62-9c87c19dd1ac", "Analyst", "ANALYST" }
                });
        }
    }
}

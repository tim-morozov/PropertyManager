using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Migrations
{
    public partial class AddingLatLngToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bdd11bf-3263-4af4-ab22-a17f12ef1de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b8500a0-466a-4755-aa0b-46cc1a0d4342");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef0b350-66a3-4ca0-a5f5-23543270da4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd16c1a-76b6-4dbf-945a-13ef814c9653");

            migrationBuilder.AddColumn<double>(
                name: "lat",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "lng",
                table: "Properties",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b4adfc3-fe81-4764-8ed2-d5f19652b8fc", "70be146c-6602-49de-a486-d387316deedd", "Admin", "ADMIN" },
                    { "9494fc6b-716a-4eb0-a876-6e2b00836c80", "9baa0f8e-e095-4510-99f6-3a7434853910", "Tenant", "TENANT" },
                    { "4674420d-644f-477e-a432-d8c4786e1778", "54a244a2-907c-40ff-a03d-fb52defc5ebc", "Contractor", "CONTRACTOR" },
                    { "11bbea75-c3db-46ad-ae85-f7c029160691", "78ed1a67-537a-4ac4-93e3-669e2e1a953b", "Analyst", "ANALYST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11bbea75-c3db-46ad-ae85-f7c029160691");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4674420d-644f-477e-a432-d8c4786e1778");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b4adfc3-fe81-4764-8ed2-d5f19652b8fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9494fc6b-716a-4eb0-a876-6e2b00836c80");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "lng",
                table: "Properties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bdd11bf-3263-4af4-ab22-a17f12ef1de7", "0855552a-f5a6-4b0b-b470-368c33e5f680", "Admin", "ADMIN" },
                    { "4b8500a0-466a-4755-aa0b-46cc1a0d4342", "59737f24-534d-4116-b37d-950484a0f2b5", "Tenant", "TENANT" },
                    { "ffd16c1a-76b6-4dbf-945a-13ef814c9653", "5353c549-3dd4-489e-af7f-d2b7cb3731c4", "Contractor", "CONTRACTOR" },
                    { "8ef0b350-66a3-4ca0-a5f5-23543270da4a", "6fcb8f71-de8d-4ab1-9bf8-60a436c9f2b9", "Analyst", "ANALYST" }
                });
        }
    }
}

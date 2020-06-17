using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Data.Migrations
{
    public partial class RemovingZipCodeFromTenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47d0ddde-a246-4567-98e6-ea8476146230");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "744dc3cd-58e8-408a-9301-9df065396d67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d5ba37f-3b2e-4a36-b361-19a3a700adc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118ff76-2fa0-4a61-94bc-e70aebc6679d");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Tenants");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ecaa67c3-1c8a-48a6-ac8a-675d875524bf", "b71c78de-85f6-4945-8743-97a483299547", "Admin", "ADMIN" },
                    { "c4adb21d-bd28-4670-a7b2-2e99cd1b7ea6", "5cb3a992-8861-4a22-8cb8-c6875c3b278d", "Tenant", "TENANT" },
                    { "19a207fc-d9ce-419a-9958-7867b47a5877", "65f33b85-7b23-471b-9ae9-e9abed0cbbd4", "Contractor", "CONTRACTOR" },
                    { "04d68faa-bb1c-4469-b977-52f8ada8bee8", "5fdda0e0-4832-40eb-9396-e3dd4253c4a5", "Analyst", "ANALYST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d68faa-bb1c-4469-b977-52f8ada8bee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19a207fc-d9ce-419a-9958-7867b47a5877");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4adb21d-bd28-4670-a7b2-2e99cd1b7ea6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecaa67c3-1c8a-48a6-ac8a-675d875524bf");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c118ff76-2fa0-4a61-94bc-e70aebc6679d", "16b4c7a2-a103-42ee-989b-4fb197766f81", "Admin", "ADMIN" },
                    { "7d5ba37f-3b2e-4a36-b361-19a3a700adc2", "504722b1-ec3b-4c10-9e70-61dcc586a6f1", "Tenant", "TENANT" },
                    { "47d0ddde-a246-4567-98e6-ea8476146230", "0fa5045f-32c1-419d-beef-133274555b4a", "Contractor", "CONTRACTOR" },
                    { "744dc3cd-58e8-408a-9301-9df065396d67", "89a66dd5-ed35-4b39-876b-b33a401e66af", "Analyst", "ANALYST" }
                });
        }
    }
}

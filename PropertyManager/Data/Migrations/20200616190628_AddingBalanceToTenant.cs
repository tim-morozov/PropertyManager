using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Data.Migrations
{
    public partial class AddingBalanceToTenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b5039b-3118-41f2-a828-bc3c81815b8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52b4f31-9cba-47e5-bec5-23dc81a2fdd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2b6c75-f9fa-4288-8d4e-dc76abc20ef6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f169cb14-bb19-4392-a364-414cc040f1b0");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Tenants",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Balance",
                table: "Tenants");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f169cb14-bb19-4392-a364-414cc040f1b0", "a893d3f3-270a-45f6-a23e-fadabeb16318", "Admin", "ADMIN" },
                    { "a52b4f31-9cba-47e5-bec5-23dc81a2fdd2", "9f4b54ed-d51e-4f0d-8854-efd7765c1313", "Tenant", "TENANT" },
                    { "00b5039b-3118-41f2-a828-bc3c81815b8d", "97e34ee6-21ff-447c-844d-097b96f40de9", "Contractor", "CONTRACTOR" },
                    { "cd2b6c75-f9fa-4288-8d4e-dc76abc20ef6", "512d8bef-f294-4804-b9cc-e88bc799fdf0", "Analyst", "ANALYST" }
                });
        }
    }
}

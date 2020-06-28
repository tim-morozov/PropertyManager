using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Migrations
{
    public partial class AddingReccomendationsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fab4d6-7a5c-4b02-afa4-150df43ee7f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6d314b-68fd-41fb-9905-5e00e5613132");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a87e0f88-c9d8-453d-8fb6-197102c4bbbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd3ee2ed-d682-4fb4-906c-3ea786870060");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72fe8e8b-856b-4f35-9b44-be1134fc5e09", "6534e36b-94ed-4fae-b6d4-c83593559c81", "Admin", "ADMIN" },
                    { "84a201d6-e87e-46d6-80ed-90077e993a37", "27117b77-eae0-468b-ad57-10a38d1a9fc0", "Tenant", "TENANT" },
                    { "fc04e71f-2293-4b4e-a827-2d1b1938f829", "db6f368d-8d5b-44d9-8619-8b24bee8e253", "Contractor", "CONTRACTOR" },
                    { "4ca8848c-5957-4eed-9102-a616101cba67", "79869f99-7739-4ba6-8b41-36c55832423b", "Analyst", "ANALYST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca8848c-5957-4eed-9102-a616101cba67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72fe8e8b-856b-4f35-9b44-be1134fc5e09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a201d6-e87e-46d6-80ed-90077e993a37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc04e71f-2293-4b4e-a827-2d1b1938f829");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b6d314b-68fd-41fb-9905-5e00e5613132", "2fa46244-d362-4427-b6cd-507a9c6891ba", "Admin", "ADMIN" },
                    { "a87e0f88-c9d8-453d-8fb6-197102c4bbbd", "a9e18a7d-b147-4bb5-921d-feb1ac942464", "Tenant", "TENANT" },
                    { "bd3ee2ed-d682-4fb4-906c-3ea786870060", "36be5631-75b0-48ed-a42c-2c763fe07047", "Contractor", "CONTRACTOR" },
                    { "42fab4d6-7a5c-4b02-afa4-150df43ee7f9", "d94ceab5-ad91-49f3-af60-33a93b5652ab", "Analyst", "ANALYST" }
                });
        }
    }
}

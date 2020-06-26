using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Migrations
{
    public partial class AddingWorkOrderCountToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ff54100-dd35-4ef1-8fcd-217e8ba1ee9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99f2f17a-c6c9-45d3-acfd-8004f9554b52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7df7441-8c63-4010-b8d2-76afc5e8f692");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7dc3ed1-6c8f-460f-8bfe-d6fd604ecb03");

            migrationBuilder.AddColumn<int>(
                name: "WorkOrderCount",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Analysts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Analysts",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "WorkOrderCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Analysts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Analysts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7df7441-8c63-4010-b8d2-76afc5e8f692", "d957a24a-a7ce-4700-a855-f33c85a56a83", "Admin", "ADMIN" },
                    { "d7dc3ed1-6c8f-460f-8bfe-d6fd604ecb03", "cf1e0ff6-70a3-4633-a3bf-2f7efad8f468", "Tenant", "TENANT" },
                    { "4ff54100-dd35-4ef1-8fcd-217e8ba1ee9b", "2df0b55c-a97d-4830-a5c8-fd278fb685ed", "Contractor", "CONTRACTOR" },
                    { "99f2f17a-c6c9-45d3-acfd-8004f9554b52", "6ca4ed5e-525c-4ce8-a6dc-add35a954163", "Analyst", "ANALYST" }
                });
        }
    }
}

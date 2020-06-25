using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Migrations
{
    public partial class AddingNameAndPhoneNumberToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3037e51c-f20d-42e9-97ce-033f6a8b3f54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45a7d4b2-e87d-40ac-a99a-50cb4d44219f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab80d54d-d1f1-49cf-beb3-566a2c4925a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "babbdf2e-79eb-4d27-b60b-589cd937ffea");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Admins",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Admins",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Admins");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45a7d4b2-e87d-40ac-a99a-50cb4d44219f", "9d981d1c-31d4-4863-a8ff-4d371a4947b6", "Admin", "ADMIN" },
                    { "ab80d54d-d1f1-49cf-beb3-566a2c4925a6", "6508947e-9ecd-4ab2-8ea5-e69210151e03", "Tenant", "TENANT" },
                    { "babbdf2e-79eb-4d27-b60b-589cd937ffea", "e8784849-f02d-45fd-9ec5-25109fb28304", "Contractor", "CONTRACTOR" },
                    { "3037e51c-f20d-42e9-97ce-033f6a8b3f54", "66585feb-0dc5-4ba5-b553-59ae33e987b5", "Analyst", "ANALYST" }
                });
        }
    }
}

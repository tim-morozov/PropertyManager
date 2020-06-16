using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Data.Migrations
{
    public partial class SeedingProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "765353a8-ff21-4c9a-a915-9f0ce44aa285");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80576dbf-48fc-4f77-84e7-191c67d18898");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97ebcc10-7d90-4b9e-bf08-170207ce67a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64309fe-0aa8-4ddd-9dd4-54211aa49376");

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

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "City", "Name", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "2741 N 40th St", "Milwaukee", "House1", "WI", "53210" },
                    { 2, "1531 N 29th St Unit 1533", "Milwaukee", "House2", "WI", "53208" },
                    { 3, "4546 N 70th St", "Milwaukee", "House3", "WI", "53218" },
                    { 4, "1962 S 12th St", "Milwaukee", "House4", "WI", "53204" },
                    { 5, "4183 N 13th St", "Milwaukee", "House5", "WI", "53209" },
                    { 6, "4201 W Hawthorne Trace Rd", "Milwaukee", "River Place", "WI", "53209" },
                    { 7, "441 E Erie St", "Milwaukee", "DoMUS", "WI", "53202" },
                    { 8, "9220 N 75th St", "Milwaukee", "GlenBrook", "WI", "53223" },
                    { 9, "1551 N Water St", "Milwaukee", "North End", "WI", "53202" },
                    { 10, "2634 North Stowell Avenue", "Milwaukee", "Stonewell", "WI", "53211" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "97ebcc10-7d90-4b9e-bf08-170207ce67a5", "6964439f-ca1a-471b-8a07-bd798ff69b61", "Admin", "ADMIN" },
                    { "f64309fe-0aa8-4ddd-9dd4-54211aa49376", "9a50d982-95d3-4e3b-a34b-65126d8c7b1d", "Tenant", "TENANT" },
                    { "80576dbf-48fc-4f77-84e7-191c67d18898", "4d229a0a-0368-4443-b1ac-5f48b20c746e", "Contractor", "CONTRACTOR" },
                    { "765353a8-ff21-4c9a-a915-9f0ce44aa285", "f081d2a2-0929-4f03-b880-0dd3df2b7ddc", "Analyst", "ANALYST" }
                });
        }
    }
}

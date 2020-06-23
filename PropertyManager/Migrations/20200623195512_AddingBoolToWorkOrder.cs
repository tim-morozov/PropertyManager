using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Migrations
{
    public partial class AddingBoolToWorkOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08b658db-c08d-434d-a3c1-8df749b24cbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87d8c008-f0f1-4321-97c7-058c8e8e6d1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3f81862-8544-4681-85ca-72e9811671b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcca3876-5048-4eeb-9cfe-36ddadd4b7ea");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "WorkOrders",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "WorkOrders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08b658db-c08d-434d-a3c1-8df749b24cbc", "465f1345-02a4-4a6e-a7cb-6fa71d87ebc0", "Admin", "ADMIN" },
                    { "dcca3876-5048-4eeb-9cfe-36ddadd4b7ea", "90955d8c-913e-449c-b2ee-1b8fb92ee932", "Tenant", "TENANT" },
                    { "87d8c008-f0f1-4321-97c7-058c8e8e6d1b", "828c8f07-d92a-485c-ab19-70aa5767b2f5", "Contractor", "CONTRACTOR" },
                    { "a3f81862-8544-4681-85ca-72e9811671b5", "03f9677f-5f66-42aa-b21e-96b6389161d3", "Analyst", "ANALYST" }
                });
        }
    }
}

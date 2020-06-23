using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManager.Migrations
{
    public partial class AddingForeignKeyToWorkOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0292fbd2-9732-4514-ab52-0b3fcc6f1deb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272a017-6b0c-467b-b0f5-c77dcdd4657b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5906dc96-4f6c-457f-becc-6d622b51db3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afc8eb51-e03a-4567-856a-eb293abc507b");

            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "WorkOrders",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_ContractorId",
                table: "WorkOrders",
                column: "ContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_Contractors_ContractorId",
                table: "WorkOrders",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_Contractors_ContractorId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_ContractorId",
                table: "WorkOrders");

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

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "WorkOrders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5906dc96-4f6c-457f-becc-6d622b51db3e", "6bd5e071-ad66-47af-b443-d76210680498", "Admin", "ADMIN" },
                    { "0292fbd2-9732-4514-ab52-0b3fcc6f1deb", "ad3b2f56-c647-48dd-b622-0ac586e82fda", "Tenant", "TENANT" },
                    { "2272a017-6b0c-467b-b0f5-c77dcdd4657b", "2952861a-a552-4816-9e8b-54419efeca6e", "Contractor", "CONTRACTOR" },
                    { "afc8eb51-e03a-4567-856a-eb293abc507b", "e9769ccb-c2fe-4341-aa48-80c300ea8ca0", "Analyst", "ANALYST" }
                });
        }
    }
}

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

            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "WorkOrders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e65c8e26-645d-48ec-b55c-275ce4ef97c2", "02afb834-ca48-4917-b10b-f9859c3db3f6", "Admin", "ADMIN" },
                    { "fcf8336a-3d5c-4307-a67e-b5824a34d005", "71d9c3a6-d6ef-48e9-b713-615e85b55660", "Tenant", "TENANT" },
                    { "76e7b3f4-bc5f-4f6f-b4d1-ee6da2a6d082", "5f6dbdee-7e5d-4442-899c-097449d895d7", "Contractor", "CONTRACTOR" },
                    { "830c07df-6c3a-4e97-9f0a-1c685f671769", "8d927f75-b6ca-4804-b8b0-6f68564c9375", "Analyst", "ANALYST" }
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
                keyValue: "76e7b3f4-bc5f-4f6f-b4d1-ee6da2a6d082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "830c07df-6c3a-4e97-9f0a-1c685f671769");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65c8e26-645d-48ec-b55c-275ce4ef97c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf8336a-3d5c-4307-a67e-b5824a34d005");

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "WorkOrders");

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19Alert.Data.Migrations
{
    public partial class AddMedicalHotlineToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dbb5e7a-45d3-40ec-87ea-d77c00e5dbc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d86ca2ce-fa43-421d-b07e-d757c74807b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4ff803d-3bbe-4829-8901-153b9a86f77b", "55427486-f645-45e7-a337-2e14c03866a7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a19ee71e-4cd0-4b23-aa39-df9f94b6f9a7", "b199485a-27f9-4264-84b1-424bb689c4c6", "RegisteredUser", "REGISTEREDNAME" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c388a919-a119-4a87-84b6-152142c26751", "de6dc395-8393-4390-b50f-789f911b499a", "MedicalHotline", "MEDICALHOTLINE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a19ee71e-4cd0-4b23-aa39-df9f94b6f9a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c388a919-a119-4a87-84b6-152142c26751");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4ff803d-3bbe-4829-8901-153b9a86f77b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1dbb5e7a-45d3-40ec-87ea-d77c00e5dbc5", "0db4f303-3c25-46c0-b51d-2751e8c76a23", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d86ca2ce-fa43-421d-b07e-d757c74807b2", "b43363df-7e34-4e98-8c8d-93835dae939e", "RegisteredUser", "REGISTEREDNAME" });
        }
    }
}

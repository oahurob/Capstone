using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19Alert.Migrations
{
    public partial class ChangePhoneNumberInMedicalHotlineToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc7e8cbb-b7ab-4a7d-9073-26f5e8c57751");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0fc8b20-0d3b-43a6-9239-254a061b0a0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e898bd01-6bff-416a-a903-a4948d2d3af4");

            migrationBuilder.AlterColumn<double>(
                name: "PhoneNumber",
                table: "MedicalHotlines",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9dfa0b8-85da-4a12-9b99-fda672926fde", "ebb0c4db-8719-4a6e-ab86-bfc998fdb661", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d46d4fe-8625-410d-8ee1-94cd06f5c4f5", "a1caf9fb-2c74-4e88-a7d6-93e81d967263", "RegisteredUser", "REGISTEREDUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91b33f35-2990-4024-8cec-f6e3f67d6d92", "b9177873-3a7f-478f-a454-a9ab6f7cd874", "MedicalHotline", "MEDICALHOTLINE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91b33f35-2990-4024-8cec-f6e3f67d6d92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d46d4fe-8625-410d-8ee1-94cd06f5c4f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9dfa0b8-85da-4a12-9b99-fda672926fde");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "MedicalHotlines",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0fc8b20-0d3b-43a6-9239-254a061b0a0f", "44f92848-b80c-46cf-8962-2cc4833d2406", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e898bd01-6bff-416a-a903-a4948d2d3af4", "4f43a4d5-6f33-4ca9-a1da-6a38ddc43de0", "RegisteredUser", "REGISTEREDUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc7e8cbb-b7ab-4a7d-9073-26f5e8c57751", "3bf58755-1071-4b0d-bc7b-3a3ea370bdd1", "MedicalHotline", "MEDICALHOTLINE" });
        }
    }
}

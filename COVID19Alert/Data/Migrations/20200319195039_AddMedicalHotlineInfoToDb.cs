using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19Alert.Data.Migrations
{
    public partial class AddMedicalHotlineInfoToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b890faf-659e-43e1-8d99-765a1c71719d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0627c04-6e71-4bdd-86a3-29a616bd732c");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "RegisteredUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MedicalHotlines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorsName = table.Column<string>(nullable: true),
                    NursesName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHotlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalHotlines_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1dbb5e7a-45d3-40ec-87ea-d77c00e5dbc5", "0db4f303-3c25-46c0-b51d-2751e8c76a23", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d86ca2ce-fa43-421d-b07e-d757c74807b2", "b43363df-7e34-4e98-8c8d-93835dae939e", "RegisteredUser", "REGISTEREDNAME" });

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUsers_IdentityUserId",
                table: "RegisteredUsers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHotlines_AddressId",
                table: "MedicalHotlines",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredUsers_AspNetUsers_IdentityUserId",
                table: "RegisteredUsers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredUsers_AspNetUsers_IdentityUserId",
                table: "RegisteredUsers");

            migrationBuilder.DropTable(
                name: "MedicalHotlines");

            migrationBuilder.DropIndex(
                name: "IX_RegisteredUsers_IdentityUserId",
                table: "RegisteredUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dbb5e7a-45d3-40ec-87ea-d77c00e5dbc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d86ca2ce-fa43-421d-b07e-d757c74807b2");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "RegisteredUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b890faf-659e-43e1-8d99-765a1c71719d", "0e63f719-e98f-45ee-b81e-db212d1df6dd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0627c04-6e71-4bdd-86a3-29a616bd732c", "43339284-5ea0-46b9-9820-c0acd1b91501", "RegisteredUser", "REGISTEREDNAME" });
        }
    }
}

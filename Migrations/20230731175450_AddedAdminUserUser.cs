using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookmy.games.api.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdminUserUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsSystemUser", "PasswordHash", "ReferredBy" },
                values: new object[] { 1, "starkbotha@gmail.com", true, "$2a$11$kmefUnMNGPvzATM3n4Q2de5CXml.F3fD3DPa9C3t7s/GkEnlBDD/u", null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "AuthRoleId", "UserId" },
                values: new object[] { 1, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}

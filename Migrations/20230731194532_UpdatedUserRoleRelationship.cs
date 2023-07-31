using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookmy.games.api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserRoleRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "AuthRoleId",
                table: "AuthClaims",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AuthClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuthRoleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$0Aw/.L766AvWwHMN0MN/HeDvxdD/lqa2hTo9MbEBRWLT7sgOl9eVu");

            migrationBuilder.CreateIndex(
                name: "IX_AuthClaims_AuthRoleId",
                table: "AuthClaims",
                column: "AuthRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthClaims_AuthRoles_AuthRoleId",
                table: "AuthClaims",
                column: "AuthRoleId",
                principalTable: "AuthRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_Id",
                table: "UserRoles",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthClaims_AuthRoles_AuthRoleId",
                table: "AuthClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_Id",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AuthClaims_AuthRoleId",
                table: "AuthClaims");

            migrationBuilder.DropColumn(
                name: "AuthRoleId",
                table: "AuthClaims");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserRoles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$kmefUnMNGPvzATM3n4Q2de5CXml.F3fD3DPa9C3t7s/GkEnlBDD/u");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

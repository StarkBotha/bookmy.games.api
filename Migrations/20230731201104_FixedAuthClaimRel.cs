using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookmy.games.api.Migrations
{
    /// <inheritdoc />
    public partial class FixedAuthClaimRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthClaims_AuthRoles_AuthRoleId",
                table: "AuthClaims");

            migrationBuilder.DropIndex(
                name: "IX_AuthClaims_AuthRoleId",
                table: "AuthClaims");

            migrationBuilder.DropColumn(
                name: "AuthRoleId",
                table: "AuthClaims");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$sYQ1ed4P8CG6tkjELmes0OW22mbd0W9R6VfyP/Df0ZqPjXjRKn9i.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "$2a$11$OnkBBly4J1Byhu8bsQb88.xXWdQ4in2pPpeSj98aF3nCXkPGjkOwu");

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
        }
    }
}

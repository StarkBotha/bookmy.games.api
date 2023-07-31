using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookmy.games.api.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ReferredBy",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AuthClaims",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AuthClaims",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Can do anything", "Overlord" });

            migrationBuilder.InsertData(
                table: "AuthRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Administrator" });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "AuthClaimId", "AuthRoleId" },
                values: new object[] { 1, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuthClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuthRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ReferredBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AuthClaims");
        }
    }
}

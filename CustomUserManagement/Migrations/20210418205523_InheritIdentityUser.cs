using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomUserManagement.Migrations
{
    public partial class InheritIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Identity",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Identity",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "Identity",
                table: "User",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsernameChangeLimit",
                schema: "Identity",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Identity",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Identity",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "Identity",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UsernameChangeLimit",
                schema: "Identity",
                table: "User");
        }
    }
}

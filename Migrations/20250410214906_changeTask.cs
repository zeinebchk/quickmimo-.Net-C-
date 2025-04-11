using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace quickmimo.Migrations
{
    /// <inheritdoc />
    public partial class changeTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "servings",
                table: "tasks");

            migrationBuilder.RenameColumn(
                name: "ddeadline",
                table: "tasks",
                newName: "startdate");

            migrationBuilder.AddColumn<DateTime>(
                name: "deadline",
                table: "tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deadline",
                table: "tasks");

            migrationBuilder.RenameColumn(
                name: "startdate",
                table: "tasks",
                newName: "ddeadline");

            migrationBuilder.AddColumn<int>(
                name: "servings",
                table: "tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}

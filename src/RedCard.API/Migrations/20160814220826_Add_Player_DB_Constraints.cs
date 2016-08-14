using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedCard.API.Migrations
{
    public partial class Add_Player_DB_Constraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Team",
                table: "Players",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Players",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "League",
                table: "Players",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Players",
                nullable: false);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Players_Name",
                table: "Players",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Players_Name",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "Team",
                table: "Players",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Players",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "League",
                table: "Players",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Players",
                nullable: true);
        }
    }
}

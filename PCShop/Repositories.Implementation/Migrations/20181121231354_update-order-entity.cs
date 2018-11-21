using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Implementation.Migrations
{
    public partial class updateorderentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationCountry",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedDelivery",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationCountry",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "EstimatedDelivery",
                table: "Orders");
        }
    }
}

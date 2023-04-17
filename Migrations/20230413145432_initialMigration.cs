using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApplication.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VinNo = table.Column<string>(maxLength: 20, nullable: false),
                    DriveName = table.Column<string>(maxLength: 50, nullable: true),
                    CarMake = table.Column<string>(maxLength: 50, nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoInsurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeType = table.Column<string>(maxLength: 50, nullable: true),
                    NumberOfStories = table.Column<string>(maxLength: 5, nullable: true),
                    NumberOfGarage = table.Column<int>(nullable: false),
                    HouseAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeInsurances", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoInsurances");

            migrationBuilder.DropTable(
                name: "HomeInsurances");
        }
    }
}

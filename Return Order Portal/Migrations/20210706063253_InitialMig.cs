using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Return_Order_Portal.Migrations
{
    public partial class InitialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessDb",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    ProcessingCharge = table.Column<int>(type: "int", nullable: false),
                    PackagingAndDeliveryCharge = table.Column<int>(type: "int", nullable: false),
                    DateOfDelivery = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDb", x => x.RequestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessDb");
        }
    }
}

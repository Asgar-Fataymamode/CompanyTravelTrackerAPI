using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyTravelTrackerAPI.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Purpose",
                table: "ForthcomingVisitors",
                newName: "PurposeOfVisit");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ForthcomingVisitors",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "BranchTravellingFrom",
                table: "ForthcomingVisitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureDate",
                table: "ForthcomingVisitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "ForthcomingVisitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeePosition",
                table: "ForthcomingVisitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ForthcomingVisitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchTravellingFrom",
                table: "ForthcomingVisitors");

            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "ForthcomingVisitors");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ForthcomingVisitors");

            migrationBuilder.DropColumn(
                name: "EmployeePosition",
                table: "ForthcomingVisitors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ForthcomingVisitors");

            migrationBuilder.RenameColumn(
                name: "PurposeOfVisit",
                table: "ForthcomingVisitors",
                newName: "Purpose");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "ForthcomingVisitors",
                newName: "Name");
        }
    }
}

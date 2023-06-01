using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Calculator.Migrations
{
    /// <inheritdoc />
    public partial class firstmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculations",
                columns: table => new
                {
                    CalculationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value1 = table.Column<double>(type: "float", nullable: false),
                    Value2 = table.Column<double>(type: "float", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    DateCalculated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculations", x => x.CalculationID);
                });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "CalculationID", "DateCalculated", "Operation", "Result", "Value1", "Value2" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 11, 42, 50, 714, DateTimeKind.Local).AddTicks(3279), "+", 8.0, 5.0, 3.0 },
                    { 2, new DateTime(2023, 6, 1, 11, 42, 50, 714, DateTimeKind.Local).AddTicks(3284), "/", 5.0, 10.0, 2.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculations");
        }
    }
}

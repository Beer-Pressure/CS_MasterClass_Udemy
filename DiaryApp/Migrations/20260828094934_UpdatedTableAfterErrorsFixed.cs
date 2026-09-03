using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTableAfterErrorsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2026, 8, 28, 15, 15, 50, 374, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2026, 8, 28, 15, 15, 50, 374, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2026, 8, 28, 15, 15, 50, 374, DateTimeKind.Local).AddTicks(9781));
        }
    }
}

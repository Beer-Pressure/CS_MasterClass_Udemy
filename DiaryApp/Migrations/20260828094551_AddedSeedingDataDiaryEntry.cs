using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Hampered form and low weights due to TFCC tear", new DateTime(2026, 8, 28, 15, 15, 50, 374, DateTimeKind.Local).AddTicks(9302), "Went to the gym" },
                    { 2, "Did physio", new DateTime(2026, 8, 28, 15, 15, 50, 374, DateTimeKind.Local).AddTicks(9780), "Went to the doctor" },
                    { 3, "Wore brace", new DateTime(2026, 8, 28, 15, 15, 50, 374, DateTimeKind.Local).AddTicks(9781), "Went to sleep" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class Added4thEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Did weak workout with injury");

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Dreamed about being rich");

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[] { 4, "Wore brace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woke up" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Hampered form and low weights due to TFCC tear");

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Wore brace");
        }
    }
}

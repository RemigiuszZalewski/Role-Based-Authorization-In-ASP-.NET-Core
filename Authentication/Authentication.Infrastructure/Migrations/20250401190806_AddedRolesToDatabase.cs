using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5d8d3cc8-4fde-4c21-a70b-deaf8ebe51a2"), null, "Admin", "ADMIN" },
                    { new Guid("66dddd1c-bf05-4032-b8a5-6adbf73dc09e"), null, "RegularEmployee", "REGULAREMPLOYEE" },
                    { new Guid("c1e9279e-e9fd-472e-8d8f-b723fdcdc919"), null, "HrManager", "HRMANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d8d3cc8-4fde-4c21-a70b-deaf8ebe51a2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("66dddd1c-bf05-4032-b8a5-6adbf73dc09e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c1e9279e-e9fd-472e-8d8f-b723fdcdc919"));
        }
    }
}

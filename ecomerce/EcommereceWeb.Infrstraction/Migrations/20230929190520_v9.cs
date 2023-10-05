using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommereceWeb.Infrstraction.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "ProductAttribute",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a2e1650-21bd-4e67-832e-2e99c267a2e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d3aa84-e715-49b9-a772-5f091f27448b", new DateTime(2023, 9, 29, 22, 5, 19, 325, DateTimeKind.Local).AddTicks(5272), "AQAAAAEAACcQAAAAEBeW40C3UE0KwtalwK8KvBpddSKuT/RzZFBwH2KBmkWLsOPxFTwtQGxl1YL3/c+3Cg==", "89f10734-bfba-4a77-a354-2e8dc62380a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "dbo",
                table: "ProductAttribute");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a2e1650-21bd-4e67-832e-2e99c267a2e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49298d3d-7eba-4800-826b-586c4b0c0fd0", new DateTime(2023, 9, 27, 20, 20, 5, 379, DateTimeKind.Local).AddTicks(5922), "AQAAAAEAACcQAAAAEOwINDvszCK7jb2E9hscAKY978vKSDAjgw9s/cm69UV0ub/7vvPLSdecyXBbH0WO0Q==", "1457130f-0d28-461b-9c23-5a5d1d7aeab4" });
        }
    }
}

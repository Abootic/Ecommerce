using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommereceWeb.Infrstraction.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                schema: "dbo",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c1f7d67-0b9e-44ef-83d4-6e4ef72d3b6f", "ca3b3647-fb97-40a0-ad64-8a3d645cdc03", "Manager", "OWNER" },
                    { "ca34737e-e863-40aa-a82f-adbd3207988a", "b9fce677-ff9b-4d55-93b0-dcb97d12b11c", "Admin", "ADMIN" },
                    { "cb512048-1ad1-437b-8930-1b70a31e4d5c", "de8c59e2-0bf9-451e-8c0f-672e0335fbf2", "ServiceProvider", "SERVICEPROVIDER" },
                    { "eedae456-fa3a-47a0-9764-c634214bbe42", "a8333576-d0ec-4caa-925c-cf7113f8df7d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FullName", "Image", "IsDeleted", "LastModfiedAt", "LastModfiedBy", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Others", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "4a2e1650-21bd-4e67-832e-2e99c267a2e4", 0, "805001dc-aa56-40b1-a451-d449bae04fa8", new DateTime(2023, 9, 10, 21, 39, 36, 447, DateTimeKind.Local).AddTicks(8201), null, null, null, "Admin@Gmail.com", false, "Admin", "unkown", false, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEMrtQmCgm5z+Z7/UVpqfllHWn2fo/804KFN94854N2wojNSsfx3bsPkXxOsfjFQ+YA==", "123456789", false, "e7159947-eebb-4f49-8d9f-310e6a2f2cac", null, false, "Admin", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca34737e-e863-40aa-a82f-adbd3207988a", "4a2e1650-21bd-4e67-832e-2e99c267a2e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c1f7d67-0b9e-44ef-83d4-6e4ef72d3b6f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb512048-1ad1-437b-8930-1b70a31e4d5c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eedae456-fa3a-47a0-9764-c634214bbe42");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca34737e-e863-40aa-a82f-adbd3207988a", "4a2e1650-21bd-4e67-832e-2e99c267a2e4" });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca34737e-e863-40aa-a82f-adbd3207988a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a2e1650-21bd-4e67-832e-2e99c267a2e4");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "dbo",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "dbo",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "dbo",
                newName: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("8b6a7f34-5ac3-48a1-8501-eb4e00f1b2e1"));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2020, 9, 8, 10, 30, 40, 207, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2020, 9, 8, 10, 30, 40, 207, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2020, 9, 8, 10, 30, 40, 207, DateTimeKind.Utc).AddTicks(6691));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2020, 9, 8, 4, 37, 46, 793, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2020, 9, 8, 4, 37, 46, 793, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2020, 9, 8, 4, 37, 46, 793, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "CreateAt", "Nome", "UpdateAt" },
                values: new object[] { new Guid("8b6a7f34-5ac3-48a1-8501-eb4e00f1b2e1"), new DateTime(2020, 9, 8, 1, 37, 46, 790, DateTimeKind.Local).AddTicks(3399), "Administrador", new DateTime(2020, 9, 8, 1, 37, 46, 791, DateTimeKind.Local).AddTicks(9494) });
        }
    }
}

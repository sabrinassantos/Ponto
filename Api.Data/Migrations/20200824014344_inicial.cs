using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registro_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "CreateAt", "Nome", "UpdateAt" },
                values: new object[] { new Guid("409b93a3-99f0-4dcd-956c-429b1712fdbe"), new DateTime(2020, 8, 23, 22, 43, 44, 114, DateTimeKind.Local).AddTicks(910), "Administrador", new DateTime(2020, 8, 23, 22, 43, 44, 114, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.CreateIndex(
                name: "IX_Registro_Data",
                table: "Registro",
                column: "Data");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_UsuarioId",
                table: "Registro",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Nome",
                table: "Usuario",
                column: "Nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

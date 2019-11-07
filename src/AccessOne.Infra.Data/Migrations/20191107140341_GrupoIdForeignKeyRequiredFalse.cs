using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessOne.Infra.Data.Migrations
{
    public partial class GrupoIdForeignKeyRequiredFalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computador_Grupo_GrupoId",
                table: "Computador");

            migrationBuilder.AlterColumn<Guid>(
                name: "GrupoId",
                table: "Computador",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Computador_Grupo_GrupoId",
                table: "Computador",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computador_Grupo_GrupoId",
                table: "Computador");

            migrationBuilder.AlterColumn<Guid>(
                name: "GrupoId",
                table: "Computador",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Computador_Grupo_GrupoId",
                table: "Computador",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

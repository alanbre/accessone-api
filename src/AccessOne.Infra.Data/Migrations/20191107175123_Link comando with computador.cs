using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessOne.Infra.Data.Migrations
{
    public partial class Linkcomandowithcomputador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExecucao",
                table: "Comando",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ComputadorId",
                table: "Comando",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExecucao",
                table: "Comando",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ComputadorId",
                table: "Comando",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));
        }
    }
}

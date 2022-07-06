using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEF.Migrations
{
    public partial class columnaTareaLimite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaLimite",
                table: "Tarea",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaLimite",
                table: "Tarea");
        }
    }
}

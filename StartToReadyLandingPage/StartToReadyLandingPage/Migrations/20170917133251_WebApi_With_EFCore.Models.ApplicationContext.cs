using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StartToReadyLandingPage.Migrations
{
    public partial class WebApi_With_EFCoreModelsApplicationContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lead",
                columns: table => new
                {
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    EhAluno = table.Column<bool>(type: "bit", nullable: false),
                    Empresa = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(maxLength: 2, nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Profissao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lead", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lead");
        }
    }
}

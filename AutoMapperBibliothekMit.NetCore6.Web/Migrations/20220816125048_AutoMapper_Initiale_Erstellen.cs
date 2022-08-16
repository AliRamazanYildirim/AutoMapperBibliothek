using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMapperBibliothekMit.NetCore6.Web.Migrations
{
    public partial class AutoMapper_Initiale_Erstellen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alter = table.Column<int>(type: "int", nullable: false),
                    GeburtsDatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Geschlecht = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adressen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inhalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provinz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostleitZahl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KundeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adressen_Kunden_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunden",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adressen_KundeId",
                table: "Adressen",
                column: "KundeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adressen");

            migrationBuilder.DropTable(
                name: "Kunden");
        }
    }
}

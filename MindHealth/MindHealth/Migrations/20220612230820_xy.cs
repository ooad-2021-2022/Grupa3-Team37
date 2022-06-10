using Microsoft.EntityFrameworkCore.Migrations;

namespace MindHealth.Migrations
{
    public partial class xy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termin_Korisnik_idKorisnika",
                table: "Termin");

            migrationBuilder.DropIndex(
                name: "IX_Termin_idKorisnika",
                table: "Termin");

            migrationBuilder.AddColumn<int>(
                name: "idPsiholog",
                table: "Termin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "specijalizacija",
                table: "Korisnik",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idPsiholog",
                table: "Termin");

            migrationBuilder.DropColumn(
                name: "specijalizacija",
                table: "Korisnik");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_idKorisnika",
                table: "Termin",
                column: "idKorisnika");

            migrationBuilder.AddForeignKey(
                name: "FK_Termin_Korisnik_idKorisnika",
                table: "Termin",
                column: "idKorisnika",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MindHealth.Migrations
{
    public partial class MindHealth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    slikaOsobe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prosjecnaOcjena = table.Column<double>(type: "float", nullable: false),
                    vrijemeNarednogTermina = table.Column<DateTime>(type: "datetime2", nullable: false),
                    skolovanje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prethodnoIskustvo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pocetakRadnogVremena = table.Column<DateTime>(type: "datetime2", nullable: false),
                    krajRadnogVremena = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datumRegistracije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    preferiraniJezik = table.Column<int>(type: "int", nullable: false),
                    preferiraniNacinUplate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    idKorisnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Korisnik_idKorisnika",
                        column: x => x.idKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrethodnaTerapija",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    koristeniLijek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumPocetkaTerapije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datumKrajaTerapije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nazivDijagnoze = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idKorisnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrethodnaTerapija", x => x.id);
                    table.ForeignKey(
                        name: "FK_PrethodnaTerapija_Korisnik_idKorisnika",
                        column: x => x.idKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecijalizacijaDijagnoze",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idKorisnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecijalizacijaDijagnoze", x => x.id);
                    table.ForeignKey(
                        name: "FK_SpecijalizacijaDijagnoze_Korisnik_idKorisnika",
                        column: x => x.idKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    idTermina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cijenaTermina = table.Column<double>(type: "float", nullable: false),
                    usernameKorisnika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usernamePsihoterapeuta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    opisTermina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idKorisnika = table.Column<int>(type: "int", nullable: false),
                    vrijemeOdrzavanja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.idTermina);
                    table.ForeignKey(
                        name: "FK_Termin_Korisnik_idKorisnika",
                        column: x => x.idKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Upitnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idKorisnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upitnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Upitnik_Korisnik_idKorisnika",
                        column: x => x.idKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumPlacanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iznosUplate = table.Column<double>(type: "float", nullable: false),
                    idTermina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racun_Termin_idTermina",
                        column: x => x.idTermina,
                        principalTable: "Termin",
                        principalColumn: "idTermina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezultatUpitnika",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postotak = table.Column<double>(type: "float", nullable: false),
                    upitnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezultatUpitnika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RezultatUpitnika_Upitnik_upitnikId",
                        column: x => x.upitnikId,
                        principalTable: "Upitnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dijagnoza",
                columns: table => new
                {
                    idDijagnoze = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vrstaDijagnoze = table.Column<int>(type: "int", nullable: false),
                    rezultatUpitnikaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dijagnoza", x => x.idDijagnoze);
                    table.ForeignKey(
                        name: "FK_Dijagnoza_RezultatUpitnika_rezultatUpitnikaID",
                        column: x => x.rezultatUpitnikaID,
                        principalTable: "RezultatUpitnika",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OdgovoriNaPitanje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dijagnozaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdgovoriNaPitanje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OdgovoriNaPitanje_Dijagnoza_dijagnozaID",
                        column: x => x.dijagnozaID,
                        principalTable: "Dijagnoza",
                        principalColumn: "idDijagnoze",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pitanje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tekstPitanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dijagnozaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitanje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pitanje_Dijagnoza_dijagnozaId",
                        column: x => x.dijagnozaId,
                        principalTable: "Dijagnoza",
                        principalColumn: "idDijagnoze",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odgovor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    odgovor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    odgovoriNaPitanjeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odgovor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Odgovor_OdgovoriNaPitanje_odgovoriNaPitanjeID",
                        column: x => x.odgovoriNaPitanjeID,
                        principalTable: "OdgovoriNaPitanje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dijagnoza_rezultatUpitnikaID",
                table: "Dijagnoza",
                column: "rezultatUpitnikaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_idKorisnika",
                table: "Ocjene",
                column: "idKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Odgovor_odgovoriNaPitanjeID",
                table: "Odgovor",
                column: "odgovoriNaPitanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_OdgovoriNaPitanje_dijagnozaID",
                table: "OdgovoriNaPitanje",
                column: "dijagnozaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pitanje_dijagnozaId",
                table: "Pitanje",
                column: "dijagnozaId");

            migrationBuilder.CreateIndex(
                name: "IX_PrethodnaTerapija_idKorisnika",
                table: "PrethodnaTerapija",
                column: "idKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_idTermina",
                table: "Racun",
                column: "idTermina");

            migrationBuilder.CreateIndex(
                name: "IX_RezultatUpitnika_upitnikId",
                table: "RezultatUpitnika",
                column: "upitnikId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecijalizacijaDijagnoze_idKorisnika",
                table: "SpecijalizacijaDijagnoze",
                column: "idKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_idKorisnika",
                table: "Termin",
                column: "idKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Upitnik_idKorisnika",
                table: "Upitnik",
                column: "idKorisnika");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Odgovor");

            migrationBuilder.DropTable(
                name: "Pitanje");

            migrationBuilder.DropTable(
                name: "PrethodnaTerapija");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "SpecijalizacijaDijagnoze");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OdgovoriNaPitanje");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "Dijagnoza");

            migrationBuilder.DropTable(
                name: "RezultatUpitnika");

            migrationBuilder.DropTable(
                name: "Upitnik");

            migrationBuilder.DropTable(
                name: "Korisnik");
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MindHealth.Data;

namespace MindHealth.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MindHealth.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TherapistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idTherapist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("TherapistId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("MindHealth.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("krajRadnogVremena")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("pocetakRadnogVremena")
                        .HasColumnType("datetime2");

                    b.Property<int>("preferiraniJezik")
                        .HasColumnType("int");

                    b.Property<int>("preferiraniNacinUplate")
                        .HasColumnType("int");

                    b.Property<string>("prethodnoIskustvo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("prosjecnaOcjena")
                        .HasColumnType("float");

                    b.Property<string>("skolovanje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slikaOsobe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("specijalizacija")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeNarednogTermina")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("MindHealth.Models.Ocjene", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.Property<int>("ocjena")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("idKorisnika");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("MindHealth.Models.Odgovor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("odgovor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("odgovoriNaPitanjeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("odgovoriNaPitanjeID");

                    b.ToTable("Odgovor");
                });

            modelBuilder.Entity("MindHealth.Models.OdgovoriNaPitanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("odgovoreno")
                        .HasColumnType("int");

                    b.Property<string>("tekstPitanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("upitnikID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("upitnikID");

                    b.ToTable("OdgovoriNaPitanje");
                });

            modelBuilder.Entity("MindHealth.Models.PrethodnaTerapija", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumKrajaTerapije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumPocetkaTerapije")
                        .HasColumnType("datetime2");

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.Property<string>("koristeniLijek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazivDijagnoze")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idKorisnika");

                    b.ToTable("PrethodnaTerapija");
                });

            modelBuilder.Entity("MindHealth.Models.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumPlacanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("idTermina")
                        .HasColumnType("int");

                    b.Property<double>("iznosUplate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("idTermina");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("MindHealth.Models.SpecijalizacijaDijagnoze", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idKorisnika");

                    b.ToTable("SpecijalizacijaDijagnoze");
                });

            modelBuilder.Entity("MindHealth.Models.Termin", b =>
                {
                    b.Property<int>("idTermina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("cijenaTermina")
                        .HasColumnType("float");

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.Property<int>("idPsiholog")
                        .HasColumnType("int");

                    b.Property<string>("opisTermina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usernameKorisnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usernamePsihoterapeuta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeOdrzavanja")
                        .HasColumnType("datetime2");

                    b.HasKey("idTermina");

                    b.ToTable("Termin");
                });

            modelBuilder.Entity("MindHealth.Models.Upitnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idKorisnika");

                    b.ToTable("Upitnik");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MindHealth.Models.Chat", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Therapist")
                        .WithMany()
                        .HasForeignKey("TherapistId");

                    b.Navigation("IdentityUser");

                    b.Navigation("Therapist");
                });

            modelBuilder.Entity("MindHealth.Models.Ocjene", b =>
                {
                    b.HasOne("MindHealth.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("idKorisnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("MindHealth.Models.Odgovor", b =>
                {
                    b.HasOne("MindHealth.Models.OdgovoriNaPitanje", "OdgovoriNaPitanje")
                        .WithMany()
                        .HasForeignKey("odgovoriNaPitanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OdgovoriNaPitanje");
                });

            modelBuilder.Entity("MindHealth.Models.OdgovoriNaPitanje", b =>
                {
                    b.HasOne("MindHealth.Models.Upitnik", "Upitnik")
                        .WithMany()
                        .HasForeignKey("upitnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Upitnik");
                });

            modelBuilder.Entity("MindHealth.Models.PrethodnaTerapija", b =>
                {
                    b.HasOne("MindHealth.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("idKorisnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("MindHealth.Models.Racun", b =>
                {
                    b.HasOne("MindHealth.Models.Termin", "Termin")
                        .WithMany()
                        .HasForeignKey("idTermina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Termin");
                });

            modelBuilder.Entity("MindHealth.Models.SpecijalizacijaDijagnoze", b =>
                {
                    b.HasOne("MindHealth.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("idKorisnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("MindHealth.Models.Upitnik", b =>
                {
                    b.HasOne("MindHealth.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("idKorisnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });
#pragma warning restore 612, 618
        }
    }
}

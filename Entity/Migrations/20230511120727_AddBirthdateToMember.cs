using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthdateToMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCard = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    StreetNumber = table.Column<int>(type: "INTEGER", maxLength: 3, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Picture = table.Column<string>(type: "TEXT", nullable: false),
                    PositiveResultDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecoveryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member", x => x.Id);
                    table.UniqueConstraint("AK_member_IdCard", x => x.IdCard);
                    table.CheckConstraint("DateOfBirth must be before today", "DateOfBirth < date('now')");
                });

            migrationBuilder.CreateTable(
                name: "coronaVaccine",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCard = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ManuFacturer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coronaVaccine", x => x.id);
                    table.ForeignKey(
                        name: "FK_coronaVaccine_member_IdCard",
                        column: x => x.IdCard,
                        principalTable: "member",
                        principalColumn: "IdCard",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coronaVaccine_IdCard",
                table: "coronaVaccine",
                column: "IdCard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coronaVaccine");

            migrationBuilder.DropTable(
                name: "member");
        }
    }
}

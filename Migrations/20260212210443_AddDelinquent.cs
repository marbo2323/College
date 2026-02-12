using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College.Migrations
{
    /// <inheritdoc />
    public partial class AddDelinquent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Delinquent",
                columns: table => new
                {
                    DelinquentsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    EventDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    isStudent = table.Column<bool>(type: "INTEGER", nullable: false),
                    violation = table.Column<int>(type: "INTEGER", nullable: false),
                    PunishmentType = table.Column<string>(type: "TEXT", nullable: false),
                    PunishmentLenght = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delinquent", x => x.DelinquentsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delinquent");
        }
    }
}

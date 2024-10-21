using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StateMaster.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateNameEnglish = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StateNameHindi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StateNameCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "States");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace noexcuses.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WklyStands",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    teamName = table.Column<string>(nullable: false),
                    wkNumber = table.Column<int>(nullable: false),
                    wkRank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WklyStands", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WklyStands");
        }
    }
}

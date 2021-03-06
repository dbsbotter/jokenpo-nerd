﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Jokenpo.Domain.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jokenpo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PlayerOne = table.Column<string>(type: "char", maxLength: 1, nullable: false),
                    PlayerTwo = table.Column<string>(type: "char", maxLength: 1, nullable: false),
                    PlayerWinner = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jokenpo", x => x.Id);
                    table.CheckConstraint("CK_Jokenpos_PlayerOne", "PlayerOne = 'R' OR PlayerOne = 'P' OR PlayerOne = 'S' OR PlayerOne = 'L' OR PlayerOne = 'K'");
                    table.CheckConstraint("CK_Jokenpos_PlayerTwo", "PlayerTwo = 'R' OR PlayerTwo = 'P' OR PlayerTwo = 'S' OR PlayerTwo = 'L' OR PlayerTwo = 'K'");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jokenpo");
        }
    }
}

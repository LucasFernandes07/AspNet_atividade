﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teste.Migrations
{
    /// <inheritdoc />
    public partial class Aplicação : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

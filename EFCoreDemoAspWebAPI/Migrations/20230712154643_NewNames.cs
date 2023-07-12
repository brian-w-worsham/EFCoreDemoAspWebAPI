﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemoAspWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.EnsureSchema(
                name: "movies");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "GenresTbl",
                newSchema: "movies");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "movies",
                table: "GenresTbl",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenresTbl",
                schema: "movies",
                table: "GenresTbl",
                column: "Identifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GenresTbl",
                schema: "movies",
                table: "GenresTbl");

            migrationBuilder.RenameTable(
                name: "GenresTbl",
                schema: "movies",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genres",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Identifier");
        }
    }
}

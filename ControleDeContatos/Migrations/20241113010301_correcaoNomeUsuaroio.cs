﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeContatos.Migrations
{
    /// <inheritdoc />
    public partial class correcaoNomeUsuaroio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Usuarios",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "Name");
        }
    }
}

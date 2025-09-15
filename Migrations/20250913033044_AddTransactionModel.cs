﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myapp.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Transactions",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "Transactions",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Transactions",
                newName: "Content");
        }
    }
}

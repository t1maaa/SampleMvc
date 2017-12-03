using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SampleMvc.Db.Migrations
{
    public partial class AddOwnerMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "MovieDbContext",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieDbContext_OwnerId",
                table: "MovieDbContext",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDbContext_AspNetUsers_OwnerId",
                table: "MovieDbContext",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDbContext_AspNetUsers_OwnerId",
                table: "MovieDbContext");

            migrationBuilder.DropIndex(
                name: "IX_MovieDbContext_OwnerId",
                table: "MovieDbContext");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "MovieDbContext");
        }
    }
}

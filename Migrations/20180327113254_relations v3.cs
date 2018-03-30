using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace dotnet_core_projects.Migrations
{
    public partial class relationsv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movie",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actor",
                newName: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actor",
                newName: "Id");
        }
    }
}

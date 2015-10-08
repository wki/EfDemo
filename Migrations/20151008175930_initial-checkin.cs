using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace EfDemo.Migrations
{
    public partial class initialcheckin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    personid = table.Column<int>(isNullable: false)
                        .Annotation("Npgsql:Serial", true),
                    name = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.personid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("person");
        }
    }
}

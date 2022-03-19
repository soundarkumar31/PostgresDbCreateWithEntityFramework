using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PostgresDbCreate.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("Migration_190320221920")]
    public class Migration2 : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("SubTitle", "Blogs", type: "integer",nullable:true);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("SubTitle", "Blogs");
        }
    }
}

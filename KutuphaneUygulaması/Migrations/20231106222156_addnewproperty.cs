using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneUygulaması.Migrations
{
    public partial class addnewproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "GeriGetirmeTarihi",
                table: "kitaplar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OduncAlanAdi",
                table: "kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeriGetirmeTarihi",
                table: "kitaplar");

            migrationBuilder.DropColumn(
                name: "OduncAlanAdi",
                table: "kitaplar");
        }
    }
}

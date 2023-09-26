using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapevi_DataAccess.Migrations
{
    public partial class EkleYayınVeYazarDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Yayinevi",
                columns: table => new
                {
                    YayınEvi_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayınEviAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Yayinevi", x => x.YayınEvi_Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Yazar",
                columns: table => new
                {
                    Yazar_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yazar_Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yazar_Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yazar_Dogum_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Yazar", x => x.Yazar_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Yayinevi");

            migrationBuilder.DropTable(
                name: "tb_Yazar");
        }
    }
}

﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapevi_DataAccess.Migrations
{
    public partial class BirebirIliskiKitapVeDetayDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitapDetay_Id",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "KitapDetay",
                columns: table => new
                {
                    KitapDetay_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumSayisi = table.Column<int>(type: "int", nullable: false),
                    KitapSayfasi = table.Column<int>(type: "int", nullable: false),
                    KitapAgirlik = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapDetay", x => x.KitapDetay_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KitapDetay_Id",
                table: "tb_Kitap",
                column: "KitapDetay_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_KitapDetay_KitapDetay_Id",
                table: "tb_Kitap",
                column: "KitapDetay_Id",
                principalTable: "KitapDetay",
                principalColumn: "KitapDetay_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_KitapDetay_KitapDetay_Id",
                table: "tb_Kitap");

            migrationBuilder.DropTable(
                name: "KitapDetay");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KitapDetay_Id",
                table: "tb_Kitap");

            migrationBuilder.DropColumn(
                name: "KitapDetay_Id",
                table: "tb_Kitap");
        }
    }
}

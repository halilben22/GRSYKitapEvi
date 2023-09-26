using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapevi_DataAccess.Migrations
{
    public partial class EkleIliskiYayınVeKategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KategoriId",
                table: "tb_Kitap",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_kategoriler_KategoriId",
                table: "tb_Kitap",
                column: "KategoriId",
                principalTable: "tb_kategoriler",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_kategoriler_KategoriId",
                table: "tb_Kitap");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KategoriId",
                table: "tb_Kitap");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "tb_Kitap");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurrasAPI.Migrations
{
    public partial class Terceira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Churrascos_ChurrascoId",
                table: "Participantes");

            migrationBuilder.AlterColumn<int>(
                name: "ChurrascoId",
                table: "Participantes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Churrascos_ChurrascoId",
                table: "Participantes",
                column: "ChurrascoId",
                principalTable: "Churrascos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Churrascos_ChurrascoId",
                table: "Participantes");

            migrationBuilder.AlterColumn<int>(
                name: "ChurrascoId",
                table: "Participantes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Churrascos_ChurrascoId",
                table: "Participantes",
                column: "ChurrascoId",
                principalTable: "Churrascos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurrasAPI.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "Participantes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "ValorComBebida",
                table: "Churrascos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValorSemBebida",
                table: "Churrascos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pago",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "ValorComBebida",
                table: "Churrascos");

            migrationBuilder.DropColumn(
                name: "ValorSemBebida",
                table: "Churrascos");
        }
    }
}

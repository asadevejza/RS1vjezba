using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MojaAplikacija.Migrations
{
    /// <inheritdoc />
    public partial class Smjerovi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SmjerId",
                table: "Studenti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sMJER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sMJER", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 1,
                column: "SmjerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 2,
                column: "SmjerId",
                value: null);

            migrationBuilder.InsertData(
                table: "sMJER",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Softverski inženjering" },
                    { 2, "Razvoj softvera" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_SmjerId",
                table: "Studenti",
                column: "SmjerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_sMJER_SmjerId",
                table: "Studenti",
                column: "SmjerId",
                principalTable: "sMJER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_sMJER_SmjerId",
                table: "Studenti");

            migrationBuilder.DropTable(
                name: "sMJER");

            migrationBuilder.DropIndex(
                name: "IX_Studenti_SmjerId",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "SmjerId",
                table: "Studenti");
        }
    }
}

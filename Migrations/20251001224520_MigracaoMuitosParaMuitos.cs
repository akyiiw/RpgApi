using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPGAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Flash" },
                    { 2, 40, "Ignite" },
                    { 3, 50, "Smite" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 31, 88, 12, 35, 143, 176, 205, 49, 149, 100, 119, 252, 60, 147, 172, 62, 169, 82, 159, 76, 85, 152, 121, 159, 209, 117, 67, 92, 206, 9, 161, 114, 229, 239, 42, 118, 42, 76, 69, 159, 225, 212, 181, 248, 226, 62, 220, 248, 179, 165, 213, 175, 219, 136, 141, 54, 166, 61, 219, 24, 170, 27, 228, 244 }, new byte[] { 199, 18, 206, 196, 200, 255, 8, 143, 218, 60, 48, 110, 55, 21, 104, 215, 178, 5, 83, 198, 113, 255, 206, 85, 193, 21, 170, 249, 144, 193, 204, 8, 233, 233, 233, 161, 54, 93, 66, 213, 92, 24, 37, 130, 134, 118, 138, 221, 8, 45, 207, 35, 63, 146, 96, 1, 14, 20, 21, 32, 47, 94, 206, 117, 44, 68, 84, 213, 1, 125, 238, 114, 238, 198, 141, 192, 123, 236, 97, 6, 138, 255, 89, 66, 92, 118, 100, 146, 184, 78, 139, 193, 56, 110, 193, 128, 46, 36, 98, 165, 123, 72, 189, 100, 143, 254, 86, 86, 49, 68, 37, 38, 35, 84, 4, 169, 158, 219, 228, 39, 191, 232, 6, 19, 233, 20, 29, 19 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 17, 169, 174, 47, 227, 240, 36, 183, 204, 94, 43, 239, 2, 195, 95, 40, 63, 95, 76, 42, 188, 254, 138, 53, 123, 245, 80, 240, 138, 96, 30, 177, 172, 86, 198, 243, 134, 29, 116, 68, 157, 105, 63, 198, 93, 97, 221, 176, 41, 114, 237, 159, 130, 169, 23, 113, 43, 42, 68, 16, 157, 209, 35 }, new byte[] { 91, 214, 120, 229, 50, 54, 206, 39, 192, 115, 43, 126, 57, 93, 160, 161, 22, 116, 237, 121, 3, 44, 129, 232, 48, 40, 173, 161, 17, 31, 192, 169, 125, 96, 31, 21, 220, 179, 190, 76, 63, 20, 216, 198, 163, 205, 5, 234, 89, 173, 245, 182, 25, 35, 163, 26, 103, 64, 46, 245, 246, 71, 17, 213, 31, 18, 142, 163, 82, 55, 165, 127, 52, 173, 32, 156, 6, 135, 77, 136, 121, 54, 175, 174, 34, 225, 66, 84, 75, 21, 79, 66, 68, 57, 165, 32, 97, 248, 150, 218, 234, 13, 228, 243, 30, 136, 107, 33, 181, 173, 143, 52, 65, 48, 138, 35, 175, 237, 197, 240, 95, 31, 107, 252, 67, 164, 194, 167 } });
        }
    }
}

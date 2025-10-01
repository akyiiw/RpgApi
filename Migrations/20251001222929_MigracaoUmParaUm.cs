using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 17, 169, 174, 47, 227, 240, 36, 183, 204, 94, 43, 239, 2, 195, 95, 40, 63, 95, 76, 42, 188, 254, 138, 53, 123, 245, 80, 240, 138, 96, 30, 177, 172, 86, 198, 243, 134, 29, 116, 68, 157, 105, 63, 198, 93, 97, 221, 176, 41, 114, 237, 159, 130, 169, 23, 113, 43, 42, 68, 16, 157, 209, 35 }, new byte[] { 91, 214, 120, 229, 50, 54, 206, 39, 192, 115, 43, 126, 57, 93, 160, 161, 22, 116, 237, 121, 3, 44, 129, 232, 48, 40, 173, 161, 17, 31, 192, 169, 125, 96, 31, 21, 220, 179, 190, 76, 63, 20, 216, 198, 163, 205, 5, 234, 89, 173, 245, 182, 25, 35, 163, 26, 103, 64, 46, 245, 246, 71, 17, 213, 31, 18, 142, 163, 82, 55, 165, 127, 52, 173, 32, 156, 6, 135, 77, 136, 121, 54, 175, 174, 34, 225, 66, 84, 75, 21, 79, 66, 68, 57, 165, 32, 97, 248, 150, 218, 234, 13, 228, 243, 30, 136, 107, 33, 181, 173, 143, 52, 65, 48, 138, 35, 175, 237, 197, 240, 95, 31, 107, 252, 67, 164, 194, 167 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 180, 248, 253, 92, 60, 170, 81, 161, 165, 137, 31, 81, 239, 41, 3, 29, 218, 9, 231, 65, 0, 124, 102, 209, 134, 166, 8, 113, 155, 144, 163, 168, 125, 146, 101, 0, 39, 41, 45, 8, 11, 84, 189, 25, 76, 100, 28, 200, 165, 121, 83, 34, 98, 8, 214, 101, 73, 100, 115, 105, 80, 240, 78, 210 }, new byte[] { 132, 52, 252, 1, 93, 191, 76, 16, 164, 104, 211, 166, 99, 228, 246, 14, 12, 137, 128, 114, 114, 224, 26, 254, 140, 24, 43, 175, 157, 178, 123, 132, 150, 65, 202, 217, 153, 220, 155, 107, 175, 244, 171, 102, 216, 200, 188, 180, 214, 221, 34, 204, 242, 141, 127, 227, 243, 31, 66, 193, 104, 25, 78, 171, 49, 149, 125, 54, 189, 61, 65, 117, 26, 36, 140, 244, 167, 128, 253, 112, 204, 42, 240, 171, 243, 80, 194, 69, 223, 220, 204, 102, 79, 202, 249, 250, 84, 215, 68, 48, 37, 0, 133, 22, 111, 124, 74, 234, 38, 58, 127, 108, 32, 200, 111, 221, 139, 70, 108, 163, 146, 190, 40, 11, 170, 20, 252, 50 } });
        }
    }
}

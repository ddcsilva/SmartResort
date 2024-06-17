using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace SmartResort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTabelaQuarto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "int", nullable: false),
                    DetalhesExtras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BangaloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Quartos_Bangalos_BangaloId",
                        column: x => x.BangaloId,
                        principalTable: "Bangalos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Quartos",
                columns: ["Numero", "BangaloId", "DetalhesExtras"],
                values: new object[,]
                {
                    { 101, 1, null },
                    { 102, 1, null },
                    { 103, 1, null },
                    { 104, 1, null },
                    { 201, 2, null },
                    { 202, 2, null },
                    { 203, 2, null },
                    { 301, 3, null },
                    { 302, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_BangaloId",
                table: "Quartos",
                column: "BangaloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quartos");
        }
    }
}

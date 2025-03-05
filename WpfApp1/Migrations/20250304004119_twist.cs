using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class twist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "typpe",
                table: "Addtransactions",
                newName: "type");

            migrationBuilder.AlterColumn<string>(
                name: "amount",
                table: "Addtransactions",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.CreateTable(
                name: "Addcategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addcategory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addcategory");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Addtransactions",
                newName: "typpe");

            migrationBuilder.AlterColumn<float>(
                name: "amount",
                table: "Addtransactions",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    P_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Price = table.Column<int>(type: "int", nullable: false),
                    P_Qty = table.Column<int>(type: "int", nullable: false),
                    P_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.P_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Mob_Num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    O_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Id = table.Column<int>(type: "int", nullable: false),
                    U_Id = table.Column<int>(type: "int", nullable: false),
                    O_Qty = table.Column<int>(type: "int", nullable: false),
                    O_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.O_Id);
                    table.ForeignKey(
                        name: "FK_Orders_Products_P_Id",
                        column: x => x.P_Id,
                        principalTable: "Products",
                        principalColumn: "P_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_U_Id",
                        column: x => x.U_Id,
                        principalTable: "Users",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_P_Id",
                table: "Orders",
                column: "P_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_U_Id",
                table: "Orders",
                column: "U_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniETrade.Dal.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    SubCatId = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCatId",
                        column: x => x.SubCatId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCatId",
                table: "Products",
                column: "SubCatId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
            migrationBuilder.InsertData(
    table: "Categories",
    columns: new[] { "Id", "Name" },
    values: new object[,]
    {
                    { 1, "Elektronik"},
                    { 2, "Ev Eşyası"},
                    { 3, "Bakım Ürünler"},
                    { 4, "Kozmetik Ürünler"},
    });
            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1,"Dizüstü Bilgisayar"},
                    { 2, 1, "Cep Telefonu"},
                    { 3, 1, "Mouse"},
                    { 4, 1, "Klavye"},
                    { 5, 2, "Tv Ünitesi"},
                    { 6, 2, "Mobilya"},
                    { 7, 2, "Sehpa"},
                    { 8, 3, "Cilt Bakım Ürünleri"},
                    { 9, 4, "Göz Ürünleri"},
                    { 10, 4, "Allık"},
                });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "UnitPrice", "Amount", "SubCatId", "Img", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 12000, 1, 1, "/images/AcerNitr5AN515.jpg", 1, "Acer Nitro 5AN515"},
                    { 2, 24400, 1, 1, "/images/DELLGamingG5.jpg", 1, "DELL Gaming G5"},
                    { 3, 32000, 1, 2, "/images/iphoneX.jpg", 1, "Iphone X"},
                    { 4, 18250, 1, 1, "/images/victus.jpg", 1, "Victus 24212"},
                    { 5, 13990, 1, 1, "/images/AcerNitro5.jpg", 1, "Acer Nitro 5"},
                    { 6, 45000, 1, 1, "/images/msi.jpg", 1, "MSI XS566"},
                    { 7, 4500, 1, 5, "/images/m1.jpg", 2, "Felis TV Ünitesi"},
                    { 8, 7200, 1, 5, "/images/m4.jpg", 2, "Ultra Lüx Tv Ünitesi"},
                    { 9, 22750, 1, 6, "/images/m3.jpg", 2, "Antrasit Koltuk"},
                    { 10, 4520, 1, 6, "/images/m5.jpg", 2, "Tekli Koltuk 21341"},
                    { 11, 6200, 1, 6, "/images/m6.jpg", 2, "Tekli Geniş Berjer"},
                    { 12, 750, 1, 7, "/images/m8.jpg", 2, "Enza Tekerlekli Sehpa"},
                    { 13, 990, 1, 7, "/images/m9.jpg", 2, "Vivense Sehpa"},
                    { 14, 80, 1, 9, "/images/koz1.jpg", 4, "Rimel X"},
                    { 15, 50, 1, 10, "/images/koz2.jpg", 4, "Mac 01 Allık"},
                    { 16, 250, 1, 8, "/images/cilt1.jpg", 3, "Pure Yüz Serumu"},
                    { 17, 299, 1, 8, "/images/cilt2.jpg", 3, "Güneş Kremi"},
                    { 18, 160, 1, 8, "/images/cilt4.jpg", 3, "Clinique Nemlendirici"},
                    { 19, 48200, 1, 2, "/images/iphone13promax.jpg", 1, "Iphone13 Pro Max"},
                    { 20, 120, 1, 4, "/images/EverestKB-517U.jpg", 1, "Everest Klavye 38X31"},
                    { 21, 240, 1, 3, "/images/AsusTufGaming.jpg", 1, "Asus Gaming Mouse"},
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

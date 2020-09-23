using Microsoft.EntityFrameworkCore.Migrations;

namespace CrossRouting.Migrations
{
    public partial class CoinageCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoinageCompany",
                columns: table => new
                {
                    CompanyOID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 250, nullable: false),
                    Street = table.Column<string>(maxLength: 250, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinageCompany", x => x.CompanyOID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinageCompany");
        }
    }
}

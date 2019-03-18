using Microsoft.EntityFrameworkCore.Migrations;

namespace USVisual.API.Migrations
{
    public partial class AddDeathClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deaths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    iyear = table.Column<string>(nullable: true),
                    imonth = table.Column<string>(nullable: true),
                    country_txt = table.Column<string>(nullable: true),
                    region_txt = table.Column<string>(nullable: true),
                    attacktype1_txt = table.Column<string>(nullable: true),
                    weaptype1_txt = table.Column<string>(nullable: true),
                    nkill = table.Column<string>(nullable: true),
                    nwound = table.Column<string>(nullable: true),
                    latitude = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deaths", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deaths");
        }
    }
}

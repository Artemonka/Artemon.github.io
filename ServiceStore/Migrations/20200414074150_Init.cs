using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceStore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Passwrord = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Admin = table.Column<bool>(nullable: false),
                    Buy = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    FullDesc1 = table.Column<string>(nullable: true),
                    FullDesc2 = table.Column<string>(nullable: true),
                    FullDesc3 = table.Column<string>(nullable: true),
                    FullDesc4 = table.Column<string>(nullable: true),
                    FullDesc5 = table.Column<string>(nullable: true),
                    FullDesc6 = table.Column<string>(nullable: true),
                    FullDesc7 = table.Column<string>(nullable: true),
                    FullDesc8 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}

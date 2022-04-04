using Microsoft.EntityFrameworkCore.Migrations;

namespace Policy_Microservice.Migrations
{
    public partial class creatingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aves",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONSUMER_ID = table.Column<int>(nullable: false),
                    PROPERTY_ID = table.Column<int>(nullable: false),
                    POLICY_ID = table.Column<int>(nullable: false),
                    QUOTE = table.Column<float>(nullable: false),
                    AGENT = table.Column<string>(nullable: true),
                    STATUS = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aves", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROPERTY_TYPE = table.Column<string>(nullable: true),
                    CONSUMER_TYPE = table.Column<string>(nullable: true),
                    ASSURED_SUM = table.Column<float>(nullable: false),
                    TENURE = table.Column<int>(nullable: false),
                    BUSINESS_VALUE = table.Column<int>(nullable: false),
                    PROPERTY_VALUE = table.Column<int>(nullable: false),
                    BASE_LOCATION = table.Column<string>(nullable: true),
                    TYPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aves");

            migrationBuilder.DropTable(
                name: "Policies");
        }
    }
}

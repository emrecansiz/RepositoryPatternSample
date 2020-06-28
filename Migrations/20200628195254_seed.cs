using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryPatternSample.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[] { 1, "test1", "test2" });

            migrationBuilder.InsertData(
                table: "Peoples",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[] { 2, "test3", "test4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Peoples",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Peoples",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

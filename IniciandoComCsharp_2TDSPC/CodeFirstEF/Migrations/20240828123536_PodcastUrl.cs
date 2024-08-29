using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class PodcastUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Podcasts",
                type: "NVARCHAR2(2000)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Podcasts");
        }
    }
}

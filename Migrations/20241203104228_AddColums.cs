using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVG.Migrations
{
    /// <inheritdoc />
    public partial class AddColums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "ProjectsModel",
                type: "TEXT",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "ProjectsModel",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "ProjectsModel");
            migrationBuilder.DropColumn(
                name: "Link",
                table: "ProjectsModel");
            migrationBuilder.DropTable(
                name: "ProjectsModel");
        }
    }
}

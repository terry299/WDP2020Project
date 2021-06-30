using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetUserRolesEntityFramework.Data.Migrations
{
    public partial class assignmentv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Agree",
                table: "DiscussionForum",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disagree",
                table: "DiscussionForum",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agree",
                table: "DiscussionForum");

            migrationBuilder.DropColumn(
                name: "Disagree",
                table: "DiscussionForum");
        }
    }
}

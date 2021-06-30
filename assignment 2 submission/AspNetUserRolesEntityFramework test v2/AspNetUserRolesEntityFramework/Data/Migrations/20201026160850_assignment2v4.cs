using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetUserRolesEntityFramework.Data.Migrations
{
    public partial class assignment2v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "canAgree",
                table: "DiscussionForum",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "canDisagree",
                table: "DiscussionForum",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "canAgree",
                table: "DiscussionForum");

            migrationBuilder.DropColumn(
                name: "canDisagree",
                table: "DiscussionForum");
        }
    }
}

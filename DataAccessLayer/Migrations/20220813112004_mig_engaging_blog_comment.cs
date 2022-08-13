using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_engaging_blog_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "CommentMails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CommentMails_BlogId",
                table: "CommentMails",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentMails_Blogs_BlogId",
                table: "CommentMails",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentMails_Blogs_BlogId",
                table: "CommentMails");

            migrationBuilder.DropIndex(
                name: "IX_CommentMails_BlogId",
                table: "CommentMails");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "CommentMails");
        }
    }
}

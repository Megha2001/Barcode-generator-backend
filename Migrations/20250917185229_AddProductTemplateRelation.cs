using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarcodeFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTemplateRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Templates_TemplateIdTemplateReferenceId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TemplateIdTemplateReferenceId",
                table: "Products",
                newName: "TemplateReferenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TemplateIdTemplateReferenceId",
                table: "Products",
                newName: "IX_Products_TemplateReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Templates_TemplateReferenceId",
                table: "Products",
                column: "TemplateReferenceId",
                principalTable: "Templates",
                principalColumn: "TemplateReferenceId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Templates_TemplateReferenceId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TemplateReferenceId",
                table: "Products",
                newName: "TemplateIdTemplateReferenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TemplateReferenceId",
                table: "Products",
                newName: "IX_Products_TemplateIdTemplateReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Templates_TemplateIdTemplateReferenceId",
                table: "Products",
                column: "TemplateIdTemplateReferenceId",
                principalTable: "Templates",
                principalColumn: "TemplateReferenceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

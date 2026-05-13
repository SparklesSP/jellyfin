using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.Database.Providers.Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class AddGlobalLibrarySectionVisibilityFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HideFromGlobalLibrarySections",
                table: "BaseItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowInGlobalLibrarySectionsAsLinkedParent",
                table: "BaseItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BaseItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "HideFromGlobalLibrarySections", "ShowInGlobalLibrarySectionsAsLinkedParent" },
                values: new object[] { false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HideFromGlobalLibrarySections",
                table: "BaseItems");

            migrationBuilder.DropColumn(
                name: "ShowInGlobalLibrarySectionsAsLinkedParent",
                table: "BaseItems");
        }
    }
}

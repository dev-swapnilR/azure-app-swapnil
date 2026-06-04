using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azure_app_swapnil.Migrations
{
    /// <inheritdoc />
    public partial class RenameDaeOfBirthToDateOfBirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaeOfBirth",
                table: "Persons",
                newName: "DateOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Persons",
                newName: "DaeOfBirth");
        }
    }
}

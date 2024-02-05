// Importing necessary namespaces
using System;
using Microsoft.EntityFrameworkCore.Migrations;

// Disabling nullable warnings for this file
#nullable disable

// Namespace for managing database migrations
namespace BulkyBookWeb.Migrations
{
    /// <summary>
    /// Migration class for adding the Category table to the database
    /// </summary>
    public partial class AddCategoryToDatabase : Migration
    {
        /// <summary>
        /// Method to define the changes to be applied when updating the database (Up migration)
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Creating a new table named "Categories" with the specified columns
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"), // Auto-incrementing primary key
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false), // Category name
                    DisplayOrder = table.Column<int>(type: "int", nullable: false), // Display order of the category
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false) // Date and time of creation
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id); // Setting the primary key constraint
                });
        }

        /// <summary>
        /// Method to define the changes to be applied when reverting the database update (Down migration)
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Dropping the "Categories" table
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

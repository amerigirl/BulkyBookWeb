using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
	/// <inheritdoc />
	public partial class ArtistModel : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Artists",
				columns: table => new
				{
					ArtistId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					SongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Album = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Artists", x => x.ArtistId);
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Artists");
		}
	}
}

using System.ComponentModel.DataAnnotations;


namespace BulkyBookWeb.Models
{
	public class Artist
	{
		[Key]
		public int ArtistId { get; set; }

		[Required]
		public string ArtistName { get; set; }

		[Required]
		public string SongName { get; set; }
		public string Album { get; set; }
	}
}

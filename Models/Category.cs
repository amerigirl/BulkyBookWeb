using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public String Name { get; set; }
		
		public String SongTitle { get; set; }


		//current date and time will always be assigned to CreatedDateTime
		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
	}

}

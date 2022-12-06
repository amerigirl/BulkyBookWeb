using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace BulkyBookWeb.Controllers
{
	public class ArtistController : Controller
	{

		private readonly ApplicationDBContext _db;

		public ArtistController(ApplicationDBContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{

			IEnumerable<Artist> objArtistList = _db.Artists; //i added "specific typecast--it says it exposes the numerator--wtf does that mean?!"
			return View(objArtistList);
		}




	}
}

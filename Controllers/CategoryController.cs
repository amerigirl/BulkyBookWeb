using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDBContext _db;

		public CategoryController(ApplicationDBContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			//switched from var objCategory to IEnumerable--
			//took .toList() off _db.Categories since we switched to IEnumerable (whatever that is :) )

			IEnumerable<Category> objCategoryList = _db.Categories;

			/*you need to learn about IEnumerable...not sure what's happening here but I know that obj list is being passed from the database to
			 the view via the conversion happening on line 21--IEnumerable*/
			return View(objCategoryList);
		}
	}
}

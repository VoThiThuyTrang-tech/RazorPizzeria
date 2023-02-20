using Microsoft.AspNetCore.Mvc;
using RazorPizzeria.Data;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages
{
	public class PizzasController : Controller
	{
		private readonly ApplicationDbContext _db;

		public PizzasController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			IEnumerable<PizzaOrder> objPizzaList = _db.PizzaOrders;
			return View(objPizzaList);
		}
	}
}

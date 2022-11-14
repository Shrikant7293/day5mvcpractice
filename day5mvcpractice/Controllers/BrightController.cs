using day5mvcpractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace day5mvcpractice.Controllers
{
	public class BrightController : Controller
	{
		public static List<Bright> Brights = new List<Bright>();

		public IActionResult Student()
		{
			return View(Brights);
		}

		[HttpGet]
		public IActionResult Add()
		{
			Bright Brights= new Bright();	
			return View(Brights);
		}

		[HttpPost]
		public IActionResult Add(Bright bright)
		{
			Brights.Add(bright);
			return RedirectToAction("Student");
		}


		public IActionResult Delete(int id)
		{
			var Bright = Brights.FirstOrDefault(bright => bright.Id == id);
			Brights.Remove(Bright);
			return RedirectToAction("Student");
		}

		[HttpGet]

		public IActionResult Edit()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Edit(Bright bright)
		{
			return View();
		}
	}
}

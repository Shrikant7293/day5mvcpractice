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

		public IActionResult Edit(int id)
		{
			Bright bright=Brights.FirstOrDefault(bright=>bright.Id==id);
			return View(bright);
		}

		[HttpPost]

		public IActionResult Edit(Bright bright)
		{
			Bright brightToUpdate = Brights.FirstOrDefault(b =>b.Id==bright.Id);

			brightToUpdate.Id = bright.Id;
			brightToUpdate.Name = bright.Name;
			brightToUpdate.Course = bright.Course;


			return RedirectToAction("Student");
		}
	}
}

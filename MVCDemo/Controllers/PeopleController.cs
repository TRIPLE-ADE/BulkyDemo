using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System;

namespace MVCDemo.Controllers
{
	public class PeopleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ListPeople()
		{
			List<PersonModel> people = new List<PersonModel>();

			people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 38 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 56 });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Connor", Age = 25 });
            return View(people);
		}
	}
}

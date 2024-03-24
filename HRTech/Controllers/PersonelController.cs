using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Personel.Models;

namespace Ornek.Controllers
{
	public class PersonelController : Controller
	{
		private readonly HttpClient _httpClient;

		public PersonelController(HRTechDbContext httpClient)
		{
			_httpClient = httpClient;
		}

		// GET: Personel
		public IActionResult Index()
		{
			var personeller = _httpClient.Personeller.ToList();
			return View(personeller);
		}

		// GET: Personel/Details/id
		public IActionResult Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var personel = _httpClient.Personeller.FirstOrDefault(m => m.Id == id);
			if (personel == null)
			{
				return NotFound();
			}

			return View(personel);
		}

		// GET: Personel/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Personel/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,FotografYolu,Ad,Ad2,Soyad,Soyad2,DogumTarihi,TcNo,IseGirisTarihi,IstenCikisTarihi,Aktiflik,MeslekId,DepartmanId,SirketId,Email,Telefon,Maas")] Personel personel)
		{
			if (ModelState.IsValid)
			{
				_httpClient.Add(personel);
				_httpClient.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(personel);
		}

		// GET: Personel/Edit/id
		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var personel = _httpClient.Personeller.Find(id);
			if (personel == null)
			{
				return NotFound();
			}
			return View(personel);
		}

		// POST: Personel/Edit/id
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("Id,FotografYolu,Ad,Ad2,Soyad,Soyad2,DogumTarihi,TcNo,IseGirisTarihi,IstenCikisTarihi,Aktiflik,MeslekId,DepartmanId,SirketId,Email,Telefon,Maas")] Personel personel)
		{
			if (id != personel.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_httpClient.Update(personel);
					_httpClient.SaveChanges();
				}
				catch (Exception)
				{
					if (!PersonelExists(personel.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(personel);
		}

		// GET: Personel/Delete/id
		public IActionResult Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var personel = _httpClient.Personeller.FirstOrDefault(m => m.Id == id);
			if (personel == null)
			{
				return NotFound();
			}

			return View(personel);
		}

		// POST: Personel/Delete/id
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var personel = _db.Personeller.Find(id);
			_httpClient.Personeller.Remove(personel);
			_httpClient.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		private bool PersonelExists(int id)
		{
			return _httpClient.Personeller.Any(e => e.Id == id);
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace HRTech.Controllers
{
	public class PersonelController : Controller
	{
		private readonly HttpClient _httpClient;
		public PersonelController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		//GET PERSONEL BİLGİLERİ

		public async Task<IActionResult> Index()
		{
			return View(await _httpClient.GetFromJsonAsync<List<Personel>>("https://localhost:7063/api/Personeller"));
		}

		// GET: Personel/Details/id
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var response = await _httpClient.GetAsync($"https://localhost:7063/api/Personeller/{id}");
			if (response.IsSuccessStatusCode)
			{
				var personel = await response.Content.ReadFromJsonAsync<Personel>();
				if (personel == null)
				{
					return NotFound();
				}
				return View(personel);
			}
			else
			{
				return NotFound();
			}
		}

		// GET: Personel/Create
		public IActionResult Create()
		{
			return View();
		}

		// GET: Personel/Edit/id
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var response = await _httpClient.GetAsync($"https://localhost:7063/api/Personeller/{id}");
			if (response.IsSuccessStatusCode)
			{
				var personel = await response.Content.ReadFromJsonAsync<Personel>();
				if (personel == null)
				{
					return NotFound();
				}
				return View(personel);
			}
			else
			{
				return NotFound();
			}
		}

		// POST: Personel/Edit/id
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, Personel personel)
		{
			if (id != personel.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				var response = await _httpClient.PutAsJsonAsync($"https://localhost:7063/api/Personeller/{id}", personel);
				if (response.IsSuccessStatusCode)
				{
					return RedirectToAction(nameof(Index));
				}
				else
				{
					return View(personel);
				}
			}
			return View(personel);
		}

		// GET: Personel/Delete/id
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var response = await _httpClient.GetAsync($"https://localhost:7063/api/Personeller/{id}");
			if (response.IsSuccessStatusCode)
			{
				var personel = await response.Content.ReadFromJsonAsync<Personel>();
				if (personel == null)
				{
					return NotFound();
				}
				return View(personel);
			}
			else
			{
				return NotFound();
			}
		}

		// POST: Personel/Delete/id
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var response = await _httpClient.DeleteAsync($"https://localhost:7063/api/Personeller/{id}");
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				return NotFound(); 
			}
		}
	}
}

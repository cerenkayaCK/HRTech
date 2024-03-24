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

    }
}

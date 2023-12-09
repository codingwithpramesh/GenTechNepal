using GenTechNepal.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GenTechNepal.Web.Controllers
{
    public class UserController : Controller
    {

        Uri baseAddress = new Uri("https://localhost:7018/");
        private readonly HttpClient _httpClient;
        public UserController() 
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }

        public async Task<IActionResult> IndexAsync()
        {
            string url = baseAddress + "User/Index";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string JsonResponse = await response.Content.ReadAsStringAsync();

                List<User> users = JsonConvert.DeserializeObject<List<User>>(JsonResponse);
                return View(users);
            }
            return View(new List<User>());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace WebPivotal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Message()
        {
            string domain = "http://localhost:50324/";
            string url = "api/values";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                ViewData["Message"] = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                ViewData["Message"] = "Failed";
            }
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

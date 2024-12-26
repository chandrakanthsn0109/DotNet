using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CoreApiEF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PetMvc.Controllers
{
    public class PetMvcController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<PetAnimal> PetAnimals = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5124/api/PetAnimals");
                var responseTask = client.GetAsync("PetAnimals");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<PetAnimal>>();
                    readTask.Wait();

                    PetAnimals = readTask.Result;
                }
                else
                {
                    PetAnimals = Enumerable.Empty<PetAnimal>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(PetAnimals);
        }


        // GET: PetAnimals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetAnimals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("petId, petName, petType, DOB, isVeg")] PetAnimal petAnimal)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5124/api/PetAnimals");
                    var postTask = client.PostAsJsonAsync("PetAnimals", petAnimal);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Error creating pet animal.");
                    }
                }
            }
            return View(petAnimal);
        }

    }
}

using BMSApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BMSMvc.Controllers
{
    public class BillsController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Bill> Bills = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5174/api/Bills");
                var responseTask = client.GetAsync("Bills");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<Bill>>();
                    readTask.Wait();

                    Bills = readTask.Result;
                }
                else
                {
                    Bills = Enumerable.Empty<Bill>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(Bills);
        }


        // GET: PetAnimals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetAnimals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("billId, customerName, customerPhone, customerEmail, date, amount")] Bill bill)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5174/api/Bills");
                    var postTask = client.PostAsJsonAsync("Bills", bill);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Error creating Bills.");
                    }
                }
            }
            return View(bill);
        }


    }
}

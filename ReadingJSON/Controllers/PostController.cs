using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReadingJSON.Models;
using System.Net.Http;
using System.Threading.Tasks;

public class PostController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PostController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index(int pincode)
    {

        var client = _httpClientFactory.CreateClient();
        string apiUrl = $"http://api.postalpincode.in/pincode/{pincode}"; 

        HttpResponseMessage response = await client.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            var postJson = await response.Content.ReadAsStringAsync();
            var postPinResponseList = JsonConvert.DeserializeObject<List<PostPinResponse>>(postJson);

            return View(postPinResponseList);
        }
        else
        {
            ViewBag.ErrorMessage = "Unable to fetch data from the API.";
            return View(null);
        }
    }

}

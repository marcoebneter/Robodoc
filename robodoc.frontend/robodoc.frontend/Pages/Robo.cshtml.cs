using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace robodoc.frontend.Pages
{
    public class RoboModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiRoboter = "https://localhost:7277/api/Robo";

        public async Task<IActionResult> OnGet()
        {
            await ApiRequest(apiRoboter, new StringContent("startRobo"));
            return Page();
        }

        private Task<HttpResponseMessage> ApiRequest(string url, HttpContent content)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client.PostAsync(url, content);
        }
    }
}

using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace robodoc.frontend.Pages
{
    public class RoboModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiRoboter = "https://localhost:7277/api/Robo";

        public async Task<IActionResult> OnPostStartRobo()
        {
            await ApiRequest(apiRoboter, new StringContent("\"startRobo\"", Encoding.UTF8, "application/json"));
            return Page();
        }

        private Task<HttpResponseMessage> ApiRequest(string url, HttpContent content)
        {
            return client.PostAsync(url, content);
        }
    }
}

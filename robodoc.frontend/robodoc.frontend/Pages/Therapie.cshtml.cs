using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using robodoc.frontend.Models;

namespace robodoc.frontend.Pages
{
    public class TherapieModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiRequest = "https://localhost:44391/api/Therapie";
        public IEnumerable<Therapie>? therapien { get; set; }

        public async Task<IActionResult> OnGet()
        {
            await FillMedikamente();
            return Page();
        }

        private async Task FillMedikamente()
        {
            therapien = JsonSerializer.Deserialize<IEnumerable<Therapie>>(await ApiRequest(apiRequest));
        }

        private Task<string> ApiRequest(string url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client.GetStringAsync(url);
        }
    }
}

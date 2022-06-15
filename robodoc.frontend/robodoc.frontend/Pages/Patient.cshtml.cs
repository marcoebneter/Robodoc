using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using robodoc.frontend.Models;

namespace robodoc.frontend.Pages
{
    public class PatientModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiRequest = "https://localhost:7277/api/Patient";
        public IEnumerable<Patient>? patient { get; set; }
        public async Task<IActionResult> OnGet()
        {
            await FillPatiente();
            return Page();
        }

        private async Task FillPatiente()
        {
            patient = JsonSerializer.Deserialize<IEnumerable<Patient>>(await ApiRequest(apiRequest));
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

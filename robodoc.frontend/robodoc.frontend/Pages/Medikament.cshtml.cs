using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using System.Text.Json;
using robodoc.frontend.Models;

namespace robodoc.frontend.Pages
{
    public class MedikamentModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiRequest = "https://localhost:7277/api/Medikament";
        public IEnumerable<Medikament>? medikament { get; set; }

        public MedikamentModel()
        {
            medikament = new List<Medikament>();
        }

        public async Task<IActionResult> OnGet()
        {
            await FillMedikamente();
            return Page();
        }

        private async Task FillMedikamente()
        {
            medikament = JsonSerializer.Deserialize<IEnumerable<Medikament>>(await ApiRequest(apiRequest));
        }

        private Task<string> ApiRequest(string url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client.GetStringAsync(url);
        }

        public void OnPostUpdate()
        {
            
        }
    }
}

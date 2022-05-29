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
        private const string apiMediRequest = "https://localhost:44391/api/Medikament";
        public IEnumerable<Medikament>? medikament { get; set; }
        public async Task<IActionResult> OnGet()
        {
            await FillMedikamente();
            return Page();
        }

        public IActionResult Add()
        {
            medikament.Append(new Medikament
            {
                id = Guid.NewGuid()
            });
            return Page();
        }

        private async Task FillMedikamente()
        {
            medikament = JsonSerializer.Deserialize<IEnumerable<Medikament>>(await ApiRequest(apiMediRequest));
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

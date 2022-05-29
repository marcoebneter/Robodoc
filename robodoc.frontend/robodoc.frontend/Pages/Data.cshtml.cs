using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using System.Text.Json;

namespace robodoc.frontend.Pages
{
    public class Medikament
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class DataModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiMediIdRequest = "https://localhost:44391/api/Medikament/2513513c-2e8d-41f7-aff6-e453eed9e787";
        [BindProperty]
        public IEnumerable<Medikament>? medikament { get; set; }
        public Medikament medi { get; set; }

        public async Task<IActionResult> OnGet()
        {
            await fillMedi();
            medi = medikament.First();
            return Page();
        }

        public async Task fillMedi()
        {
            medikament = JsonSerializer.Deserialize<IEnumerable<Medikament>>(await ApiRequest(apiMediIdRequest));
        }

        public Task<string> ApiRequest(string url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client.GetStringAsync(url);
        }
    }
}

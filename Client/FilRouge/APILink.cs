using Domain.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FilRouge;

public class APILink
{
    public JsonSerializerOptions options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public HttpClient _httpClient = new();

    public async Task<IEnumerable<Categorie>> CallCatRESTAsync(string url)
    {
        var response = await CallHttpClient(url);

        if (response.IsSuccessStatusCode)
        {
            JsonSerializerOptions options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string jsonText = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<IEnumerable<Categorie>>(jsonText, options);
            if (result != null)
            {
                return result;
            }
        }

        return null;
    }
    public async Task<IEnumerable<Materiel>> callMatRESTAsync(string url)
    {
        var response = await CallHttpClient(url);
        if (response.IsSuccessStatusCode)
        {

            string jsonText = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<IEnumerable<Materiel>>(jsonText, options);
            if (result != null)
            {
                return result;
            }
            else throw new HttpRequestException();
        }
        else return null;
    }

    private async Task<HttpResponseMessage> CallHttpClient(string url)
    {
        HttpResponseMessage response;

        response = await _httpClient.GetAsync(url);



        return response;
    }
}

using Dapper;
using Domain.DTO.Requests;
using Domain.DTO.Responses;
using MySql.Data.MySqlClient;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestIntegration.Fixtures;

public class AbstractIntegrationTest : IClassFixture<APIWebApplicationFactory>
{
    public string line = "";
    public JsonSerializerOptions options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public string requete = "";
    protected readonly HttpClient _client;
    public readonly MySqlConnection _connection = new("Server=lab006.2isa.org;Port=33006;Database=INTEGRATION;UID=root;PWD=9641lab006");
    public AbstractIntegrationTest(APIWebApplicationFactory fixture)
    {
        _client = fixture.CreateClient();
        try
        {
            StreamReader sr = new StreamReader("dump-ticketing&message-202401110911.sql");
            line = sr.ReadLine();
            while (line != null)
            {
                requete += line;
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception " + e.Message);

        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        //Ouvrir connexion à la base de donnée
        //Drop la base de données
        //Fixer la base de données

        _connection.Open();
        _connection.Execute(requete);
    }
    public async Task Login()
    {
        LoginRequest loginRequest = new LoginRequest("Sicard", "82964@1987js");
        var reponse = await _client.PostAsJsonAsync("/api/account/login", loginRequest);
        var AccesToken = (await reponse.Content.ReadFromJsonAsync<LoginResponse>()).AccessToken;

        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccesToken);
    }
    public void Logout()
    {
        _connection.Close();
        _client.DefaultRequestHeaders.Authorization = null;
    }
}


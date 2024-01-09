using Domain.Entities;
using System.Net.Http.Json;
using TestIntegration.Fixtures;

namespace TestIntegration;

public class CategorieControllerTest : AbstractIntegrationTest
{
    public CategorieControllerTest(APIWebApplicationFactory fixture) : base(fixture)
    {
    }

    [Fact]
    public async Task GetAllCateforie_ShouldRetrieve_4_Cat()
    {
        //Arrange
        List<Categorie> expectedCategories = new()
        {
            new Categorie { Id = 15, Label = "Audio" },
            new Categorie { Id = 16, Label = "Poste" },
            new Categorie { Id = 18, Label = "Périphérique d'entré" },
            new Categorie { Id = 19, Label = "Périphérique de sortie" },
        };
        await Login();
        //act 
        var result = await _client.GetFromJsonAsync<List<Categorie>>("/api/categorie/categorie", options);
        //assert
        Assert.Equal(4, result.Count);
        for (int i = 0; i < result.Count; i++)
        {
            Assert.Equal(expectedCategories[i].Id, result[i].Id);
            Assert.Equal(expectedCategories[i].Label, result[i].Label);
        }
        Logout();
    }
}

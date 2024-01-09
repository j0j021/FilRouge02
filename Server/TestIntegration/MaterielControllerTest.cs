using Domain.Entities;
using System.Net.Http.Json;
using TestIntegration.Fixtures;

namespace TestIntegration;

public class MaterielControllerTest : AbstractIntegrationTest
{
    public MaterielControllerTest(APIWebApplicationFactory fixture) : base(fixture)
    {
    }
    [Fact]
    public async Task GetAllMateriel_Should_Retrieve_11_Mat()
    {
        //Arrange
        List<Materiel> expectedMateriel = new()
        {
            new Materiel {Id=1,Nom="Souris",Proprietaire="Sicard"},
            new Materiel {Id=2,Nom="écran",Proprietaire="Sicard"},
            new Materiel {Id=4,Nom="Toshiba",Proprietaire="Sicard"},
            new Materiel {Id=6,Nom="Imprimante",Proprietaire="Sicard"},
            new Materiel {Id=18,Nom="Philips",Proprietaire="Sicard"},
            new Materiel {Id=19,Nom="Toshiba",Proprietaire="Sicard"},
            new Materiel {Id=20,Nom="Imprimante Sharp",Proprietaire="Sicard"},
            new Materiel {Id=21,Nom="Scanner",Proprietaire="Sicard"},
            new Materiel {Id=22,Nom="Acer",Proprietaire="Sicard"},
            new Materiel {Id=24,Nom="Souris",Proprietaire="Sicard"},
            new Materiel {Id=25,Nom="Clavier",Proprietaire="Sicard"}


        };
        await Login();
        var result = await _client.GetFromJsonAsync<List<Materiel>>("/api/materiel/materiel", options);
        //Assert
        Assert.Equal(11, result.Count);
        for (int i = 0; i < result.Count; i++)
        {
            Assert.Equal(expectedMateriel[i].Id, result[i].Id);
            Assert.Equal(expectedMateriel[i].Nom, result[i].Nom);
            Assert.Equal(expectedMateriel[i].Proprietaire, result[i].Proprietaire);
            Logout();
        }

    }
}

using API.Controllers;
using BLL.Interfaces;
using Domain.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TestUnitaire;

public class MaterielUnitTest
{

    [Fact]
    public async void AddMaterielShouldReturnOK()
    {
        //Arrange
        AddMaterielDTORequest materiel = new AddMaterielDTORequest("Casque", 15);
        IMaterielService materielService = Mock.Of<IMaterielService>();
        MaterielController materielController = new MaterielController(materielService);
        //Act
        IActionResult result = await materielController.AddMaterielCategorieAsync(materiel);
        //Assert
        Assert.NotNull(result as OkObjectResult);
    }

}
using API.Controllers;
using BLL.Interfaces;
using Moq;

namespace TestUnitaire;


public class CategorieUnitTest
{
    [Fact]
    public async void DeleteCategorieAsync_With_Bad_Id()
    {
        //Arrange
        ICategorieService categorieService = Mock.Of<ICategorieService>();
        CategorieController categorieController = new CategorieController(categorieService);
        //Act
        var result = await categorieController.DeleteCategorieAsync(It.IsAny<int>());
        //Assert
        Assert.NotNull(result);


    }
}

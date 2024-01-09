using Domain.Entities;
using System.Net.Http.Json;
using TestIntegration.Fixtures;

namespace TestIntegration
{
    public class UserControllerTest : AbstractIntegrationTest
    {
        public UserControllerTest(APIWebApplicationFactory fixture) : base(fixture)
        {
        }
        [Fact]
        public async Task GetAllUser_Should_Retrieve_4_User()
        {
            //Arrange
            List<User> expectedUsers = new()
            {
                new User { Id = 5, Name = "Sicard" },
                new User { Id = 34, Name = "Blanchart" },
                new User { Id = 48, Name = "Gosief" },
                new User { Id = 53, Name = "test" }

            };

            await Login();
            var result = await _client.GetFromJsonAsync<List<User>>("/api/user/user");
            //Assert
            Assert.Equal(4, result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.Equal(expectedUsers[i].Id, result[i].Id);
                Assert.Equal(expectedUsers[i].Name, result[i].Name);
            }
        }
    }
}

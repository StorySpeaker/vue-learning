using System.Threading.Tasks;
using VueLearning.Models.TokenAuth;
using VueLearning.Web.Controllers;
using Shouldly;
using Xunit;

namespace VueLearning.Web.Tests.Controllers
{
    public class HomeController_Tests: VueLearningWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
using System.Threading.Tasks;
using IdeasPrj.Models.TokenAuth;
using IdeasPrj.Web.Controllers;
using Shouldly;
using Xunit;

namespace IdeasPrj.Web.Tests.Controllers
{
    public class HomeController_Tests: IdeasPrjWebTestBase
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
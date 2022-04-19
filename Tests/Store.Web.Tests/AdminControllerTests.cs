using Store.Admin;
using Xunit;

namespace Store.Web.Tests
{
    public class AdminControllerTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(4 == AdminController.AddTwoNumbers(2, 2));
        }
    }
}
using SelfieAWookie.API.UI.Controllers;
using System;
using Xunit;

namespace TestWebApi
{
    public class SelfieControllerUnitTest
    {
        [Fact]
        public void SouldReturnListOfSelfies ()
        {
            //ARRANGE
            var controller =new SelfiesController ();

            //ACT
            var result = controller.TestListe ();

            // ASSERT
            Assert.NotNull (result);
            Assert.True(result.GetEnumerator ().MoveNext ());
        }
    }
}

using System.Net;
using FluentAssertions;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddressController_GetAddress_ShouldReturnData()
        {
            string address = "1";
            address.Should().NotBeNull();
        }

        [Theory]
        [InlineData("Nygade 74 7430 Ikast")]
        public void AddressController_GetAddressBFE_ShouldReturnString(string address)
        {
            address.Should().Be("Nygade 74 7430 Ikast");
        }
    }
}
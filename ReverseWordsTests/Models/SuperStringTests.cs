using ReverseWordsDomain.Models;
using Xunit;

namespace ReverseWordsTests.Models
{
    public class SuperStringTests
    {
        [Fact]
        public void ReverseString_ShouldReturn_StringInReverseOrder()
        {
            var str = "Alice does not even like bob";

            var result = SuperString.ReverseString(str);

            Assert.Equal("bob like even not does Alice", result);
        }
    }
}
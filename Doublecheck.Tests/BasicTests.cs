using FluentAssertions;
using Xunit;

namespace Doublecheck.Tests
{
    public class BasicTests
    {
        [Fact]
        public void First()
        {
            Program.Main(null).Should().Be(123);
        }
    }
}

using FluentAssertions;
using Xunit;

namespace Doublecheck.Tests
{
    public class BasicTests
    {
        [Fact(Skip = "No way yet to use a rule from an add-on assembly")]
        public void RuleIsNotAStaticClass_ReturnsCannotInvokeRule()
        {
            Program.Main(null).Should().Be((int)ExitCode.CannotInvokeRule);
        }
    }
}

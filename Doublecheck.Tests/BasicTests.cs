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

        [Fact]
        public void Foo()
        {
            string yaml = @"
rules:
  '*':
    - MustNotContainSpaces
  '*.cs':
    - RuleOne
    - RuleTwo
  '*.sln':
    - RuleTwo
    - RuleThree
";
            Program.Main(new[] { yaml });
        }

        [Fact]
        public void ResolveFiles()
        {
             string yaml = @"
rules:
  '*.dll':
    - RuleOne
";
            Program.Main(new[] { yaml });

        }
    }
}

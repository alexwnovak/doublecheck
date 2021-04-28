using Doublecheck.Tests.Internal;
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
  file.txt:
    - RuleOne
";

            var textFileContents = new[]
            {
              "line one",
              "line two",
              "line three"
            };

            var fileSystem = new InMemoryFileSystem();
            fileSystem.WriteAllLines("file.txt", textFileContents);

            var appController = new AppController(fileSystem);
            appController.Run(new[] { yaml });

        }
    }
}

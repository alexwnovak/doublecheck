using Doublecheck.Engine;

namespace Doublecheck
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var ruleBinder = new RuleBinder();
            var exitCode = ExitCode.Success;

            try
            {
                ruleBinder.InvokeRule("MustNotContainSpaces");
            }
            catch (RuleEngineException ex)
            {
                exitCode = ex.ExitCode;
            }

            return (int) exitCode;
        }
    }
}

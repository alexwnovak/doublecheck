namespace Doublecheck
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var ruleBinder = new RuleBinder();
            ruleBinder.InvokeRule("MustNotContainSpaces");

            return 123;
        }
    }
}

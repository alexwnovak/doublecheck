using System;

namespace Doublecheck.Rules
{
    public static class MustNotContainSpaces
    {
        public static string[] SupportedTypes { get; } = new[] { "*" };

        public static void Invoke(string[] files)
        {
            Console.WriteLine("Invoking MustNotContainSpaces");

            foreach (string file in files)
            {
                Console.WriteLine( $"-- {file}");
            }
        }
    }
}

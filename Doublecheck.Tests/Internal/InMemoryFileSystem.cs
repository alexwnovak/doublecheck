namespace Doublecheck.Tests.Internal
{
    internal class InMemoryFileSystem : IFileSystem
    {
        public string[] GetFiles(string path, string searchPattern)
        {
            return new string[0];
        }
    }
}
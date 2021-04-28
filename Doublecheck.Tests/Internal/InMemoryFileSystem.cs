using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Doublecheck.Tests.Internal
{
    internal class InMemoryFileSystem : IFileSystem
    {
        private readonly Dictionary<string, string[]> _fileTable = new();

        public string[] GetFiles(string path, string searchPattern)
        {
            var files = new List<string>();
            var regex = new Regex(path);

            foreach (var kvp in _fileTable)
            {
                bool matches = regex.IsMatch(kvp.Key);

                if (matches)
                {
                    files.Add(kvp.Key);
                }
            }

            return files.ToArray();
        }

        public void WriteAllLines(string path, string[] contents)
        {
            _fileTable[path] = contents;
        }
    }
}
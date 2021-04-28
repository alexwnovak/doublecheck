using System.IO;

namespace Doublecheck
{
    public class FileSystem : IFileSystem
    {
        public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);

        public void WriteAllLines(string path, string[] contents) => File.WriteAllLines(path, contents);
    }
}

using System.IO;

namespace Doublecheck
{
    public class FileSystem : IFileSystem
    {
        public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);
    }
}

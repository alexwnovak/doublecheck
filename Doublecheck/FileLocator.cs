using System.Collections.Generic;
using System.IO;
using System.Linq;
using Doublecheck.Model;

namespace Doublecheck
{
    public class FileLocator
    {
        private readonly IFileSystem _fileSystem;

        public FileLocator(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public IEnumerable<string> Gather(YamlConfig configuration)
        {
            var files = new List<string>();

            foreach (var kvp in configuration.Rules)
            {
                var theseFiles = _fileSystem.GetFiles(".", kvp.Key).Select(f => Path.GetFullPath(f));
                files.AddRange(theseFiles);
            }

            return files;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Doublecheck.Model;

namespace Doublecheck
{
    public static class FileLocator
    {
        public static IEnumerable<string> Gather(YamlConfig configuration)
        {
            var files = new List<string>();

            foreach (var kvp in configuration.Rules)
            {
                var theseFiles = Directory.GetFiles(".", kvp.Key).Select(f => Path.GetFullPath(f));
                files.AddRange(theseFiles);
            }

            return files;
        }
    }
}

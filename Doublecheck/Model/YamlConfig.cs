using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Doublecheck.Model
{
    public class YamlRule
    {
        // public string FilePattern { get; set; }
        // public List<string> Rules { get; set; }
    }
    public class YamlConfig
    {
        // public List<YamlRule> Rules { get; set; }
        public Dictionary<string, List<string>> Rules { get; set; }
    }
}
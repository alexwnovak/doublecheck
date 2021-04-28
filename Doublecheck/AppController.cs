using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Doublecheck.Engine;
using Doublecheck.Model;

namespace Doublecheck
{
    public class AppController
    {
        public int Run(string[] args)
        {
            // While we stand up Yaml support, just assume arg0 IS the raw yaml.
            // Obviously this doesn't fly forever!
            string yaml = args[0];

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(UnderscoredNamingConvention.Instance)
                .Build();
            var yamlConfig = deserializer.Deserialize<YamlConfig>(yaml);

            var files = FileLocator.Gather(yamlConfig);


            var ruleBinder = new RuleBinder();
            var exitCode = ExitCode.Success;

            try
            {
                var ruleCallSite = ruleBinder.Locate("MustNotContainSpaces");
                ruleCallSite.Invoke();
            }
            catch (RuleEngineException ex)
            {
                exitCode = ex.ExitCode;
            }

            return (int)exitCode;
        }
    }
}
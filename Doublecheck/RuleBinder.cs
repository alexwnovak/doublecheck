using System.Linq;
using System.Reflection;

namespace Doublecheck
{
    public class RuleBinder
    {
        public RuleCallSite Locate(string name)
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            var ruleType = thisAssembly.GetExportedTypes().First(t => t.Name == name);
            var invokeMethod = ruleType.GetMethod("Invoke");

            return new RuleCallSite(() => invokeMethod.Invoke(null, null));
        }
    }
}

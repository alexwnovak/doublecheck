using System.Linq;
using System.Reflection;

namespace Doublecheck
{
    public class RuleBinder
    {
        public void InvokeRule(string name)
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            var ruleType = thisAssembly.GetExportedTypes().First(t => t.Name == name);
            var invokeMethod = ruleType.GetMethod("Invoke");
            invokeMethod.Invoke(null, null);
        }
    }
}

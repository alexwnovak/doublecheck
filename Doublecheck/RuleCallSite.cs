using System;

namespace Doublecheck
{
    public class RuleCallSite
    {
        private readonly Action _invocation;

        public RuleCallSite(Action invocation)
        {
            _invocation = invocation;
        }

        public void Invoke()
        {
            _invocation();
        }
    }
}

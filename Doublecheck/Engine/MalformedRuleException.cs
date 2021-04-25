using System;
using System.Runtime.Serialization;

namespace Doublecheck.Engine
{
    public class MalformedRuleException : RuleEngineException
    {
        public override ExitCode ExitCode => ExitCode.CannotInvokeRule;

        public MalformedRuleException() { }
        public MalformedRuleException(string message) : base(message) { }
        public MalformedRuleException(string message, Exception inner) : base(message, inner) { }
        public MalformedRuleException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
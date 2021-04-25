using System;
using System.Runtime.Serialization;

namespace Doublecheck.Engine
{
    public abstract class RuleEngineException : Exception
    {
        public abstract ExitCode ExitCode { get; }

        public RuleEngineException() { }
        public RuleEngineException(string message) : base(message) { }
        public RuleEngineException(string message, Exception inner) : base(message, inner) { }
        protected RuleEngineException( SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
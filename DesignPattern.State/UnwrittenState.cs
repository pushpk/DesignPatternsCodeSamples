using System;
using System.Collections.Generic;

namespace DesignPattern.State
{
    public class UnwrittenState : IPolicyStateCommands
    {
        private Policy _policy;

        public UnwrittenState(Policy policy)
        {
            this._policy = policy;
        }

        public void Cancel() => throw new InvalidOperationException("Cannot cancel a policy before it's been Opened.");

        public void Close(DateTime closedDate) => throw new InvalidOperationException("Cannot close a policy before it's been Opened.");

        public void Open(DateTime? writtenDate = null)
        {
            _policy.State = _policy.OpenState;
            
        }

        public void Update() => throw new InvalidOperationException("Cannot update a policy before it's been Opened.");

        public void Void()
        {
            _policy.State = _policy.VoidState;
        }

        public List<string> ListValidOperations()
        {
            return new List<string> { "Open", "Void" };
        }

    }
}
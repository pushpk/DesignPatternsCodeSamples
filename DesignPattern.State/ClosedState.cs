using System;
using System.Collections.Generic;

namespace DesignPattern.State
{
    public class ClosedState : IPolicyStateCommands
    {
        private readonly Policy _policy;

        public ClosedState(Policy policy)
        {
            this._policy = policy;
        }

        public void Cancel()
        {
            _policy.State = _policy.CancelledState;
        }
        
        public void Close(DateTime closedDate) => throw new InvalidOperationException("Cannot close a policy that is already closed.");

        public void Open(DateTime? writtenDate = null)
        {
            _policy.State = _policy.OpenState;
        }

        public void Update() => throw new InvalidOperationException("Cannot update a policy that is closed.");

        public void Void() => throw new InvalidOperationException("Cannot void a policy that is closed.");

        public List<string> ListValidOperations()
        {
            return new List<string> { "Cancel", "Open" };
        }
    }
}
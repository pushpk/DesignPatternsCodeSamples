using System;
using System.Collections.Generic;

namespace DesignPattern.State
{
    public class OpenState : IPolicyStateCommands
    {
        private Policy _policy;

        public OpenState(Policy policy)
        {
            this._policy = policy;
        }



        public void Cancel()
        {
            _policy.State = _policy.CancelledState;
        }

        public void Close(DateTime closedDate)
        {
            _policy.State = _policy.ClosedState;
            
        }

        public void Open(DateTime? writtenDate = null) => throw new InvalidOperationException("Cannot open a policy that is already open.");

        public void Update()
        {
            // TODO: Add update logic
        }

        public void Void()
        {
            _policy.State = _policy.VoidState;
        }

        public List<string> ListValidOperations()
        {
            return new List<string> { "Cancel", "Close", "Update", "Void" };
        }
    }
}
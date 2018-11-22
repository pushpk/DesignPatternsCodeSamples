using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class Policy : IPolicyState
    {
        private CancelledState _cancelledState;
        private ClosedState _closedState;
        private OpenState _openState;
        private UnwrittenState _unwrittenState;
        private VoidState _voidState;

        public IPolicyStateCommands State { get;  set; }
        public CancelledState CancelledState { get => _cancelledState; set => _cancelledState = value; }
        public ClosedState ClosedState { get => _closedState; set => _closedState = value; }
        public OpenState OpenState { get => _openState; set => _openState = value; }
        public UnwrittenState UnwrittenState { get => _unwrittenState; set => _unwrittenState = value; }
        public VoidState VoidState { get => _voidState; set => _voidState = value; }

        public string Number { get; set; }

        public Policy()
        {
            CancelledState = new CancelledState(this);
            ClosedState = new ClosedState(this);
            OpenState = new OpenState(this);
            UnwrittenState = new UnwrittenState(this);
            VoidState = new VoidState(this);

        }
        public Policy(string policyNumber) : this()
        {
            Number = policyNumber;
        }

        public void Cancel()
        {
            State.Cancel();
        }

        public void Close(DateTime closedDate)
        {
            State.Close(closedDate);
        }

        public void Open(DateTime? writtenDate = null)
        {
            State.Open();
        }

        public void Update()
        {
            State.Update();
        }

        public void Void()
        {
            State.Void();
        }
    }
}

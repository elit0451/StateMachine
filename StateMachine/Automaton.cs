using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateMachine
{
    internal class Automaton
    {
        private State _currentState;
        private string _systemId;
        private string _instanceId;
        private Timer _timer;

        public Automaton(State currentState, string systemId, string instanceId)
        {
            _currentState = currentState;
            _systemId = systemId;
            _instanceId = instanceId;
            _timer = new Timer();

            _timer.Elapsed += new ElapsedEventHandler(ExpireSession);
            _timer.Interval = 10000;
            // Enable timer and stop it right away
            _timer.Enabled = true;
            _timer.Stop();
        }

        private void ExpireSession(object sender, ElapsedEventArgs e)
        {
            _currentState.Expired(_currentState.ToString(), _systemId, _instanceId);
            _timer.Stop();
        }

        public bool ChangeState(string newState)
        {
            State nextState = _currentState.ChangeState(newState, _systemId, _instanceId);
            if (nextState is null)
                return false;

            // Reset timer
            _timer.Stop();
            _timer.Start();
            _currentState = nextState;
            return true;

        }
    }
}

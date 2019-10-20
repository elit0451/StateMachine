using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    public class State
    {
        private string _name;
        private Dictionary<string, State> _acceptedStates;

        public State(string name)
        {
            _name = name;
            _acceptedStates = new Dictionary<string, State>();
        }

        public State ChangeState(string newState, string systemId, string instanceId)
        {
            State nextState = null;

            if (_acceptedStates.ContainsKey(newState))
            {
                nextState = _acceptedStates[newState];
                Logger.Log(LogLevel.Information, systemId, instanceId, newState, DateTime.Now);
            }
            else
                Logger.Log(LogLevel.Error, systemId, instanceId, newState, DateTime.Now);

            return nextState;
        }

        public void AddState(string stateName, State state)
        {
            _acceptedStates.Add(stateName, state);
        }

        public void Expired(string state, string systemId, string instanceId)
        {
            Logger.Log(LogLevel.Warning, systemId, instanceId, state, DateTime.Now);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}

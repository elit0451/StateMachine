using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateMachine
{
    internal static class AutomatonBuilder
    {
        public static Automaton Build(string filePath, string systemId, string instanceId)
        {
            Dictionary<string, State> states = new Dictionary<string, State>();
            State initialState = null;
            string line;

            using(StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string actionFrom = line.Substring(0, line.IndexOf('-')).ToLower();
                    string actionTo = line.Substring(line.IndexOf('-') + 1);

                    if (!states.ContainsKey(actionFrom))
                    {
                        State state = new State(actionFrom);
                        states.Add(actionFrom, state);

                        if (states.Count == 1)
                            initialState = state;
                    }

                    if (!states.ContainsKey(actionTo))
                    {
                        State state = new State(actionTo);
                        states.Add(actionTo, state);
                    }
                    
                    states[actionFrom].AddState(actionTo, states[actionTo]);
                }
            }
            return new Automaton(initialState, systemId, instanceId);
        }
    }
}

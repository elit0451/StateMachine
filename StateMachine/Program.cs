using System;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadKey();
        }

        private void Run()
        {
            Automaton automaton = AutomatonBuilder.Build(@"StateMachine\StateMachine\bin\Debug\stateList.txt", Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

            Action(automaton, "login");
            Action(automaton, "edit");
            Action(automaton, "login");

            Console.ReadKey();
            Console.WriteLine("Done here");
        }

        private void Action(Automaton automaton, string action)
        {
            automaton.ChangeState(action);
        }
    }
}

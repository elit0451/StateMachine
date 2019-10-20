using System;
using System.IO;
using System.Text;

namespace StateMachine
{
    public enum LogLevel
    {
        Information,
        Warning,
        Error
    }
    internal static class Logger
    {
        public static void Log(LogLevel level, string systemId, string instanceId, string actionId, DateTime timestamp)
        {
            StringBuilder log = new StringBuilder();
            log.AppendLine("Level - " + level.ToString());
            log.AppendLine("System - " + systemId);
            log.AppendLine("Instance - " + instanceId);
            log.AppendLine("Action - " + actionId);
            log.AppendLine("TimeStamp - " + timestamp.ToString());
            log.AppendLine("\n-------------------------------\n");

            using (FileStream file = File.Open(@"C:\Users\elitsa\source\repos\StateMachine\StateMachine\bin\Debug\log.txt", FileMode.Append))
            {
                using (StreamWriter fileWriter = new StreamWriter(file))
                    fileWriter.WriteLine(log.ToString());
            }
        }
    }
}
using System;

namespace Patterns.Structural
{
    /// <summary>
    /// The new system in works
    /// </summary>
    public class MyNewSystem
    {
        private readonly ILogger logger;
        public MyNewSystem(ILogger loggerInst)
        {
            logger = loggerInst;
        }
        public void Dowork()
        {
            logger.logMessage("I am doing work and logging using output adapter");
        }
    }

    /// <summary>
    /// The interface that is used by the new system
    /// </summary>
    public interface ILogger
    {
        public void logMessage(string message);
    }

    /// <summary>
    /// Some class that does not implement the interface in the system
    /// </summary>
    public class Outputter
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }

    /// <summary>
    /// Adpater that adapts the class from old system to the new system
    /// </summary>
    public class OutputterAdapter : ILogger
    {
        Outputter outputter = new Outputter();
        public void logMessage(string message)
        {
            outputter.WriteOutput(message);
        }
    }
}
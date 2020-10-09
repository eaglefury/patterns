using System;

namespace Patterns.Structural
{
    public abstract class Worker
    {
        public string name;
        public abstract void DoWork();
    }

    public class JuniorWorker : Worker
    {
        public override void DoWork()
        {
            Console.WriteLine("I will do junior work");
        }
    }

    public class SeniorWorker : Worker
    {
        public SeniorWorker(Worker otherWorker)
        {
            otherWorker.DoWork();
        }

        public override void DoWork()
        {
            Console.WriteLine("I will do senior work");
        }
    }
}
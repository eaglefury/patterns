using System;
using Patterns.Structural;
using Patterns.Creational;
using Patterns.Behavioral;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- using factory ------------");
            var studentFactory = new StudentFactory();
            var student = studentFactory.CreateStudent("special");
            var student2 = studentFactory.CreateStudent("normal");
            Console.WriteLine(student.Speak());
            Console.WriteLine(student2.Speak());

            Console.WriteLine("------------- using decorator ----------");
            var juniorWorker = new JuniorWorker();
            juniorWorker.DoWork();
            var seniorWorker = new SeniorWorker(juniorWorker);
            seniorWorker.DoWork();

            Console.WriteLine("-------------- Using singleton -------------");
            // instance will be same when used from anywhere
            GlobalObject global = GlobalObject.GetInstance();
            global.myGlobalList.ForEach(x => Console.WriteLine(x));
            global.myGlobalList.Add("Gaurav");
            global.myGlobalList.Add("Kapoor");
            global.myGlobalList.ForEach(x => Console.WriteLine(x));


            Console.WriteLine("---------------Using Adapter ---------------");
            ILogger outputLogger = new OutputterAdapter();
            var newSystem = new MyNewSystem(outputLogger);
            newSystem.Dowork();

            Console.WriteLine("----------------Using Template method -------------");
            Car myCar = new BMW();
            myCar.GetReadyAndDrive();


            Console.WriteLine("----------------Using Observer  -------------");
            Score myScore = new Score();
            myScore.AddObserver(new ScoreObserver());
            myScore.AddObserver(new SuperScoreObserver());
            myScore.Add(5);
            myScore.Subtract(3);
        }
    }
}

using System;
namespace Patterns.Creational
{
    public abstract class Car
    {
        protected abstract void Drive();

        public void Ready()
        {
            Console.WriteLine("The vehicle is ready");
        }
        public void GetReadyAndDrive()
        {
            Ready();
            Drive();
        }
    }


    /// <summary>
    /// The call to drive gets made from the base class
    /// </summary>
    public class BMW : Car
    {
        protected override void Drive()
        {
            Console.WriteLine("I am driving a BMW");
        }
    }
}
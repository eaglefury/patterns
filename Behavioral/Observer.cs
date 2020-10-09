using System.Collections.Generic;
using System;

namespace Patterns.Behavioral
{
    public interface IUpdate
    {
        public void Update(object sender, int score);
    }
    public class Score
    {
        private List<IUpdate> observers = new List<IUpdate>();

        public void AddObserver(IUpdate observer)
        {
            observers.Add(observer);
        }

        private void Notify(int score)
        {
            foreach (var observer in observers)
            {
                observer.Update(this, score);
            }
        }

        private static int score = 0;
        public void Add(int scoreToAdd)
        {
            score += scoreToAdd;
            this.Notify(score);
        }
        public void Subtract(int scoreToSubtract)
        {
            score -= scoreToSubtract;
            this.Notify(score);
        }
    }
    public class ScoreObserver : IUpdate
    {
        public void Update(object sender, int score)
        {
            Console.WriteLine($" Observer : Score changed : {score}");
        }
    }

    public class SuperScoreObserver : IUpdate
    {
        public void Update(object sender, int score)
        {
            Console.WriteLine($" Super Observer : Score changed : {score}");
        }
    }
}
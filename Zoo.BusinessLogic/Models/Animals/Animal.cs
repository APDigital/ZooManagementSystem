using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private readonly DateTime dateOfBirth;
        private DateTime lastFed;
        private DateTime lastGroomed;
        private bool CanBeGroomed;

        protected Animal(DateTime dateOfBirth, bool canBeGroomed)
        {
            this.dateOfBirth = dateOfBirth;
            this.CanBeGroomed = canBeGroomed;
        }

        public TimeSpan Age
        {
            get { return DateTime.Today - dateOfBirth; }
        }

        public DateTime LastFed
        {
            get { return lastFed; }
        }
        public virtual void Groom()
        {
            if (CanBeGroomed == true)
            {
                lastGroomed = DateTime.Now;
            }

        }

        public virtual void Feed()
        {
            lastFed = DateTime.Now;
        }

        public bool IsHungry()
        {
            // Obviously an animal wouldn't get hungry in a matter of seconds. 
            // But it means we can see activity in real time when we run the code...
            return (DateTime.Now - lastFed).TotalSeconds > Config.FeedingFrequency;
        }

        public override string ToString()
        {
            string result;
            if (CanBeGroomed == true)
            {
                result = $"{GetType().Name}, last fed {lastFed}\n{GetType().Name}, last groomed {lastGroomed}";
            }
            else
            {
                result = $"{GetType().Name}, last fed {lastFed}";
            }
            return result;

        }
    }
}
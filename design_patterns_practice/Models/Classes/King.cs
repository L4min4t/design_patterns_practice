﻿namespace design_patterns_practice.Models.Classes
{
    public class King : IObservable
    {
        private List<Knight> _knights = new List<Knight>();

        public AttakState AttakState {
            get => AttakState;
            private set
            {
                AttakState = value;
                Notify();
            } 
        }

        public void CommandLineUp() => AttakState = AttakState.LineUp;
        public void CommandPrepare() => AttakState = AttakState.Prepare;
        public void CommandAttak() => AttakState = AttakState.Attak;

        public void Attach(IObserver observer)
        {
            if (observer is Knight knight)
            {
                _knights.Add(knight);
            }
            else
            {
                throw new ArgumentException("Observer must be Knight");
            }

        }

        public void Detach(IObserver observer)
        {
            if (observer is Knight knight)
            {
                _knights.Remove(knight);
            }
            else
            {
                throw new ArgumentException("Observer must be Knight");
            }
        }

        public void Notify()
        {
            foreach (var knight in _knights)
            {
                knight.Update(this);
            }
        }
    }
}

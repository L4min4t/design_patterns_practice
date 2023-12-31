﻿using design_patterns_practice.Models.Interfaces.Observer;

namespace design_patterns_practice.Models.Classes.Observer
{
    public class Knight : IObserver
    {
        public AttackState State { get; set; }
        public void Update(IObservable subject)
        {
            if (subject is King king)
            {
                State = king.AttakState;
            }
            else
            {
                throw new ArgumentException("Subject must be King");
            }
        }
    }
}

namespace design_patterns_practice.Models.Classes
{
    public class Knight : IObserver
    {
        public AttakState State { get; set; }
        public void Update(IObservable subject)
        {
            if(subject is King king)
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

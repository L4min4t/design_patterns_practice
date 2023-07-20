namespace design_patterns_practice.Models.Interfaces
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();

    }
}

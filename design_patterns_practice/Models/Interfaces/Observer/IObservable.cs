namespace design_patterns_practice.Models.Interfaces.Observer
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();

    }
}

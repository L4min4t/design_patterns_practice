namespace design_patterns_practice.Models.Interfaces.Observer
{
    public interface IObserver
    {
        void Update(IObservable subject);
    }
}

namespace design_patterns_practice.Models.Interfaces
{
    public interface IObserver
    {
        void Update(IObservable subject);
    }
}

namespace design_patterns_practice.Models.Classes.Strategy
{
    public class Iceelement : INatureElement
    {
        public string Name { get => GetType().Name; }
        public string Attaсk()
        {
            return "ice attack";
        }

    }
}

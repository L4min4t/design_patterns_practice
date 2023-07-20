namespace design_patterns_practice.Models.Classes
{
    public class ThunderElement : INatureElement
    {
        public string Name { get => GetType().Name; }
        public string Attaсk()
        {
            return "thunder attack";
        }
    }
}

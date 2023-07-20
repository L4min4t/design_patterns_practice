namespace design_patterns_practice.Models.Classes
{
    public class Iceelement : INatureElement
    {
        public string Attaсk()
        {
            return "ice attack";
        }

        public string GetName()
        {
            return GetType().Name;
        }
    }
}

namespace design_patterns_practice.Models.Classes
{
    public class ThunderElement : INatureElement
    {
        public string Attaсk()
        {
            return "thunder attack";
        }

        public string GetName()
        {
            return GetType().Name;
        }
    }
}

namespace design_patterns_practice.Models.Classes.Strategy
{
    public class Sword : ISword
    {
        private INatureElement _natureElement;

        public Sword(INatureElement element) => _natureElement = element;

        public void SetNaturElement(INatureElement element) => _natureElement = element;

        public string GetNameOfElement()
        {
            return _natureElement.Name;
        }

        public void CommonAttack()
        {
            Console.WriteLine("Sword makes common atack");
        }

        public void MagicAttack()
        {
            Console.WriteLine("Sword makes " + _natureElement.Attaсk());
        }
    }
}

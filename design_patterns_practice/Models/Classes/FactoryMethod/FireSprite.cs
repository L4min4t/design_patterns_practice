namespace design_patterns_practice.Models.Classes.FactoryMethod
{
    public class FireSprite : IMagicCreature
    {
        public string Name { get => GetType().Name; }
    }
}

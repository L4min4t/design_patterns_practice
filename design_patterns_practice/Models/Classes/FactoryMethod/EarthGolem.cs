namespace design_patterns_practice.Models.Classes.FactoryMethod
{
    public class EarthGolem : IMagicCreature
    {
        public string Name { get => GetType().Name; }
    }
}

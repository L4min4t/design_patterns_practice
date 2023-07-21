namespace design_patterns_practice.Models.Classes.FactoryMethod
{
    internal class WaterNymph : IMagicCreature
    {
        public string Name { get => GetType().Name; }
    }
}

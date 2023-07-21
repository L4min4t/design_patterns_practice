using System;
using System.Linq;
using System.Reflection;

namespace design_patterns_practice.Models.Classes.FactoryMethod
{
    public class Mage
    {
        public IMagicCreature GetCreature()
        {
            var inheritedClasses = GetInheritedClasses(typeof(IMagicCreature));
            Random random = new Random();
            int randomIndex = random.Next(inheritedClasses.Length);
            Type randomClassType = inheritedClasses[randomIndex];
            return (IMagicCreature)Activator.CreateInstance(randomClassType);
        }


        private Type[] GetInheritedClasses(Type interfaceType)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
                .ToArray();
        }
    }
}

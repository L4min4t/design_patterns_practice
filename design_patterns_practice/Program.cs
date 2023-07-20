namespace design_patterns_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fire = new FireElement();
            var ice = new Iceelement();
            var thunder = new ThunderElement();
            var sword = new Sword(ice);
            sword.MagicAttack();
            sword.SetNaturElement(fire);
            sword.MagicAttack();
        }
    }
}
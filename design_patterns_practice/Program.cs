namespace design_patterns_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // strategy test
            //var fire = new FireElement();
            //var ice = new Iceelement();
            //var thunder = new ThunderElement();
            //var sword = new Sword(ice);
            //sword.MagicAttack();
            //sword.SetNaturElement(fire);
            //sword.MagicAttack();

            // adapter test
            DwarvesArmy dwarves = new DwarvesArmy();
            ElvesArmy elves = new ElvesArmy();

            for(int i = 0; i < 3; i++) 
            {
                dwarves.dwarves.Add(new Dwarf());
            }

            for (int i = 0; i < 2; i++)
            {
                elves.elves.Add(new Elf());
            }

            MoleMail mole = new MoleMail();
            OwlMail owl = new OwlMail();
            
        }
    }
}
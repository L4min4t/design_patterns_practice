namespace design_patterns_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// singletone test
            //var book1 = SpellBookSingletone.GetInstance();
            //var book2 = SpellBookSingletone.GetInstance();
            //var book3 = new SpellBook();
            //Console.WriteLine(book1 == book2);
            //Console.WriteLine(book2 == book3);



            //// strategy test
            //var fire = new FireElement();
            //var ice = new Iceelement();
            //var thunder = new ThunderElement();
            //var sword = new Sword(ice);
            //sword.MagicAttack();
            //sword.SetNaturElement(fire);
            //sword.MagicAttack();



            //// adapter test
            //Dwarf dwarf = new Dwarf();
            //Elf elf = new Elf();
            //MoleMail mole = new MoleMail();
            //OwlMail owl = new OwlMail();

            //elf.SendMessage(owl, 222);
            //MoleToOwlAdaper adapter = new MoleToOwlAdaper(owl);
            //dwarf.GetMessage(adapter);



            //// factory method test
            //var mage = new Mage();
            //var creature = mage.GetCreature();

            //Console.WriteLine(creature.Name);
            //Console.WriteLine(creature.GetType());
        }
    }
}
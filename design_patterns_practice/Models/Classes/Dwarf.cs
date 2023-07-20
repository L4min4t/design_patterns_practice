namespace design_patterns_practice.Models.Classes
{
    public class Dwarf
    {
        public new void SendMessage(MoleMail mole, string message) => mole.SendMessage(message);

        public new void GetMessage(MoleMail mole) => Console.WriteLine(mole.GetMessage());
    }
}

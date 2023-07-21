namespace design_patterns_practice.Models.Classes.Adapter
{
    public class Dwarf
    {
        public void SendMessage(MoleMail mole, string message) => mole.SendMessage(message);

        public void GetMessage(MoleMail mole) => Console.WriteLine(mole.GetMessage());
    }
}

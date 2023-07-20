using System.Threading.Channels;

namespace design_patterns_practice.Models.Classes
{
    public class Elf
    {
        public new void SendMessage(OwlMail owl, string message) => owl.SendMessage(message);

        public new void GetMessage(OwlMail owl) => Console.WriteLine(owl.GetMessage());
    }
}

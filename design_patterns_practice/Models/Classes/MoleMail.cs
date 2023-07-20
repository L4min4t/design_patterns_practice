namespace design_patterns_practice.Models.Classes
{
    public class MoleMail
    {
        private string _currentMessage = "no message";
        public void SendMessage(string message)
        {
            _currentMessage = message;
            Console.WriteLine($"Darve sendes by Mole message: {message}");
        }

        public string GetMessage() => _currentMessage;
    }
}

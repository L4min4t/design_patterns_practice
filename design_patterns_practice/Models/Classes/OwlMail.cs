namespace design_patterns_practice.Models.Classes
{
    public class OwlMail
    {
        private string _currentMessage = "no message";
        public void SendMessage(string message)
        {
            _currentMessage = message;
            Console.WriteLine($"Elf sendes by Owl message: {message}");
        }

        public string GetMessage() => _currentMessage;
    }
}

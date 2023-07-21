namespace design_patterns_practice.Models.Classes
{
    public class OwlMail
    {
        private int _currentMessage = 101;
        public void SendMessage(int message)
        {
            _currentMessage = message;
            Console.WriteLine($"Elf sends by Owl message: {message}");
        }

        public int GetMessage() => _currentMessage;
    }
}

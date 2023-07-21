namespace design_patterns_practice.Models.Classes.Adapter
{
    public class OwlMail
    {
        private  int _currentMessage = 101;
        public virtual void SendMessage(int message)
        {
            _currentMessage = message;
            Console.WriteLine($"Elf sends by Owl message: {message}");
        }

        public virtual int GetMessage() => _currentMessage;
    }
}

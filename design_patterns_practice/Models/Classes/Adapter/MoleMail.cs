namespace design_patterns_practice.Models.Classes.Adapter
{
    public class MoleMail
    {
        private string _currentMessage = "no message";
        public virtual void SendMessage(string message)
        {
            _currentMessage = message;
            Console.WriteLine($"Darve sends by Mole message: {message}");
        }

        public virtual string GetMessage() => _currentMessage;
    }
}

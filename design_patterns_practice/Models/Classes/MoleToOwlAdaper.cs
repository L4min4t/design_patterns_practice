namespace design_patterns_practice.Models.Classes
{
    public class MoleToOwlAdaper : MoleMail
    {
        private OwlMail _owl;

        public MoleToOwlAdaper(OwlMail owl)
        {
            _owl = owl;
        }

        public override void SendMessage(string  message)
        {
            _owl.SendMessage(Convert.ToInt32(message));
        }

        public override string GetMessage()
        {
            return _owl.GetMessage().ToString();
        }

    }
}

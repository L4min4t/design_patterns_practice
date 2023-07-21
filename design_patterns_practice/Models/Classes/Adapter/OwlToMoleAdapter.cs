namespace design_patterns_practice.Models.Classes.Adapter
{
    public class OwlToMoleAdapter : OwlMail
    {
        private MoleMail _mole;

        public OwlToMoleAdapter(MoleMail mole)
        {
            _mole = mole;
        }

        public override void SendMessage(int message)
        {
            _mole.SendMessage(message.ToString());
        }

        public override int GetMessage()
        {
            return Convert.ToInt32(_mole.GetMessage());
        }

    }
}

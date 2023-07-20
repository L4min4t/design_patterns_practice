namespace design_patterns_practice.Models.Classes
{
    public static class SpellBookSingletone
    {
        private static SpellBook _spellBook;
        private static object _syncObj = new object();

        public static SpellBook GetInstance()
        {
            if (_spellBook == null)
            {
                lock (_syncObj)
                {
                    if (_spellBook == null)
                    {
                        _spellBook = new SpellBook();
                    }  
                }
            }

            return _spellBook;
        }

    }
}

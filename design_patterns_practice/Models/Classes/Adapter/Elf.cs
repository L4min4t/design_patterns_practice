﻿namespace design_patterns_practice.Models.Classes.Adapter
{
    public class Elf
    {
        public void SendMessage(OwlMail owl, int message) => owl.SendMessage(message);

        public void GetMessage(OwlMail owl) => Console.WriteLine(owl.GetMessage());
    }
}

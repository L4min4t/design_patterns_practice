﻿namespace design_patterns_practice.Models.Classes
{
    public class FireElement : INatureElement
    {
        public string Name { get => GetType().Name; }

        public string Attaсk()
        {
            return "fire attack";
        }
    }
}

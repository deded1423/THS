﻿using System.Collections.Generic;

namespace THS.HSApp
{
    public class HSPlayer
    {
        public List<HSCard> Hand { get; set; }
        public List<HSCard> Graveyard { get; set; }
        public List<HSCard> Deck { get; set; }
        Dictionary<string, int> _tagsGE = new Dictionary<string, int>();

        public HSPlayer()
        {
            Hand = new List<HSCard>();
            Graveyard = new List<HSCard>();
            Deck = new List<HSCard>();
        }
    }
}

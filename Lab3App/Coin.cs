using System;
using System.Collections.Generic;

namespace Lab3App
{

    public class Coin : Treasure
    {
        public int getValue { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            getValue = value;
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list); 
            UpdateTotalValue(); 
        }

        protected void UpdateTotalValue()
        {
            if (Board != null)
            {
                Board.TotalValue += getValue;
                Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}
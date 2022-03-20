﻿using System;
using CardClasses;

namespace GoFishGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a game with 1 human player and 2 ai players
            GoFish game = new GoFish(1, 2);
            game.Deal();
            game.Play();
        }
    }
}

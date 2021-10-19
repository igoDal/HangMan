using System;
using System.Collections.Generic;

namespace HangMan
{
    class Program
    {
        static void Main()
        {
            HangMan hangman = new HangMan();
            hangman.WordToGuess();
            hangman.GuessALetter();

            
        }
        
    }
}
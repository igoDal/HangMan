using System;
using System.Collections.Generic;

namespace HangMan
{
    class HangMan
    {
        private int incorrectGuess = 0;
        private string enteredWord;

        public void WordToGuess() //method which allows us to enter a word to guess
        {
            Console.Write("Enter a word to guess: ");
            enteredWord = Console.ReadLine();
        }

        public bool IsWord(string enteredWord, List<string> letterGuessed) //
        {
            bool word = false;
            for (int i = 0; i < enteredWord.Length; i++)
            {
                string inputLetter = Convert.ToString(enteredWord[i]);
                if (letterGuessed.Contains(inputLetter))
                {
                    word = true;
                }
                else
                {
                    return word = false;
                }
            }
            return word;
        }
        public string Isletter(string enteredWord, List<string> letterGuessed)
        {
            string correctLetters = "";
            for (int i = 0; i < enteredWord.Length; i++)
            {
                string enteredLetter = Convert.ToString(enteredWord[i]);
                if (letterGuessed.Contains(enteredLetter))
                {
                    correctLetters += enteredLetter;
                }
                else
                {
                    correctLetters += "_";
                }
            }
            return correctLetters;
        }

        public void GuessALetter()
        {
            List<string> letterGuessed = new List<string>();
            bool isGameLive = true;

            Isletter(enteredWord, letterGuessed);
            while (isGameLive)
            {
                Console.WriteLine("Please enter a letter:");
                string enteredLetter = Console.ReadLine();
                if (letterGuessed.Contains(enteredLetter))
                {
                    Console.WriteLine($"You already entered a letter {enteredLetter}, try another one.");
                    continue;
                }
                letterGuessed.Add(enteredLetter);
                if (IsWord(enteredWord, letterGuessed))
                {
                    Console.WriteLine(enteredWord);
                    Console.WriteLine("Congratulations, you've won!");
                    break;
                }
                else if (enteredWord.Contains(enteredLetter))
                {
                    Console.WriteLine("Good guess!");
                    string lettersGuessedInAWord = Isletter(enteredWord, letterGuessed);
                    Console.WriteLine(lettersGuessedInAWord);
                }
                else
                {
                    Console.WriteLine("Bad luck...");
                    DrawGallows();
                    incorrectGuess += 1;

                    if (incorrectGuess == 10)
                    {
                        Console.WriteLine("YOU'VE LOST!");
                        isGameLive = false;
                    }

                }
            }
        }

        public void DrawGallows()
        {
            switch (incorrectGuess)
            {
                case 0:
                    Console.WriteLine(
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n/\\");
                    break;

                case 1:
                    Console.WriteLine(
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 2:
                    Console.WriteLine(
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 3:
                    Console.WriteLine(
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 4:
                    Console.WriteLine(
                        "\n_________" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 5:
                    Console.WriteLine(
                        "\n_________" +
                        "\n|       |" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 6:
                    Console.WriteLine(
                        "\n_________" +
                        "\n|       |" +
                        "\n|       O" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 7:
                    Console.WriteLine(
                        "\n_________" +
                        "\n|       |" +
                        "\n|       O" +
                        "\n|       |" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 8:
                    Console.WriteLine(
                        "\n_________" +
                        "\n|       |" +
                        "\n|       O" +
                        "\n|      /|\\" +
                        "\n|" +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    break;
                case 9:
                    Console.WriteLine(
                        "\n_________" +
                        "\n|       |" +
                        "\n|       O" +
                        "\n|      /|\\" +
                        "\n|      / \\ " +
                        "\n|" +
                        "\n|" +
                        "\n/\\");
                    Console.WriteLine("Game over, you've lost.");
                    break;
            }
        }
    }
}
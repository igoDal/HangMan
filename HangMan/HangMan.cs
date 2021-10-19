using System;
using System.Collections.Generic;

namespace HangMan
{
    class HangMan
    {
        public int incorrectGuess = 0;
        public string enteredWord;



        public void WordToGuess()
        {

            Console.Write("Enter a word to guess: ");
            enteredWord = Console.ReadLine();

            Console.WriteLine($"Word to guess: {enteredWord}");
        }

        public bool IsWord(string enteredWord, List<string> letterGuessed)
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
                    word = false;
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
            int live = 1;
            Isletter(enteredWord, letterGuessed);
            while (live > 0)
            {
                Console.WriteLine("Please enter a letter:");
                string input = Console.ReadLine();
                if (letterGuessed.Contains(input))
                {
                    Console.WriteLine($"You already entered a letter {input}, try another one.");
                    continue;
                }
                letterGuessed.Add(input);
                if (IsWord(enteredWord, letterGuessed))
                {
                    Console.WriteLine(enteredWord);
                    Console.WriteLine("Congratulations, you've won!");
                    break;
                }
                else if (enteredWord.Contains(input))
                {
                    Console.WriteLine("Good guess!");
                    string letters = Isletter(enteredWord, letterGuessed);
                    Console.WriteLine(letters);
                }
                else
                {
                    Console.WriteLine("Bad luck...");
                    DrawGallows();
                    incorrectGuess += 1;

                    if (incorrectGuess == 10)
                    {
                        Console.WriteLine("YOU'VE LOST!");
                        live = 0;
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
                default:
                    Console.WriteLine("Enter a letter again.");
                    break;
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        const int BASE_LIVES = 3;
        static void Main(string[] args)
        {
            string answerWord;
            int remainingLives;
            int numberOfGuesses;
            bool playerWon = false;
            char[] guessLetters = new char[30];

            startGame();

            void startGame()
            {
                Console.WriteLine(
                    "Welcome to Hangman. \n" +
                    "Please type a word to be guessed, followed by \"enter\".");
                          
                answerWord = Console.ReadLine();
                Console.Clear();

                remainingLives = BASE_LIVES;
                numberOfGuesses = 0;

                Console.WriteLine(
                    "Welcome to Hangman. \n" +
                    "You have {0} lives remaining \n" +
                    "The answer word is " + answerWord.Length + " letters long. \n" +
                    "Good luck! \n", remainingLives);

            }

            while (!playerWon && remainingLives > 0 ) // ! in front of a boolean means false
            {
                playGame();
                //Console.WriteLine("Good Bye!");
            }
          
            void playGame()
            {

                /*foreach (char c in answerWord)
                {
                    Console.Write(c + " ");
                } */

                Console.WriteLine("\n");

                Console.WriteLine("Enter a letter and then press \"enter\".");
                char userInput = Console.ReadLine().ElementAt(0);
                //or try this >> char input = Console.ReadLine().ElementAt(0);

                guessLetters[numberOfGuesses++] = userInput;
                            
                Console.Clear();

                playerWon = true;

                for (int i = 0; i < answerWord.Length; i++)
                {
                    if (guessLetters.Contains(answerWord.ElementAt(i)))
                    {
                        Console.Write(Char.ToUpper(answerWord.ElementAt(i)) + " ");
                    }

                    else
                    {
                        playerWon = false;
                        Console.Write("_ ");

                    }
                }

                if (playerWon)
                {
                    return;
                }

                      
                if (answerWord.Contains(userInput))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Good guess! ");
                    Console.WriteLine("Your remaining life is {0}. ", remainingLives);

                }

                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Sorry, bad guess :( ");
                    remainingLives = remainingLives - 1; // or remainingLives--;
                    Console.WriteLine("Your remaining life is {0}. ", remainingLives);
                }

            }

            Console.Clear();

            if (playerWon == true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("You win! Thank you for playing!");

                for (int i = 0; i < 10; i++)
                    {
                        Console.Write(":)  ");
                    }

                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Sorry, you didn't win.");
                Console.WriteLine("Correct answer is: " + answerWord.ToUpper());

                for (int x = 0; x < 10; x++)
                {
                    Console.Write(":(  ");
                }

                Console.WriteLine("\n");
            }
        }

               
    }
}

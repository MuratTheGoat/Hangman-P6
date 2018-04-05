/*
 * Created by SharpDevelop.
 * User: 0566353
 * Date: 4/5/2018
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hangman
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Welcome to Hangman!");
			
			string[] sportsteams = new string[3];
			sportsteams[0] = "Dolphins";
			sportsteams[1] = "Heat";
			sportsteams[2] = "Marlins";
			
			Random rand = new Random();
			var wordChoice = rand.Next(0, 3);
			string mysteryWord = sportsteams[wordChoice];
			char[] guess = new char[mysteryWord.Length];
			Console.Write("Enter your guess: ");
			
			for (int x = 0; x < mysteryWord.Length; x++){
				guess[x] = '*';
			}
			
			while (true) {
				char playerGuess = char.Parse(Console.ReadLine());
				for (int j = 0 ; j < mysteryWord.Length; j++){
					if (playerGuess == mysteryWord[j]) {
						guess[j] = playerGuess;
					}
						
				}
				
				Console.WriteLine(guess);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
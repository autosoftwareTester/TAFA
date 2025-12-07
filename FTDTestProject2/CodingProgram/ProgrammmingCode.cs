using System;
using System.Security.Cryptography;

namespace FTDTestProject2.CodingProgram
{
    // Computer makes a choice
    public enum Choices
    {
        Rock,
        Scissors,
        Paper
    }

    public class ProgrammmingCode
    {
        public string rock => "Rock";
        public string scissors => "Scissors";
        public string paper => "Paper";

        private Choices ComputerChoice()
        {
            var choice = RandomNumberGenerator.GetInt32(0, 2);
            // Tuple
            return choice switch
            {
                (int)Choices.Rock => Enum.Parse<Choices>(rock),
                (int)Choices.Paper => Enum.Parse<Choices>(paper),
                (int)Choices.Scissors => Enum.Parse<Choices>(scissors),
                _ => Choices.Scissors
            };
        }

        public string? Game(string userInput)
        {
            var computerChoice = ComputerChoice().ToString();
            bool isChoice = true;
            while (isChoice)
            {
               // userInput = Console.ReadLine() ?? throw new ArgumentNullException("Console.ReadLine()");
                Console.WriteLine($"Enter Choice either: {scissors} | {rock} | {paper}");
                if (Equals(userInput, scissors) || Equals(userInput, paper) || Equals(userInput, rock))
                    isChoice = false;
            }

            if (userInput.Equals(computerChoice))
            {
                return "It a tie";
            }

            if (!userInput.Equals(computerChoice))
            {
                // user and computer choice
                if (userInput == rock && computerChoice.Equals(scissors))
                {
                    return $"Winner is: {rock} will blunt the scissors";
                }

                if (userInput == rock && computerChoice.Equals(rock))
                {
                    return $"Winner is: {scissors} cuts the paper";
                }

                if (userInput.Equals(rock) && computerChoice.Equals(rock))
                {
                    return $"Winner is: {rock} wraps the rock";
                }

                if (userInput.Equals(rock) && computerChoice.Equals(scissors))
                {
                    return $"Winner is: {rock} wraps the rock";
                }
            }

            return null;
        }
    }
}
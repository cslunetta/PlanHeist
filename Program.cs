using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      Console.Write("Enter bank difficulty: ");
      int difficultyInput = int.Parse(Console.ReadLine());
      Console.WriteLine("");

      // Build your team!!!
      List<TeamMember> theTeam = new List<TeamMember>();

      // Prompts user to input team memebers name skill and courage
      TeamMember.AddMember(theTeam);

      Console.WriteLine("");
      Console.WriteLine($"The team has {theTeam.Count} member(s) ");
      Console.WriteLine("---------------------------------------");

      Console.Write("How many trial runs? ");
      string trialInput = Console.ReadLine();
      int trialRuns = int.Parse(trialInput);

      List<string> Results = new List<string>();
      for (int i = 0; i < trialRuns; i++)
      {
        // Difficulty based on skill of the team vs. the bank's difficulty (Difficulty.cs)
        Console.WriteLine("");
        Console.WriteLine($"Trial {i + 1}");
        // SkillCheck on Difficulty.cs
        Challenge.SkillCheck(theTeam, difficultyInput, Results);
      }

      List<string> Success = Results.Where(result => result == "Success").ToList();
      List<string> Fail = Results.Where(result => result == "Fail").ToList();
      Console.WriteLine("");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine($"Out of {Results.Count} Attempt(s)");
      Console.WriteLine($"Success {Success.Count}");
      Console.WriteLine($"Fail {Fail.Count}");
      Console.WriteLine("");
    }
  }
}

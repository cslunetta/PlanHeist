using System;
using System.Collections.Generic;

namespace PlanHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      // Build your team!!!
      List<TeamMember> theTeam = new List<TeamMember>();

      // Prompts user to input team memebers name skill and courage
      TeamMember.AddMember(theTeam);

      Console.WriteLine("");
      Console.WriteLine($"The team has {theTeam.Count} member(s) ");
      Console.WriteLine("---------------------------------------");

      // Difficulty based on skill of the team vs. the bank's difficulty (Difficulty.cs)
      Difficulty.SkillCheck(theTeam);
    }
  }
}

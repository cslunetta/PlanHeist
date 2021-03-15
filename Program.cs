using System;
using System.Collections.Generic;

namespace PlanHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      // Build your team!!!
      Console.WriteLine("Plan Your Heist!");

      List<TeamMember> theTeam = new List<TeamMember>();
      bool adding = true;
      while (adding)
      {
        Console.Write("Enter a team members name: ");
        string name = Console.ReadLine();
        if (name != "")
        {
          Console.Write("What Is their skill level? (1-100): ");
          string skill = Console.ReadLine();
          int skillLevel = int.Parse(skill);
          Console.Write("How couragous are they? (0.0-2.0): ");
          string courage = Console.ReadLine();
          decimal courageFactor = decimal.Parse(courage);

          TeamMember member = new TeamMember(name, skillLevel, courageFactor);
          theTeam.Add(member);
          Console.WriteLine("");
          Console.WriteLine("Add another member? (leave name blank to continue)");
        }
        else
        {
          adding = false;
        }

      }
      Console.WriteLine("");
      Console.WriteLine($"The team has {theTeam.Count} member(s) ");
      Console.WriteLine($"---------------------------------------");

      // Difficulty based on teamSkill
      int bankDifficulty = 100;
      int teamSkill = 0;
      foreach (TeamMember member in theTeam)
      {
        teamSkill += member.Skill;
      }

      if (teamSkill >= bankDifficulty)
      {
        Console.WriteLine("Success");
      }
      else
      {
        Console.WriteLine("Fail");
      }
    }
  }
}

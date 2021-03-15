﻿using System;
using System.Collections.Generic;

namespace PlanHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      List<TeamMember> theTeam = new List<TeamMember>();
      bool adding = true;
      while (adding)
      {
        Console.Write("Enter a team members name: ");
        string name = Console.ReadLine();
        if (name != "")
        {
          Console.Write("What Is there skill level? (1-10): ");
          string skill = Console.ReadLine();
          int skillLevel = int.Parse(skill);
          Console.Write("How couragous are they? (0.0-2.0): ");
          string courage = Console.ReadLine();
          decimal courageFactor = decimal.Parse(courage);

          TeamMember member = new TeamMember(name, skillLevel, courageFactor);
          theTeam.Add(member);
        }
        else
        {
          adding = false;
        }

      }
      Console.WriteLine($"The team has {theTeam.Count} members ");
      foreach (TeamMember member in theTeam)
      {
        member.PrintTeam();
      }
    }
  }
}

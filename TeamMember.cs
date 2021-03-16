using System;
using System.Collections.Generic;

namespace PlanHeist
{
  public class TeamMember
  {
    public string Name { get; set; }
    public int Skill { get; set; }
    public decimal Courage { get; set; }


    // Constructor
    public TeamMember(string name, int skill, decimal courage)
    {
      this.Name = name;
      this.Skill = skill;
      this.Courage = courage;
    }

    public static void AddMember(List<TeamMember> theTeam)
    {
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
    }
  }
}
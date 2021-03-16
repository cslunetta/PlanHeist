using System;
using System.Collections.Generic;

namespace PlanHeist
{
  class Difficulty
  {
    public static void SkillCheck(List<TeamMember> theTeam)
    {
      int difficulty = 100;
      int luckValue = new Random().Next(-10, 10);
      int bankDifficulty = difficulty + luckValue;
      int teamSkill = 0;
      foreach (TeamMember member in theTeam)
      {
        teamSkill += member.Skill;
      }

      Console.WriteLine($"Team's Skill: {teamSkill}");
      Console.WriteLine($"Bank difficulty: {bankDifficulty}");

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
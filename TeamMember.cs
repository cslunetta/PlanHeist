using System;

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
      Name = name;
      Skill = skill;
      Courage = courage;
    }
  }
}
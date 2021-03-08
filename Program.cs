using System;

namespace PlanHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      Console.Write("Enter a team members name: ");
      string name = Console.ReadLine();
      Console.Write("What Is there skill level? (1-10): ");
      string skill = Console.ReadLine();
      int skillLevel = int.Parse(skill);
      Console.Write("How couragous are they? (0.0-2.0): ");
      string courage = Console.ReadLine();
      decimal courageFactor = decimal.Parse(courage);

      TeamMember member = new TeamMember(name, skillLevel, courageFactor);

      Console.WriteLine($@"
Member: {member.Name} 
Skill Level: {member.Skill} 
Courage Factor: {member.Courage}");
    }
  }
}

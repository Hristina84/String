namespace Exam1_Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("; ").ToArray();

            var groups = new Dictionary<string, List<string>>();
            var groupsTime = new Dictionary<string, int>();

            while (input[0] != "start of concert")
            {
                string bandName = input[1];

                if (input[0] == "Add")
                {
                    var member = input[2].Split(", ").ToList();
                                       
                    if (!groups.ContainsKey(bandName))
                    {
                        groups.Add(bandName, new List<string>());                        
                    }
                    for (int i = 0; i < member.Count; i++)
                    {
                        if (!groups[bandName].Contains(member[i]))
                        {
                            groups[bandName].Add(member[i]);
                        }
                    }
                }
                else if (input[0] == "Play")
                {
                    int time = int.Parse(input[2]);

                    if (!groupsTime.ContainsKey(bandName))
                    {
                        groupsTime.Add(bandName,time);
                    }
                    else
                    {
                        groupsTime[bandName] += time;
                    }
                }

                input = Console.ReadLine().Split("; ").ToArray();
            }
            string group = Console.ReadLine();

            Console.WriteLine($"Total time: {groupsTime.Sum(x => x.Value)}");

            foreach (var kvp in groupsTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {                
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            foreach (var kvp in groups)
            {
                if (kvp.Key == group)
                {
                    Console.WriteLine(group);
                    var listOfMembers = kvp.Value;
                    foreach (var member in listOfMembers)
                    {
                        Console.WriteLine($"=> {member}");
                    }
                    break;
                }
            }
        }
    }
}

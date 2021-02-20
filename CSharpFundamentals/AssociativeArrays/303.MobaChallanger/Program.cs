using System;
using System.Collections.Generic;
using System.Linq;

namespace _303.MobaChallanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "Season end")
            {
                string[] newEntry = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (newEntry.Contains("->"))
                {
                    string[] temp = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string player = temp[0];
                    string position = temp[1];
                    int skill = int.Parse(temp[2]);

                    if (playerPool.ContainsKey(player) == false)
                    {
                        playerPool.Add(player, new Dictionary<string, int>());
                        playerPool[player].Add(position, skill);
                    }
                    else
                    {
                        if (playerPool[player].ContainsKey(position) == false)
                        {
                            playerPool[player].Add(position, skill);
                        }
                        else
                        {
                            if (playerPool[player][position] < skill)
                            {
                                playerPool[player][position] += skill - playerPool[player][position];
                            }
                        }
                    }
                }
                else if(newEntry.Contains("vs"))
                {
                    string[] temp = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string playerOne = temp[0];
                    string playerTwo = temp[1];

                    bool isBattle = false;

                    if (playerPool.ContainsKey(playerOne) && playerPool.ContainsKey(playerTwo))
                    {
                        foreach (var item in playerPool[playerOne])
                        {
                            foreach (var item2 in playerPool[playerTwo])
                            {
                                if (item.Key == item2.Key)
                                {
                                    isBattle = true;
                                    break;
                                }
                            }
                            if (isBattle)
                            {
                                break;
                            }
                        }
                    }

                    if (isBattle)
                    {
                        if (playerPool[playerOne].Sum(x => x.Value) > playerPool[playerTwo].Sum(x => x.Value))
                        {
                            playerPool.Remove(playerTwo);
                        }
                        else if (playerPool[playerOne].Sum(x => x.Value) < playerPool[playerTwo].Sum(x => x.Value))
                        {
                            playerPool.Remove(playerOne);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var player in playerPool.OrderByDescending(x => x.Value.Sum(y => y.Value)).ThenBy(z => z.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum(x => x.Value)} skill");
                foreach (var position in player.Value.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        } 
    }
}

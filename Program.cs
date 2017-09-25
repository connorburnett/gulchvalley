using System;
using System.Collections.Generic;
using gulchvalley.Project;

namespace gulchvalley
{
    public class Program
    {
        static void Main(string[] args)
        {

            Project.Game game = new Project.Game();
            game.Playing = true;

            game.Intro();
            game.BuildGame();
            game.EachRoom(game.CurrentRoom);
            //game.Square1();

            // Game Loop Stuff

            while (game.Playing)
            {

                string options = game.UserChoice().ToLower();
                string[] keyAct = options.Split(' ');
                Room nextRoom;
                game.CurrentRoom.Exits.TryGetValue(keyAct[0], out nextRoom);

                if (keyAct[0] == "r")
                {
                    System.Console.WriteLine("\n");
                    game.EachRoom(game.CurrentRoom);
                }
                else if (keyAct[0] == "0")
                {
                    game.Help();
                }
                else if (keyAct[0] == "ti" && keyAct[1] != null)
                {
                    if (keyAct[2] != null)
                        {
                            var itemName = keyAct[1] + ' ' + keyAct[2];
                            game.TakeItem(itemName);
                        }
                    game.TakeItem(keyAct[1]);
                }
                else if (keyAct[0] == "ui")
                {
                    if (keyAct[2] != null)
                    {
                        var itemName = keyAct[1] + ' ' + keyAct[2];
                        game.UseItem(itemName);
                    }
                    game.UseItem(keyAct[1]);
                }
                else if (keyAct[0] == "q")
                {
                    game.Playing = game.Quit(game.Playing);
                }
                else if (keyAct[0] == "i")
                {
                    game.CurrentPlayer.UserItems(game.CurrentPlayer);
                }
                else if (keyAct[0] == "s" || keyAct[0] == "j" || keyAct[0] == "h" || keyAct[0] == "t")
                {
                    game.changeRoom(options);
                }
                else
                {
                    System.Console.WriteLine("Invalid key.");
                }

            }
            System.Console.WriteLine("Would you like to begin another game?...");
            string Continue = Console.ReadLine();
            if (Continue.ToUpper() == "NO")
            {
                game.Playing = false;
            }

        }
    }
}
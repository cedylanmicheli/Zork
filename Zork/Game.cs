using Newtonsoft.Json;
using System;
using System.IO;

namespace Zork
{
    class Game
    {
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool isRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public void Run()
        {
            isRunning = true;
            Room previousRoom = null;
            while(isRunning)
            {
                Console.WriteLine(Player.Location);
                if(previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Console.Write("\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        isRunning = false;
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        if (Player.Move(direction) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();

            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, ignoreCase: true, out Commands result) ? result : Commands.UNKNOWN;
    }
}

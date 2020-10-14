﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public string GoodbyeMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool isRunning { get; set; }


        private Dictionary<string, Command> Commands { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "QUIT", new Command("QUIT", new string[] {"QUIT", "Q"}, Quit) },
                { "LOOK", new Command("LOOK", new string[] {"LOOK", "L"}, Look ) },
                { "NORTH", new Command("NORTH", new string[] {"NORTH", "N"}, (game) => Move(game, Directions.North)) },
                { "SOUTH", new Command("SOUTH", new string[] {"SOUTH", "S"}, (game) => Move(game, Directions.South)) },
                { "EAST", new Command("EAST", new string[] {"EAST", "E"}, (game) => Move(game, Directions.East)) },
                { "WEST", new Command("WEST", new string[] {"WEST", "W"}, (game) => Move(game, Directions.West)) },
            };

        }
    


        public void Run()
        {
            isRunning = true;
            Room previousRoom = null;
            Console.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);
            while (isRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Look(this);
                    previousRoom = Player.Location;
                }
                
                Console.Write("\n> ");


                string commandString = Console.ReadLine().Trim().ToUpper();
                Command foundCommand = null;
                foreach (Command command in Commands.Values)
                {
                    if(command.Verbs.Contains(commandString))
                    {
                        foundCommand = command; 
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    foundCommand.Action(this);
                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Thank you for playing!" : GoodbyeMessage);
           
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        private static void Look(Game game)
        {
            Console.WriteLine(game.Player.Location.Description);
        }

        public static void Move(Game game, Directions direction)
        {
            if(game.Player.Move(direction) == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }

        private static void Quit(Game game)
        {
            game.isRunning = false;
        }

    }
}
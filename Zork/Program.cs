﻿using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.WriteLine(Rooms[CurrentRoomIndex]);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork' lies by the door.";
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString =  Move(command) ?  $"You moved {command}." : outputString = "The way is shut!";
                        break;
                    default:
                        outputString = "Unknown command.";
                        break;
                }
                Console.WriteLine(outputString);
            }       
        }

        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse(commandString, ignoreCase: true, out Commands result) ? result : Commands.UNKNOWN;
        }

        private static string[] Rooms = {
            "Forest", "West of House", "Behind House", "Clearing", "Canyon View" 
        };

        private static int CurrentRoomIndex = 1;

        private static bool Move(Commands command)
        {
            bool didMove = false;

            if (command != Commands.NORTH && 
                command != Commands.SOUTH && 
                command != Commands.EAST && 
                command != Commands.WEST) throw new InvalidOperationException("Invalid command in Move");

            {
                CurrentRoomIndex--;
                didMove = true;
                    didMove = true;
                    break;
                case Commands.WEST when (CurrentRoomIndex > 0):
                    CurrentRoomIndex--;
                    didMove = true;
                    break;
            }

            return didMove;
        }
    }
}

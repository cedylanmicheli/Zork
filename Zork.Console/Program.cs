using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService outputSerivce = new ConsoleOutputService();
            ConsoleInputService inputService = new ConsoleInputService();

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));


            game.Initialize(inputService, outputSerivce);
            game.Output.WriteLine(game.Player.Location.Description);

            while (game.IsRunning)
            {
                outputSerivce.Write("\n> ");
                inputService.ProcessInput();
            }
            
            game.Shutdown();
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
using Newtonsoft.Json;
using System;
using System.IO;

namespace Zork
{
    class Program
    {
        private enum CommandLineArguments
        {
            GameFilename = 0
        }

        static void Main(string[] args)
        {

            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
            game.Run();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Zork
{
    public class Command
    {
        private Action<Game> action;

        public string Name { get; set; }
        public string[] Verbs { get; set; }

        public Action<Game> Action { get => action; set => action = value; }

        public Command(string name, IEnumerable<string> verbs, Action<Game> action)
        {

            Assert.NotNull(action);
            Assert.NotNull(name);
            Assert.NotNull(verbs);

            Name = name;
            Verbs = verbs.ToArray();
            Action = action;
        }
    }
}

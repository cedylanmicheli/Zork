using System;
using System.ComponentModel;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game Game
        {
            get => _game;
            set
            {
                if(_game != value)
                {
                    _game = value;
                    if(_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                        WelcomeMessage = _game.WelcomeMessage;
                        GoodbyeMessage = _game.GoodbyeMessage;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public BindingList<Room> Rooms { get; set; }
        public BindingList<Room> Neighbors { get; set; }

        public string FullPath { get; set; }
        public string WelcomeMessage { get; set; }
        public string GoodbyeMessage { get; set; }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        private Game _game;
    }
}

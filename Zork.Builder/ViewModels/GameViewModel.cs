using System;
using System.ComponentModel;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game Game
        {
            get => mGame;
            set
            {
                if(mGame != value)
                {
                    mGame = value;
                    if(mGame != null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public BindingList<Room> Rooms { get; set; }
        public string FullPath { get; set; }
       
        public string WelcomeMessage {
            get => mGame.WelcomeMessage;
            set => mGame.WelcomeMessage = value; 
        }
        
        public string GoodbyeMessage { 
            get => mGame.GoodbyeMessage; 
            set => mGame.GoodbyeMessage = value; 
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        private Game mGame;
    }
}

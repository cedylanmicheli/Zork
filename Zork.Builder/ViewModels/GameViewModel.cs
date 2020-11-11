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
                    if (mGame != null)
                    {
                        mGame.PropertyChanged -= Game_PropertyChanged;
                        mGame.World.PropertyChanged -= Game_PropertyChanged;
                        foreach (Room room in mGame.World.Rooms)
                        {
                            room.PropertyChanged -= Game_PropertyChanged;
                        }
                    }

                    mGame = value;
                    if (mGame != null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms);
                        mGame.PropertyChanged += Game_PropertyChanged;
                        mGame.World.PropertyChanged += Game_PropertyChanged;
                        foreach (Room room in mGame.World.Rooms)
                        {
                            room.PropertyChanged += Game_PropertyChanged;
                        }
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }

                }
            }
        }

        private void Game_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IsChanged = true;
            PropertyChanged?.Invoke(this, e);
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
        public bool IsChanged { get; set; }
    }
}

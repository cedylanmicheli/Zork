using System;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.User_Controls
{
    public partial class SettingsView : UserControl
    {
        private GameViewModel mViewModel;
        public GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;

                    gameViewModelBindingSource.DataSource = mViewModel;

                    startingDropdown.SelectedIndexChanged -= StartingDropdown_SelectedIndexChanged;
                                  
                    startingDropdown.DataSource = roomsBindingSource;

                    if (StartingLocation == null)
                    {
                        StartingLocation = mViewModel.Rooms.FirstOrDefault();
                    }
                    else
                    {
                        foreach (Room room in mViewModel.Rooms)
                        {
                            if (mViewModel.Game.StartingLocation.Equals(room.Name))
                            {
                                StartingLocation = room;

                                mViewModel.Game.StartingLocation = room.Name;
                                break;
                            }
                        }
                    }
                    
                    startingDropdown.SelectedIndexChanged += StartingDropdown_SelectedIndexChanged;

                }
            }
        }

        public Room StartingLocation
        {
            get => startingDropdown.SelectedItem as Room;
            set => startingDropdown.SelectedItem = value;
        }

        public SettingsView()
        {
            InitializeComponent();
           startingDropdown.DataSource = Array.Empty<Room>();
        }

        private void WelcomeTextBox_TextChanged(object sender, System.EventArgs e)
        {
            mViewModel.Game.WelcomeMessage = welcomeTextBox.Text;
        }

        private void ExitTextBox_TextChanged(object sender, System.EventArgs e)
        {
            mViewModel.Game.GoodbyeMessage = exitTextBox.Text;
        }

        private void StartingDropdown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           if(mViewModel != null)
            {
                if (StartingLocation != null)
                {
                    mViewModel.Game.StartingLocation = StartingLocation.Name;
                }
            }

        }
    }
}

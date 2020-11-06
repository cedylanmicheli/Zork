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
                    startingDropdown.DataSource = mViewModel.Rooms;

                    if (mViewModel.Game.StartingLocation == null)
                    {
                        StartingLocation = mViewModel.Rooms.FirstOrDefault();
                    }
                    //else StartingLocation = mViewModel.Rooms[mViewModel.Game.StartingLocation];
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
                if (mViewModel.Game.StartingLocation != null)
                {
                    mViewModel.Game.StartingLocation = StartingLocation.Name;
                }
            }

        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class WorldView : UserControl
    {
        private GameViewModel mViewModel;

        public GameViewModel ViewModel
        {

            get => mViewModel;
            set
            {
                if(mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }
        public WorldView()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName);
                    mViewModel.Rooms.Add(room);
                }
            }
        }

        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = roomListBox.SelectedItem != null;
            roomNameTextBox.Enabled = roomListBox.SelectedItem != null;
            descriptionTextBox.Enabled = roomListBox.SelectedItem != null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", "Zork Builder", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomListBox.SelectedItem);
                roomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
    }
}

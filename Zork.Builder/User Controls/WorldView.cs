using System;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;
using System.Collections.Generic;
using Zork.Builder.User_Controls;

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


                    Room selectedRoom = roomListBox.SelectedItem as Room;

                    foreach (NeighborsView neighbor in mNeighborViews)
                    {
                        neighbor.ViewModel = mViewModel;
                        if (roomListBox.SelectedItem != null) neighbor.Room = roomListBox.SelectedItem as Room;
                    }
                }
            }
        }

        public WorldView()
        {
            InitializeComponent();
            mNeighborViews.AddRange(new NeighborsView[] { neighborsViewNorth, neighborsViewSouth, neighborsViewEast, neighborsViewWest });
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName);
                    if (mViewModel.Rooms.Contains(room) == false)
                    {
                        mViewModel.Rooms.Add(room);
                        mViewModel.Game.World.RoomsByName.Add(addRoomForm.RoomName, room);
                        
                        var neighbors = new Dictionary<Directions, string>();
                        
                        room.NeighborNames = neighbors;
                        room.UpdateNeighbors(mViewModel.Game.World);
                        isChanged = true;
                    }
                    else
                    {
                        MessageBox.Show($"Room names \"{addRoomForm.RoomName}\" already exists.");
                    }

                }
            }
        }

        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var neighborView in mNeighborViews)
            {
                    neighborView.Room = (Room)roomListBox.SelectedItem;
            }

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
                isChanged = true;
            }
        }

        private readonly List<NeighborsView> mNeighborViews = new List<NeighborsView>();
        public static bool isChanged { get; set; }
    }

}

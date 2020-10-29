using System;
using System.Windows.Forms;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class WorldView : UserControl
    {
        public GameViewModel ViewModel { get; set; }

        public WorldView()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName);
                    ViewModel.Rooms.Add(room);
                }
            }
        }

    }
}

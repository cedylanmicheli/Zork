using System;
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

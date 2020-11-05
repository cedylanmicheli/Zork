using System;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.User_Controls
{
    public partial class NeighborsView : UserControl
    {
        public static readonly Room NoNeighbor = new Room("<None>");

        //TODO
        //Make sure selected room isn't in neighbors dropdown list
        //Add No Neighbor as first entry to list
        //Select an actual Neighbor
        public GameViewModel ViewModel { 
            get => mViewModel; 
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    neighborComboBox.DataSource = mViewModel.Rooms;
                }
            }
        }

        public Directions Direction
        {
            get => _direction;
            set
            {
                _direction = value;
                directionTextBox.Text = _direction.ToString();
            }
        }

        public Room Room
        {
            get => _room;
            set
            {

                if (_room != value)
                {
                    _room = value;
                    if (_room.Neighbors.TryGetValue(Direction, out Room neighbor))
                    {
                        //select neighbor in combo box
                    }
                    else
                    {
                        //select no neighbor room
                    }
                }
            }
        }

        public NeighborsView()
        {
            InitializeComponent();
            Direction = _direction;
            neighborComboBox.DataSource = Array.Empty<Room>();
        }
        
        private Directions _direction;
        private Room _room;
        private GameViewModel mViewModel;

        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

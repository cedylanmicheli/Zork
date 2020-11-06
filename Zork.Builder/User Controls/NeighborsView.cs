using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.User_Controls
{
    public partial class NeighborsView : UserControl
    {
        public static readonly Room NoNeighbor = new Room("<None>");

        private Directions mDirection;
        private GameViewModel mViewModel;
        private Room mRoom;
        
        public GameViewModel ViewModel { 
            get => mViewModel; 
            set
            {
                if (mViewModel != value)
                {

                    mViewModel = value;
                }
            }
        }

        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                directionTextBox.Text = mDirection.ToString();
            }
        }

        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if(mRoom != null)
                    {
                        List<Room> neighbors = new List<Room>(mViewModel.Rooms);
                        neighbors.Insert(0, NoNeighbor);
                        neighbors.Remove(mRoom);

                        neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;

                        neighborComboBox.DataSource = neighbors;

                        if (mRoom.Neighbors != null)
                        {
                            if (mRoom.Neighbors.TryGetValue(Direction, out Room neighbor))
                            {
                                Neighbor = neighbor;
                            }
                            else
                            {
                                Neighbor = NoNeighbor;
                            }
                        }

                        neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;
                    }
                }
            }
        }

        public NeighborsView()
        {
            InitializeComponent();
            Direction = mDirection;
            neighborComboBox.DataSource = Array.Empty<Room>();
        }

        public Room Neighbor
        {
            get => neighborComboBox.SelectedItem as Room;
            set => neighborComboBox.SelectedItem = value;
        }

        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mRoom != null)
            {
                Room neighbor = Neighbor;
                if(neighbor == NoNeighbor)
                {
                    mRoom.Neighbors.Remove(Direction);
                }
                else
                {
                    mRoom.NeighborNames[Direction] = neighbor.Name;
                }
            }    
        }
    }
}

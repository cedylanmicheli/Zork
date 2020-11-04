using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.User_Controls
{
    public partial class NeighborsView : UserControl
    {
        public GameViewModel ViewModel { 
            get => mViewModel; 
            set
            {
                mViewModel = value;
               // neighborComboBox.DataSource = mViewModel.Rooms;
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
            get;
            set;
        }

        public NeighborsView()
        {
            InitializeComponent();
            Direction = _direction;
        }
        
        private Directions _direction;
        private GameViewModel mViewModel;
    }
}

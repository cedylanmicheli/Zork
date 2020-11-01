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
                    worldBindingSource.DataSource = mViewModel;
                }
            }
        }


        public SettingsView()
        {
            InitializeComponent();
        }

        private void WelcomeTextBox_TextChanged(object sender, System.EventArgs e)
        {
            mViewModel.Game.WelcomeMessage = welcomeTextBox.Text;
        }

        private void ExitTextBox_TextChanged(object sender, System.EventArgs e)
        {
            mViewModel.Game.GoodbyeMessage = exitTextBox.Text;
        }
    }
}

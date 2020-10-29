using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.User_Controls
{
    public partial class SettingsView : UserControl
    {
        public GameViewModel ViewModel { get; set; }

        public SettingsView()
        {
            InitializeComponent();
        }
    }
}

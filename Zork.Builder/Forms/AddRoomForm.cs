using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName 
        { 
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            okayButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}

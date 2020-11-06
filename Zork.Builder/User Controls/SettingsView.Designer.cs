namespace Zork.Builder.User_Controls
{
    partial class SettingsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startingDropdown = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.startingLabel = new System.Windows.Forms.Label();
            this.welcomeTextBox = new System.Windows.Forms.TextBox();
            this.exitTextBox = new System.Windows.Forms.TextBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startingDropdown
            // 
            this.startingDropdown.DataSource = this.roomsBindingSource;
            this.startingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startingDropdown.FormattingEnabled = true;
            this.startingDropdown.Location = new System.Drawing.Point(23, 398);
            this.startingDropdown.Name = "startingDropdown";
            this.startingDropdown.Size = new System.Drawing.Size(228, 28);
            this.startingDropdown.TabIndex = 27;
            this.startingDropdown.SelectedIndexChanged += new System.EventHandler(this.StartingDropdown_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(19, 245);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(116, 20);
            this.exitLabel.TabIndex = 26;
            this.exitLabel.Text = "Exit Message";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(19, 111);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(159, 20);
            this.welcomeLabel.TabIndex = 25;
            this.welcomeLabel.Text = "Welcome Message";
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingLabel.Location = new System.Drawing.Point(19, 375);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(147, 20);
            this.startingLabel.TabIndex = 24;
            this.startingLabel.Text = "Starting Location";
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.welcomeTextBox.Location = new System.Drawing.Point(23, 134);
            this.welcomeTextBox.Multiline = true;
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(655, 90);
            this.welcomeTextBox.TabIndex = 30;
            this.welcomeTextBox.TextChanged += new System.EventHandler(this.WelcomeTextBox_TextChanged);
            // 
            // exitTextBox
            // 
            this.exitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "GoodbyeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitTextBox.Location = new System.Drawing.Point(23, 268);
            this.exitTextBox.Multiline = true;
            this.exitTextBox.Name = "exitTextBox";
            this.exitTextBox.Size = new System.Drawing.Size(653, 90);
            this.exitTextBox.TabIndex = 31;
            this.exitTextBox.TextChanged += new System.EventHandler(this.ExitTextBox_TextChanged);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true));
            this.filenameTextBox.Location = new System.Drawing.Point(23, 55);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(655, 26);
            this.filenameTextBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "File Name";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitTextBox);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.startingDropdown);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.startingLabel);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(712, 450);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox startingDropdown;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label startingLabel;
        private System.Windows.Forms.TextBox exitTextBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        public System.Windows.Forms.TextBox welcomeTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}

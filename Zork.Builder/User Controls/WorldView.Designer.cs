namespace Zork.Builder
{
    partial class WorldView
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
            this.roomsLabel = new System.Windows.Forms.Label();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.neighborsViewNorth = new Zork.Builder.User_Controls.NeighborsView();
            this.nieghborsPanel = new System.Windows.Forms.Panel();
            this.neighborsViewEast = new Zork.Builder.User_Controls.NeighborsView();
            this.neighborsViewSouth = new Zork.Builder.User_Controls.NeighborsView();
            this.neighborsViewWest = new Zork.Builder.User_Controls.NeighborsView();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.nieghborsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsLabel.Location = new System.Drawing.Point(18, 49);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(65, 20);
            this.roomsLabel.TabIndex = 0;
            this.roomsLabel.Text = "Rooms";
            // 
            // roomListBox
            // 
            this.roomListBox.DataSource = this.roomsBindingSource;
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 20;
            this.roomListBox.Location = new System.Drawing.Point(22, 72);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(192, 404);
            this.roomListBox.TabIndex = 1;
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 487);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 29);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(124, 487);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.Location = new System.Drawing.Point(237, 71);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(107, 20);
            this.roomNameLabel.TabIndex = 22;
            this.roomNameLabel.Text = "Room Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(237, 140);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(239, 163);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(577, 84);
            this.descriptionTextBox.TabIndex = 20;
            this.descriptionTextBox.Text = "";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Enabled = false;
            this.roomNameTextBox.Location = new System.Drawing.Point(241, 94);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(228, 26);
            this.roomNameTextBox.TabIndex = 15;
            // 
            // neighborsViewNorth
            // 
            this.neighborsViewNorth.Direction = Zork.Directions.North;
            this.neighborsViewNorth.Location = new System.Drawing.Point(191, 3);
            this.neighborsViewNorth.Name = "neighborsViewNorth";
            this.neighborsViewNorth.Neighbor = null;
            this.neighborsViewNorth.Room = null;
            this.neighborsViewNorth.Size = new System.Drawing.Size(187, 88);
            this.neighborsViewNorth.TabIndex = 0;
            this.neighborsViewNorth.ViewModel = null;
            // 
            // nieghborsPanel
            // 
            this.nieghborsPanel.Controls.Add(this.neighborsViewEast);
            this.nieghborsPanel.Controls.Add(this.neighborsViewSouth);
            this.nieghborsPanel.Controls.Add(this.neighborsViewWest);
            this.nieghborsPanel.Controls.Add(this.neighborsViewNorth);
            this.nieghborsPanel.Location = new System.Drawing.Point(241, 264);
            this.nieghborsPanel.Name = "nieghborsPanel";
            this.nieghborsPanel.Size = new System.Drawing.Size(575, 252);
            this.nieghborsPanel.TabIndex = 24;
            // 
            // neighborsViewEast
            // 
            this.neighborsViewEast.Direction = Zork.Directions.East;
            this.neighborsViewEast.Location = new System.Drawing.Point(384, 71);
            this.neighborsViewEast.Name = "neighborsViewEast";
            this.neighborsViewEast.Neighbor = null;
            this.neighborsViewEast.Room = null;
            this.neighborsViewEast.Size = new System.Drawing.Size(187, 88);
            this.neighborsViewEast.TabIndex = 3;
            this.neighborsViewEast.ViewModel = null;
            // 
            // neighborsViewSouth
            // 
            this.neighborsViewSouth.Direction = Zork.Directions.West;
            this.neighborsViewSouth.Location = new System.Drawing.Point(3, 71);
            this.neighborsViewSouth.Name = "neighborsViewSouth";
            this.neighborsViewSouth.Neighbor = null;
            this.neighborsViewSouth.Room = null;
            this.neighborsViewSouth.Size = new System.Drawing.Size(187, 88);
            this.neighborsViewSouth.TabIndex = 2;
            this.neighborsViewSouth.ViewModel = null;
            // 
            // neighborsViewWest
            // 
            this.neighborsViewWest.Direction = Zork.Directions.South;
            this.neighborsViewWest.Location = new System.Drawing.Point(191, 141);
            this.neighborsViewWest.Name = "neighborsViewWest";
            this.neighborsViewWest.Neighbor = null;
            this.neighborsViewWest.Room = null;
            this.neighborsViewWest.Size = new System.Drawing.Size(187, 88);
            this.neighborsViewWest.TabIndex = 1;
            this.neighborsViewWest.ViewModel = null;
            // 
            // WorldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nieghborsPanel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.roomsLabel);
            this.Name = "WorldView";
            this.Size = new System.Drawing.Size(832, 542);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.nieghborsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private User_Controls.NeighborsView neighborsViewNorth;
        private System.Windows.Forms.Panel nieghborsPanel;
        private User_Controls.NeighborsView neighborsViewEast;
        private User_Controls.NeighborsView neighborsViewSouth;
        private User_Controls.NeighborsView neighborsViewWest;
    }
}

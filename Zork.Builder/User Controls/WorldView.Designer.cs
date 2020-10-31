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
            this.northNeighborDropDown = new System.Windows.Forms.ComboBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.southLabel = new System.Windows.Forms.Label();
            this.southNeighborDropDown = new System.Windows.Forms.ComboBox();
            this.eastLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.westNeighborDropDown = new System.Windows.Forms.ComboBox();
            this.eastNeighborDropDown = new System.Windows.Forms.ComboBox();
            this.northLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.roomListBox.DisplayMember = "Name";
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 20;
            this.roomListBox.Location = new System.Drawing.Point(22, 72);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(192, 404);
            this.roomListBox.TabIndex = 1;
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
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(124, 487);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
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
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(239, 163);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(533, 84);
            this.descriptionTextBox.TabIndex = 20;
            this.descriptionTextBox.Text = "Edit Room Description";
            // 
            // northNeighborDropDown
            // 
            this.northNeighborDropDown.FormattingEnabled = true;
            this.northNeighborDropDown.Location = new System.Drawing.Point(158, 45);
            this.northNeighborDropDown.Name = "northNeighborDropDown";
            this.northNeighborDropDown.Size = new System.Drawing.Size(228, 28);
            this.northNeighborDropDown.TabIndex = 16;
            this.northNeighborDropDown.Text = "None";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(241, 94);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(228, 26);
            this.roomNameTextBox.TabIndex = 15;
            this.roomNameTextBox.Text = "Edit Selected Room Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.southLabel);
            this.panel1.Controls.Add(this.southNeighborDropDown);
            this.panel1.Controls.Add(this.eastLabel);
            this.panel1.Controls.Add(this.westLabel);
            this.panel1.Controls.Add(this.westNeighborDropDown);
            this.panel1.Controls.Add(this.eastNeighborDropDown);
            this.panel1.Controls.Add(this.northLabel);
            this.panel1.Controls.Add(this.northNeighborDropDown);
            this.panel1.Location = new System.Drawing.Point(241, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 252);
            this.panel1.TabIndex = 24;
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.southLabel.Location = new System.Drawing.Point(244, 211);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(57, 20);
            this.southLabel.TabIndex = 23;
            this.southLabel.Text = "South";
            // 
            // southNeighborDropDown
            // 
            this.southNeighborDropDown.FormattingEnabled = true;
            this.southNeighborDropDown.Location = new System.Drawing.Point(158, 180);
            this.southNeighborDropDown.Name = "southNeighborDropDown";
            this.southNeighborDropDown.Size = new System.Drawing.Size(228, 28);
            this.southNeighborDropDown.TabIndex = 22;
            this.southNeighborDropDown.Text = "None";
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eastLabel.Location = new System.Drawing.Point(396, 93);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(46, 20);
            this.eastLabel.TabIndex = 21;
            this.eastLabel.Text = "East";
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.westLabel.Location = new System.Drawing.Point(84, 93);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(50, 20);
            this.westLabel.TabIndex = 19;
            this.westLabel.Text = "West";
            // 
            // westNeighborDropDown
            // 
            this.westNeighborDropDown.FormattingEnabled = true;
            this.westNeighborDropDown.Location = new System.Drawing.Point(6, 116);
            this.westNeighborDropDown.Name = "westNeighborDropDown";
            this.westNeighborDropDown.Size = new System.Drawing.Size(228, 28);
            this.westNeighborDropDown.TabIndex = 18;
            this.westNeighborDropDown.Text = "None";
            // 
            // eastNeighborDropDown
            // 
            this.eastNeighborDropDown.FormattingEnabled = true;
            this.eastNeighborDropDown.Location = new System.Drawing.Point(303, 116);
            this.eastNeighborDropDown.Name = "eastNeighborDropDown";
            this.eastNeighborDropDown.Size = new System.Drawing.Size(228, 28);
            this.eastNeighborDropDown.TabIndex = 20;
            this.eastNeighborDropDown.Text = "None";
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.northLabel.Location = new System.Drawing.Point(244, 22);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(53, 20);
            this.northLabel.TabIndex = 17;
            this.northLabel.Text = "North";
            // 
            // WorldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.roomsLabel);
            this.Name = "WorldView";
            this.Size = new System.Drawing.Size(819, 543);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox northNeighborDropDown;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.ComboBox westNeighborDropDown;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.ComboBox eastNeighborDropDown;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.ComboBox southNeighborDropDown;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}

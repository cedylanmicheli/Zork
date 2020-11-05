namespace Zork.Builder.User_Controls
{
    partial class NeighborsView
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
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.neighborComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // directionTextBox
            // 
            this.directionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directionTextBox.Location = new System.Drawing.Point(3, 14);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(181, 26);
            this.directionTextBox.TabIndex = 0;
            // 
            // neighborComboBox
            // 
            this.neighborComboBox.AllowDrop = true;
            this.neighborComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neighborComboBox.FormattingEnabled = true;
            this.neighborComboBox.Location = new System.Drawing.Point(3, 46);
            this.neighborComboBox.Name = "neighborComboBox";
            this.neighborComboBox.Size = new System.Drawing.Size(181, 28);
            this.neighborComboBox.TabIndex = 1;
            this.neighborComboBox.SelectedIndexChanged += new System.EventHandler(this.neighborComboBox_SelectedIndexChanged);
            // 
            // NeighborsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Name = "NeighborsView";
            this.Size = new System.Drawing.Size(187, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.ComboBox neighborComboBox;
    }
}

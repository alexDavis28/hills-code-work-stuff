
namespace GuessingGameGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripOne = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GuessesLeftLabel = new System.Windows.Forms.Label();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.GuessesListBox = new System.Windows.Forms.ListBox();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.PlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.ComputerRadioButton = new System.Windows.Forms.RadioButton();
            this.MeRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.PlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOne});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripOne
            // 
            this.menuStripOne.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripOne.Name = "menuStripOne";
            this.menuStripOne.Size = new System.Drawing.Size(62, 24);
            this.menuStripOne.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(676, 51);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(94, 29);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Guesses Left";
            // 
            // GuessesLeftLabel
            // 
            this.GuessesLeftLabel.AutoSize = true;
            this.GuessesLeftLabel.Location = new System.Drawing.Point(186, 88);
            this.GuessesLeftLabel.Name = "GuessesLeftLabel";
            this.GuessesLeftLabel.Size = new System.Drawing.Size(25, 20);
            this.GuessesLeftLabel.TabIndex = 3;
            this.GuessesLeftLabel.Text = "10";
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Location = new System.Drawing.Point(13, 133);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(125, 27);
            this.GuessTextBox.TabIndex = 4;
            this.GuessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuessTextBox_KeyPress);
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(186, 133);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(94, 29);
            this.GuessButton.TabIndex = 5;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // GuessesListBox
            // 
            this.GuessesListBox.FormattingEnabled = true;
            this.GuessesListBox.ItemHeight = 20;
            this.GuessesListBox.Location = new System.Drawing.Point(13, 195);
            this.GuessesListBox.Name = "GuessesListBox";
            this.GuessesListBox.Size = new System.Drawing.Size(198, 164);
            this.GuessesListBox.TabIndex = 6;
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ResponseLabel.Location = new System.Drawing.Point(445, 133);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(72, 20);
            this.ResponseLabel.TabIndex = 7;
            this.ResponseLabel.Text = "Response";
            // 
            // PlayerGroupBox
            // 
            this.PlayerGroupBox.Controls.Add(this.ComputerRadioButton);
            this.PlayerGroupBox.Controls.Add(this.MeRadioButton);
            this.PlayerGroupBox.Location = new System.Drawing.Point(445, 195);
            this.PlayerGroupBox.Name = "PlayerGroupBox";
            this.PlayerGroupBox.Size = new System.Drawing.Size(250, 164);
            this.PlayerGroupBox.TabIndex = 8;
            this.PlayerGroupBox.TabStop = false;
            this.PlayerGroupBox.Text = "Who guesses?";
            // 
            // ComputerRadioButton
            // 
            this.ComputerRadioButton.AutoSize = true;
            this.ComputerRadioButton.Location = new System.Drawing.Point(6, 56);
            this.ComputerRadioButton.Name = "ComputerRadioButton";
            this.ComputerRadioButton.Size = new System.Drawing.Size(96, 24);
            this.ComputerRadioButton.TabIndex = 1;
            this.ComputerRadioButton.TabStop = true;
            this.ComputerRadioButton.Text = "Computer";
            this.ComputerRadioButton.UseVisualStyleBackColor = true;
            this.ComputerRadioButton.CheckedChanged += new System.EventHandler(this.ComputerRadioButton_CheckedChanged);
            // 
            // MeRadioButton
            // 
            this.MeRadioButton.AutoSize = true;
            this.MeRadioButton.Location = new System.Drawing.Point(6, 26);
            this.MeRadioButton.Name = "MeRadioButton";
            this.MeRadioButton.Size = new System.Drawing.Size(51, 24);
            this.MeRadioButton.TabIndex = 0;
            this.MeRadioButton.TabStop = true;
            this.MeRadioButton.Text = "Me";
            this.MeRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerGroupBox);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.GuessesListBox);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.GuessesLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PlayerGroupBox.ResumeLayout(false);
            this.PlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripOne;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GuessesLeftLabel;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.ListBox GuessesListBox;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.GroupBox PlayerGroupBox;
        private System.Windows.Forms.RadioButton ComputerRadioButton;
        private System.Windows.Forms.RadioButton MeRadioButton;
    }
}


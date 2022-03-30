
namespace GuessingGameGUI
{
    partial class ComputerGuessForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GuessLabel = new System.Windows.Forms.Label();
            this.TooLowButton = new System.Windows.Forms.Button();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.TooHighButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessLabel
            // 
            this.GuessLabel.AutoSize = true;
            this.GuessLabel.Location = new System.Drawing.Point(285, 116);
            this.GuessLabel.Name = "GuessLabel";
            this.GuessLabel.Size = new System.Drawing.Size(32, 20);
            this.GuessLabel.TabIndex = 0;
            this.GuessLabel.Text = "Is it";
            // 
            // TooLowButton
            // 
            this.TooLowButton.Location = new System.Drawing.Point(42, 211);
            this.TooLowButton.Name = "TooLowButton";
            this.TooLowButton.Size = new System.Drawing.Size(94, 29);
            this.TooLowButton.TabIndex = 1;
            this.TooLowButton.Text = "Too low";
            this.TooLowButton.UseVisualStyleBackColor = true;
            this.TooLowButton.Click += new System.EventHandler(this.TooLowButton_Click);
            // 
            // CorrectButton
            // 
            this.CorrectButton.Location = new System.Drawing.Point(308, 211);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(94, 29);
            this.CorrectButton.TabIndex = 2;
            this.CorrectButton.Text = "Correct";
            this.CorrectButton.UseVisualStyleBackColor = true;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // TooHighButton
            // 
            this.TooHighButton.Location = new System.Drawing.Point(596, 211);
            this.TooHighButton.Name = "TooHighButton";
            this.TooHighButton.Size = new System.Drawing.Size(94, 29);
            this.TooHighButton.TabIndex = 3;
            this.TooHighButton.Text = "Too high";
            this.TooHighButton.UseVisualStyleBackColor = true;
            this.TooHighButton.Click += new System.EventHandler(this.TooHighButton_Click);
            // 
            // ComputerGuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TooHighButton);
            this.Controls.Add(this.CorrectButton);
            this.Controls.Add(this.TooLowButton);
            this.Controls.Add(this.GuessLabel);
            this.Name = "ComputerGuessForm";
            this.Text = "ComputerGuessForm";
            this.Load += new System.EventHandler(this.ComputerGuessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuessLabel;
        private System.Windows.Forms.Button TooLowButton;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.Button TooHighButton;
    }
}
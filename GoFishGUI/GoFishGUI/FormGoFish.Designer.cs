
namespace GoFishGUI
{
    partial class FormGoFish
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
            this.components = new System.ComponentModel.Container();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.P1CardImages = new System.Windows.Forms.ImageList(this.components);
            this.P1Label = new System.Windows.Forms.Label();
            this.P2Label = new System.Windows.Forms.Label();
            this.P4Label = new System.Windows.Forms.Label();
            this.P3Label = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.RequestCardButton = new System.Windows.Forms.Button();
            this.RequestCardInput = new System.Windows.Forms.TextBox();
            this.P2Dialogue = new System.Windows.Forms.Label();
            this.P3Dialogue = new System.Windows.Forms.Label();
            this.P4Dialogue = new System.Windows.Forms.Label();
            this.P1Dialogue = new System.Windows.Forms.Label();
            this.P1Score = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            this.P3Score = new System.Windows.Forms.Label();
            this.P4Score = new System.Windows.Forms.Label();
            this.NextTurnButton = new System.Windows.Forms.Button();
            this.CurrentTurnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(13, 13);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(94, 29);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // P1CardImages
            // 
            this.P1CardImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.P1CardImages.ImageSize = new System.Drawing.Size(16, 16);
            this.P1CardImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // P1Label
            // 
            this.P1Label.AutoSize = true;
            this.P1Label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1Label.Location = new System.Drawing.Point(521, 379);
            this.P1Label.Name = "P1Label";
            this.P1Label.Size = new System.Drawing.Size(84, 67);
            this.P1Label.TabIndex = 1;
            this.P1Label.Text = "P1";
            // 
            // P2Label
            // 
            this.P2Label.AutoSize = true;
            this.P2Label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2Label.Location = new System.Drawing.Point(841, 163);
            this.P2Label.Name = "P2Label";
            this.P2Label.Size = new System.Drawing.Size(84, 67);
            this.P2Label.TabIndex = 2;
            this.P2Label.Text = "P2";
            // 
            // P4Label
            // 
            this.P4Label.AutoSize = true;
            this.P4Label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P4Label.Location = new System.Drawing.Point(180, 163);
            this.P4Label.Name = "P4Label";
            this.P4Label.Size = new System.Drawing.Size(84, 67);
            this.P4Label.TabIndex = 3;
            this.P4Label.Text = "P4";
            // 
            // P3Label
            // 
            this.P3Label.AutoSize = true;
            this.P3Label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P3Label.Location = new System.Drawing.Point(521, 44);
            this.P3Label.Name = "P3Label";
            this.P3Label.Size = new System.Drawing.Size(84, 67);
            this.P3Label.TabIndex = 4;
            this.P3Label.Text = "P3";
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(499, 279);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(125, 29);
            this.DrawButton.TabIndex = 5;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // RequestCardButton
            // 
            this.RequestCardButton.Location = new System.Drawing.Point(499, 314);
            this.RequestCardButton.Name = "RequestCardButton";
            this.RequestCardButton.Size = new System.Drawing.Size(125, 29);
            this.RequestCardButton.TabIndex = 0;
            this.RequestCardButton.Text = "Request card";
            this.RequestCardButton.UseVisualStyleBackColor = true;
            this.RequestCardButton.Click += new System.EventHandler(this.RequestCardButton_Click);
            // 
            // RequestCardInput
            // 
            this.RequestCardInput.Location = new System.Drawing.Point(499, 349);
            this.RequestCardInput.Name = "RequestCardInput";
            this.RequestCardInput.Size = new System.Drawing.Size(125, 27);
            this.RequestCardInput.TabIndex = 1;
            // 
            // P2Dialogue
            // 
            this.P2Dialogue.AutoSize = true;
            this.P2Dialogue.Location = new System.Drawing.Point(839, 132);
            this.P2Dialogue.Name = "P2Dialogue";
            this.P2Dialogue.Size = new System.Drawing.Size(86, 20);
            this.P2Dialogue.TabIndex = 6;
            this.P2Dialogue.Text = "P2Dialogue";
            // 
            // P3Dialogue
            // 
            this.P3Dialogue.AutoSize = true;
            this.P3Dialogue.Location = new System.Drawing.Point(521, 17);
            this.P3Dialogue.Name = "P3Dialogue";
            this.P3Dialogue.Size = new System.Drawing.Size(86, 20);
            this.P3Dialogue.TabIndex = 7;
            this.P3Dialogue.Text = "P3Dialogue";
            // 
            // P4Dialogue
            // 
            this.P4Dialogue.AutoSize = true;
            this.P4Dialogue.Location = new System.Drawing.Point(178, 132);
            this.P4Dialogue.Name = "P4Dialogue";
            this.P4Dialogue.Size = new System.Drawing.Size(86, 20);
            this.P4Dialogue.TabIndex = 8;
            this.P4Dialogue.Text = "P4Dialogue";
            // 
            // P1Dialogue
            // 
            this.P1Dialogue.AutoSize = true;
            this.P1Dialogue.Location = new System.Drawing.Point(519, 241);
            this.P1Dialogue.Name = "P1Dialogue";
            this.P1Dialogue.Size = new System.Drawing.Size(86, 20);
            this.P1Dialogue.TabIndex = 9;
            this.P1Dialogue.Text = "P1Dialogue";
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.Location = new System.Drawing.Point(534, 446);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(61, 20);
            this.P1Score.TabIndex = 10;
            this.P1Score.Text = "Score: 0";
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.Location = new System.Drawing.Point(851, 230);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(61, 20);
            this.P2Score.TabIndex = 11;
            this.P2Score.Text = "Score: 0";
            // 
            // P3Score
            // 
            this.P3Score.AutoSize = true;
            this.P3Score.Location = new System.Drawing.Point(534, 111);
            this.P3Score.Name = "P3Score";
            this.P3Score.Size = new System.Drawing.Size(61, 20);
            this.P3Score.TabIndex = 12;
            this.P3Score.Text = "Score: 0";
            // 
            // P4Score
            // 
            this.P4Score.AutoSize = true;
            this.P4Score.Location = new System.Drawing.Point(190, 230);
            this.P4Score.Name = "P4Score";
            this.P4Score.Size = new System.Drawing.Size(61, 20);
            this.P4Score.TabIndex = 13;
            this.P4Score.Text = "Score: 0";
            // 
            // NextTurnButton
            // 
            this.NextTurnButton.Location = new System.Drawing.Point(513, 197);
            this.NextTurnButton.Name = "NextTurnButton";
            this.NextTurnButton.Size = new System.Drawing.Size(94, 29);
            this.NextTurnButton.TabIndex = 14;
            this.NextTurnButton.Text = "Next Turn";
            this.NextTurnButton.UseVisualStyleBackColor = true;
            this.NextTurnButton.Click += new System.EventHandler(this.NextTurnButton_Click);
            // 
            // CurrentTurnLabel
            // 
            this.CurrentTurnLabel.AutoSize = true;
            this.CurrentTurnLabel.Location = new System.Drawing.Point(513, 163);
            this.CurrentTurnLabel.Name = "CurrentTurnLabel";
            this.CurrentTurnLabel.Size = new System.Drawing.Size(102, 20);
            this.CurrentTurnLabel.TabIndex = 15;
            this.CurrentTurnLabel.Text = "Current turn: 1";
            // 
            // FormGoFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 605);
            this.Controls.Add(this.CurrentTurnLabel);
            this.Controls.Add(this.NextTurnButton);
            this.Controls.Add(this.P4Score);
            this.Controls.Add(this.P3Score);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1Score);
            this.Controls.Add(this.P1Dialogue);
            this.Controls.Add(this.P4Dialogue);
            this.Controls.Add(this.P3Dialogue);
            this.Controls.Add(this.P2Dialogue);
            this.Controls.Add(this.RequestCardInput);
            this.Controls.Add(this.RequestCardButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.P3Label);
            this.Controls.Add(this.P4Label);
            this.Controls.Add(this.P2Label);
            this.Controls.Add(this.P1Label);
            this.Controls.Add(this.NewGameButton);
            this.Name = "FormGoFish";
            this.Text = "Go Fish";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGoFish_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormGoFish_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.ImageList P1CardImages;
        private System.Windows.Forms.Label P1Label;
        private System.Windows.Forms.Label P2Label;
        private System.Windows.Forms.Label P4Label;
        private System.Windows.Forms.Label P3Label;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.TextBox RequestCardInput;
        private System.Windows.Forms.Button RequestCardButton;
        private System.Windows.Forms.Label P2Dialogue;
        private System.Windows.Forms.Label P3Dialogue;
        private System.Windows.Forms.Label P4Dialogue;
        private System.Windows.Forms.Label P1Dialogue;
        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.Label P2Score;
        private System.Windows.Forms.Label P3Score;
        private System.Windows.Forms.Label P4Score;
        private System.Windows.Forms.Button NextTurnButton;
        private System.Windows.Forms.Label CurrentTurnLabel;
    }
}


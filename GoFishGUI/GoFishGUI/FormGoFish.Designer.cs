
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P2_Score = new System.Windows.Forms.Label();
            this.P1_Score = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P1CardImages = new System.Windows.Forms.ImageList(this.components);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scores";
            // 
            // P2_Score
            // 
            this.P2_Score.AutoSize = true;
            this.P2_Score.Location = new System.Drawing.Point(725, 88);
            this.P2_Score.Name = "P2_Score";
            this.P2_Score.Size = new System.Drawing.Size(17, 20);
            this.P2_Score.TabIndex = 3;
            this.P2_Score.Text = "0";
            // 
            // P1_Score
            // 
            this.P1_Score.AutoSize = true;
            this.P1_Score.Location = new System.Drawing.Point(638, 88);
            this.P1_Score.Name = "P1_Score";
            this.P1_Score.Size = new System.Drawing.Size(17, 20);
            this.P1_Score.TabIndex = 4;
            this.P1_Score.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "P1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "P2";
            // 
            // P1CardImages
            // 
            this.P1CardImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.P1CardImages.ImageSize = new System.Drawing.Size(16, 16);
            this.P1CardImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormGoFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P1_Score);
            this.Controls.Add(this.P2_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewGameButton);
            this.Name = "FormGoFish";
            this.Text = "Go Fish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label P2_Score;
        private System.Windows.Forms.Label P1_Score;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList P1CardImages;
    }
}


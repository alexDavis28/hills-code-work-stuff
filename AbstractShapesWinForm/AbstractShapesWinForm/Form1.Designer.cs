namespace AbstractShapesWinForm
{
    partial class Form1
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
            this.AreaLbl = new System.Windows.Forms.Label();
            this.CreateSquareBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sidesLbl = new System.Windows.Forms.Label();
            this.txtLengthSideSquare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AreaLbl
            // 
            this.AreaLbl.AutoSize = true;
            this.AreaLbl.Location = new System.Drawing.Point(689, 81);
            this.AreaLbl.Name = "AreaLbl";
            this.AreaLbl.Size = new System.Drawing.Size(50, 20);
            this.AreaLbl.TabIndex = 3;
            this.AreaLbl.Text = "label1";
            // 
            // CreateSquareBtn
            // 
            this.CreateSquareBtn.Location = new System.Drawing.Point(87, 39);
            this.CreateSquareBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateSquareBtn.Name = "CreateSquareBtn";
            this.CreateSquareBtn.Size = new System.Drawing.Size(86, 75);
            this.CreateSquareBtn.TabIndex = 2;
            this.CreateSquareBtn.Text = "Create Square";
            this.CreateSquareBtn.UseVisualStyleBackColor = true;
            this.CreateSquareBtn.Click += new System.EventHandler(this.CreateSquareBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 75);
            this.button2.TabIndex = 0;
            this.button2.Text = "Display Shape";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DisplayShapeBtn_Click);
            // 
            // sidesLbl
            // 
            this.sidesLbl.AutoSize = true;
            this.sidesLbl.Location = new System.Drawing.Point(689, 52);
            this.sidesLbl.Name = "sidesLbl";
            this.sidesLbl.Size = new System.Drawing.Size(44, 20);
            this.sidesLbl.TabIndex = 1;
            this.sidesLbl.Text = "Sides";
            // 
            // txtLengthSideSquare
            // 
            this.txtLengthSideSquare.Location = new System.Drawing.Point(225, 77);
            this.txtLengthSideSquare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLengthSideSquare.Name = "txtLengthSideSquare";
            this.txtLengthSideSquare.Size = new System.Drawing.Size(114, 27);
            this.txtLengthSideSquare.TabIndex = 4;
            this.txtLengthSideSquare.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLengthSideSquare);
            this.Controls.Add(this.sidesLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateSquareBtn);
            this.Controls.Add(this.AreaLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AreaLbl;
        private System.Windows.Forms.Button CreateSquareBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sidesLbl;
        private System.Windows.Forms.TextBox txtLengthSideSquare;
        private System.Windows.Forms.Label label2;
    }
}


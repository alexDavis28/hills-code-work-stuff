
namespace MyCalculatorFormsApp
{
    partial class CalculatorForm
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
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number3TextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CalculatorOptionsBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.CalculatorOptionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(327, 75);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(127, 27);
            this.number1TextBox.TabIndex = 0;
            this.number1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number1TextBox_KeyPress);
            // 
            // number3TextBox
            // 
            this.number3TextBox.Location = new System.Drawing.Point(327, 175);
            this.number3TextBox.Name = "number3TextBox";
            this.number3TextBox.ReadOnly = true;
            this.number3TextBox.Size = new System.Drawing.Size(127, 27);
            this.number3TextBox.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CalculatorOptionsBox
            // 
            this.CalculatorOptionsBox.Controls.Add(this.radioButton4);
            this.CalculatorOptionsBox.Controls.Add(this.radioButton3);
            this.CalculatorOptionsBox.Controls.Add(this.radioButton2);
            this.CalculatorOptionsBox.Controls.Add(this.radioButton1);
            this.CalculatorOptionsBox.Location = new System.Drawing.Point(523, 75);
            this.CalculatorOptionsBox.Name = "CalculatorOptionsBox";
            this.CalculatorOptionsBox.Size = new System.Drawing.Size(250, 150);
            this.CalculatorOptionsBox.TabIndex = 2;
            this.CalculatorOptionsBox.TabStop = false;
            this.CalculatorOptionsBox.Text = "Operations";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Subtract";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Multiply";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 116);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Divide";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(327, 125);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(127, 27);
            this.number2TextBox.TabIndex = 1;
            this.number2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number2TextBox_KeyPress);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculatorOptionsBox);
            this.Controls.Add(this.number3TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.CalculatorOptionsBox.ResumeLayout(false);
            this.CalculatorOptionsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number3TextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox CalculatorOptionsBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox number2TextBox;
    }
}


namespace Homework8
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areaShow = new System.Windows.Forms.Label();
            this.perimeterShow = new System.Windows.Forms.Label();
            this.CalculateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Circle radius:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(86, 235);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(647, 44);
            this.inputTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(365, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 305);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 73);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perimeter:";
            // 
            // areaShow
            // 
            this.areaShow.AutoSize = true;
            this.areaShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaShow.Location = new System.Drawing.Point(81, 591);
            this.areaShow.Name = "areaShow";
            this.areaShow.Size = new System.Drawing.Size(256, 46);
            this.areaShow.TabIndex = 5;
            this.areaShow.Text = "*size of area*";
            // 
            // perimeterShow
            // 
            this.perimeterShow.AutoSize = true;
            this.perimeterShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perimeterShow.Location = new System.Drawing.Point(437, 591);
            this.perimeterShow.Name = "perimeterShow";
            this.perimeterShow.Size = new System.Drawing.Size(349, 46);
            this.perimeterShow.TabIndex = 6;
            this.perimeterShow.Text = "*size of Perimeter*";
            // 
            // CalculateBTN
            // 
            this.CalculateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBTN.Location = new System.Drawing.Point(285, 301);
            this.CalculateBTN.Name = "CalculateBTN";
            this.CalculateBTN.Size = new System.Drawing.Size(234, 108);
            this.CalculateBTN.TabIndex = 7;
            this.CalculateBTN.Text = "Calculate";
            this.CalculateBTN.UseVisualStyleBackColor = true;
            this.CalculateBTN.Click += new System.EventHandler(this.CalculateBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(818, 753);
            this.Controls.Add(this.CalculateBTN);
            this.Controls.Add(this.perimeterShow);
            this.Controls.Add(this.areaShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label areaShow;
        private System.Windows.Forms.Label perimeterShow;
        private System.Windows.Forms.Button CalculateBTN;
    }
}


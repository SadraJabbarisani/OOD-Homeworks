namespace Homeworke3
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
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmptyError = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Point* = ";
            // 
            // xTextBox
            // 
            this.xTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTextBox.Location = new System.Drawing.Point(349, 92);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 44);
            this.xTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(274, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "X : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(472, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y : ";
            // 
            // yTextBox
            // 
            this.yTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yTextBox.Location = new System.Drawing.Point(547, 92);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 44);
            this.yTextBox.TabIndex = 3;
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(720, 80);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(105, 67);
            this.addBTN.TabIndex = 5;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(57, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hint: you should Enter a Int";
            // 
            // EmptyError
            // 
            this.EmptyError.AutoSize = true;
            this.EmptyError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyError.ForeColor = System.Drawing.Color.Red;
            this.EmptyError.Location = new System.Drawing.Point(634, 189);
            this.EmptyError.Name = "EmptyError";
            this.EmptyError.Size = new System.Drawing.Size(221, 29);
            this.EmptyError.TabIndex = 7;
            this.EmptyError.Text = "TextBox are Empty!";
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.Silver;
            this.graph.BackgroundImage = global::Homeworke3.Properties.Resources.background;
            this.graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graph.Cursor = System.Windows.Forms.Cursors.Default;
            this.graph.Location = new System.Drawing.Point(27, 277);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(813, 803);
            this.graph.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(867, 1106);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.EmptyError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EmptyError;
        private System.Windows.Forms.Panel graph;
    }
}


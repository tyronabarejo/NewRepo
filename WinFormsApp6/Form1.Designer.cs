namespace WinFormsApp6
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
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtRadius = new TextBox();
            txtBase = new TextBox();
            txtHeight = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            txtRecentResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label51 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtLength
            // 
            txtLength.Location = new Point(101, 21);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 0;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(101, 50);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 1;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(101, 21);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 2;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(101, 14);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(102, 47);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(231, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Rectangle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Location = new Point(231, 21);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Circle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Location = new Point(229, 32);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Triangle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(55, 136);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtRecentResult
            // 
            txtRecentResult.Location = new Point(55, 41);
            txtRecentResult.Name = "txtRecentResult";
            txtRecentResult.Size = new Size(120, 23);
            txtRecentResult.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 10;
            label1.Text = "Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 24);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 12;
            label3.Text = "Radius:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 22);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "Base:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 50);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 14;
            label5.Text = "Height:";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(66, 21);
            label51.Name = "label51";
            label51.Size = new Size(78, 15);
            label51.TabIndex = 64;
            label51.Text = "Recent Result";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtLength);
            panel1.Controls.Add(txtWidth);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(98, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 100);
            panel1.TabIndex = 65;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtRadius);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(98, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 75);
            panel2.TabIndex = 66;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(txtBase);
            panel3.Controls.Add(txtHeight);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(98, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 81);
            panel3.TabIndex = 67;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(txtRecentResult);
            panel4.Controls.Add(label51);
            panel4.Location = new Point(515, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 263);
            panel4.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 112);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 65;
            label6.Text = "Final Result";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtRadius;
        private TextBox txtBase;
        private TextBox txtHeight;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private TextBox txtRecentResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label51;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
    }
}

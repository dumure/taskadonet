﻿namespace taskadonet
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(273, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(258, 155);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(190, 225);
            button1.Name = "button1";
            button1.Size = new Size(108, 27);
            button1.TabIndex = 4;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(301, 225);
            button2.Name = "button2";
            button2.Size = new Size(108, 27);
            button2.TabIndex = 6;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 382);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
    }
}

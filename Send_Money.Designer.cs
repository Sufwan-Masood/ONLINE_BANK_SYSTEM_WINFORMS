﻿namespace SE_bank
{
    partial class Send_Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_Money));
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 132);
            label4.Name = "label4";
            label4.Size = new Size(192, 22);
            label4.TabIndex = 40;
            label4.Text = "MOVING FORWARD";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(74, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 88);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 409);
            label3.Name = "label3";
            label3.Size = new Size(247, 28);
            label3.TabIndex = 38;
            label3.Text = "ENTER PASSWORD:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(482, 409);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "1234";
            textBox3.Size = new Size(337, 31);
            textBox3.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(338, 327);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 36;
            label2.Text = "AMOUNT:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(482, 324);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "$$$";
            textBox2.Size = new Size(337, 31);
            textBox2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(271, 235);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 34;
            label1.Text = "IBAN NUMBER:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(482, 235);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1111 111 111111";
            textBox1.Size = new Size(337, 31);
            textBox1.TabIndex = 33;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Bell MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(371, 495);
            button1.Name = "button1";
            button1.Size = new Size(431, 63);
            button1.TabIndex = 32;
            button1.Text = "CONFIRM TRANSACTION";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(457, 51);
            label8.Name = "label8";
            label8.Size = new Size(279, 47);
            label8.TabIndex = 31;
            label8.Text = "SEND MONEY";
            // 
            // Send_Money
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 581);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label8);
            Name = "Send_Money";
            Text = "Send_Money";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label8;
    }
}
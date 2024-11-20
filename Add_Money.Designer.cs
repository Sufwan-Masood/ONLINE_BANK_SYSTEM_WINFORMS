namespace SE_bank
{
    partial class Add_Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Money));
            label8 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(448, 35);
            label8.Name = "label8";
            label8.Size = new Size(268, 47);
            label8.TabIndex = 19;
            label8.Text = "ADD MONEY";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Bell MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(362, 479);
            button1.Name = "button1";
            button1.Size = new Size(431, 63);
            button1.TabIndex = 22;
            button1.Text = "CONFIRM TRANSACTION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 219);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 24;
            label1.Text = "IBAN NUMBER:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 219);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1111 111 111111";
            textBox1.Size = new Size(337, 31);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 311);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 26;
            label2.Text = "AMOUNT:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(473, 308);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "$$$";
            textBox2.Size = new Size(337, 31);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(247, 396);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 28;
            label3.Text = "ENTER OTP PIN:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(473, 393);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "1234";
            textBox3.Size = new Size(337, 31);
            textBox3.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 116);
            label4.Name = "label4";
            label4.Size = new Size(192, 22);
            label4.TabIndex = 30;
            label4.Text = "MOVING FORWARD";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(65, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 88);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Bell MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(931, 517);
            button2.Name = "button2";
            button2.Size = new Size(167, 52);
            button2.TabIndex = 42;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Add_Money
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 581);
            Controls.Add(button2);
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
            Name = "Add_Money";
            Text = "Add_Money";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
namespace SE_bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(627, 183);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter username here";
            textBox1.Size = new Size(337, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(627, 275);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter password here";
            textBox2.Size = new Size(337, 31);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(461, 183);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 2;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 278);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(652, 358);
            button1.Name = "button1";
            button1.Size = new Size(131, 63);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(805, 358);
            button2.Name = "button2";
            button2.Size = new Size(131, 63);
            button2.TabIndex = 5;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(99, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 144);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 358);
            label3.Name = "label3";
            label3.Size = new Size(256, 28);
            label3.TabIndex = 7;
            label3.Text = "MOVING FORWARD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(24, 34);
            label4.Name = "label4";
            label4.Size = new Size(625, 47);
            label4.TabIndex = 8;
            label4.Text = "ONLINE BANKING APPLICATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 581);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}
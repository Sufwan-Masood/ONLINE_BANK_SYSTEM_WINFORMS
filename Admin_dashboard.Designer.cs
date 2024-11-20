namespace SE_bank
{
    partial class Admin_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_dashboard));
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Schoolbook", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 480);
            label5.Name = "label5";
            label5.Size = new Size(437, 47);
            label5.TabIndex = 56;
            label5.Text = "ACTIVE ACCOUNTS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 378);
            label3.Name = "label3";
            label3.Size = new Size(394, 47);
            label3.TabIndex = 55;
            label3.Text = "TOTAL DEPOSITS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 280);
            label2.Name = "label2";
            label2.Size = new Size(451, 47);
            label2.TabIndex = 54;
            label2.Text = "TOTAL WITHDRAWS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 180);
            label1.Name = "label1";
            label1.Size = new Size(388, 47);
            label1.TabIndex = 53;
            label1.Text = "TOTAL BALANCE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(192, 22);
            label4.TabIndex = 52;
            label4.Text = "MOVING FORWARD";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 88);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(395, 66);
            label8.Name = "label8";
            label8.Size = new Size(290, 47);
            label8.TabIndex = 50;
            label8.Text = "ADMIN PANEL";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Bell MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(739, 506);
            button1.Name = "button1";
            button1.Size = new Size(337, 63);
            button1.TabIndex = 57;
            button1.Text = "USER DETAILS";
            button1.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 581);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button1;
    }
}
namespace SE_bank
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 126);
            label4.Name = "label4";
            label4.Size = new Size(192, 22);
            label4.TabIndex = 43;
            label4.Text = "MOVING FORWARD";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(39, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 88);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(367, 47);
            label8.Name = "label8";
            label8.Size = new Size(462, 47);
            label8.TabIndex = 41;
            label8.Text = "TRANSACTION HISTORY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 174);
            label1.Name = "label1";
            label1.Size = new Size(231, 47);
            label1.TabIndex = 44;
            label1.Text = "DEPOSITS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(649, 174);
            label2.Name = "label2";
            label2.Size = new Size(288, 47);
            label2.TabIndex = 45;
            label2.Text = "WITHDRAWS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(251, 285);
            dataGridView1.TabIndex = 46;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(672, 240);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(251, 285);
            dataGridView2.TabIndex = 47;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Bell MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(931, 517);
            button2.Name = "button2";
            button2.Size = new Size(167, 52);
            button2.TabIndex = 48;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 581);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Name = "Payments";
            Text = "Payments";
            Load += Payments_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button2;
    }
}
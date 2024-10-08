namespace SE_bank
{
    partial class User_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Details));
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(305, 338);
            dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(379, 37);
            label8.Name = "label8";
            label8.Size = new Size(267, 47);
            label8.TabIndex = 51;
            label8.Text = "USER DETAILS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 173);
            label1.Name = "label1";
            label1.Size = new Size(102, 43);
            label1.TabIndex = 52;
            label1.Text = "IBAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(195, 173);
            label2.Name = "label2";
            label2.Size = new Size(123, 43);
            label2.TabIndex = 53;
            label2.Text = "NAME";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(451, 161);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(621, 338);
            dataGridView2.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(465, 173);
            label3.Name = "label3";
            label3.Size = new Size(178, 43);
            label3.TabIndex = 55;
            label3.Text = "DEPOSITS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(826, 173);
            label4.Name = "label4";
            label4.Size = new Size(229, 43);
            label4.TabIndex = 56;
            label4.Text = "WITHDRAWS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(451, 516);
            label5.Name = "label5";
            label5.Size = new Size(359, 43);
            label5.TabIndex = 57;
            label5.Text = "CURRENT BALANCE:";
            // 
            // User_Details
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 581);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Name = "User_Details";
            Text = "User_Details";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label8;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
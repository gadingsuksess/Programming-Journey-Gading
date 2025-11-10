namespace ProjectAkhir_Gading
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            btnloginmenu = new Button();
            txtpassword = new TextBox();
            label3 = new Label();
            txtnama = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnloginmenu);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtnama);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(656, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 639);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(57, 450);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 10);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(57, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 10);
            panel3.TabIndex = 2;
            // 
            // btnloginmenu
            // 
            btnloginmenu.BackColor = Color.FromArgb(128, 255, 255);
            btnloginmenu.Location = new Point(132, 497);
            btnloginmenu.Name = "btnloginmenu";
            btnloginmenu.Size = new Size(281, 49);
            btnloginmenu.TabIndex = 6;
            btnloginmenu.Text = "LOGN IN";
            btnloginmenu.UseVisualStyleBackColor = false;
            btnloginmenu.Click += button1_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(132, 390);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(281, 31);
            txtpassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 349);
            label3.Name = "label3";
            label3.Size = new Size(157, 28);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(132, 215);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(281, 31);
            txtnama.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 171);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(57, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 10);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 56);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(850, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1832, 788);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnloginmenu;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtnama;
        private Label label2;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
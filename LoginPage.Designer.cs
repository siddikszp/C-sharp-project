namespace login_2
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            panel2 = new Panel();
            Showpass = new CheckBox();
            panel5 = new Panel();
            panel4 = new Panel();
            Login = new Label();
            groupBox1 = new GroupBox();
            txtpassword = new TextBox();
            label4 = new Label();
            txtuserID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 85, 64);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 486);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Showpass);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(txtpassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtuserID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(58, 69);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 350);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Showpass
            // 
            Showpass.AutoSize = true;
            Showpass.Font = new Font("Cambria", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Showpass.ForeColor = Color.FromArgb(55, 85, 64);
            Showpass.Location = new Point(16, 242);
            Showpass.Margin = new Padding(3, 2, 3, 2);
            Showpass.Name = "Showpass";
            Showpass.Size = new Size(108, 18);
            Showpass.TabIndex = 13;
            Showpass.Text = "Show Password";
            Showpass.UseVisualStyleBackColor = true;
            Showpass.CheckedChanged += Showpass_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(417, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(367, 350);
            panel5.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(26, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 45);
            panel4.TabIndex = 11;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(55, 85, 64);
            Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonFace;
            Login.Location = new Point(16, 280);
            Login.Name = "Login";
            Login.Size = new Size(301, 25);
            Login.TabIndex = 10;
            Login.Text = "SIGN IN";
            Login.TextAlign = ContentAlignment.MiddleCenter;
            Login.Click += Login_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(472, 140);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(7, 6);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Location = new Point(16, 212);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(301, 23);
            txtpassword.TabIndex = 6;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(55, 85, 64);
            label4.Location = new Point(16, 188);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtuserID
            // 
            txtuserID.BorderStyle = BorderStyle.FixedSingle;
            txtuserID.Location = new Point(16, 135);
            txtuserID.Margin = new Padding(3, 2, 3, 2);
            txtuserID.Name = "txtuserID";
            txtuserID.Size = new Size(301, 23);
            txtuserID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(55, 84, 64);
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 3;
            label3.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 85, 64);
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 2;
            label2.Text = "WELCOME BACK!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 85, 64);
            label1.Location = new Point(171, 10);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 85, 64);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 44);
            panel3.TabIndex = 0;
            // 
            // LoginPage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 486);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Login;
        private GroupBox groupBox1;
        private TextBox txtpassword;
        private Label label4;
        private TextBox txtuserID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox Showpass;
    }
}

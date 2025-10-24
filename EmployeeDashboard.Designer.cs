namespace login_2
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            panelHeader = new Panel();
            TitleLabel = new Label();
            Logoutbtn = new Button();
            LeftPanel = new Panel();
            pictureBox1 = new PictureBox();
            UpInformationButton = new Button();
            btnManageProducts = new Button();
            SellButton = new Button();
            pictureBox2 = new PictureBox();
            EmpInfoName = new Label();
            EmpID = new Label();
            txtEmpname = new TextBox();
            txtempID = new TextBox();
            lblwelcome = new Label();
            panelHeader.SuspendLayout();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightGreen;
            panelHeader.Controls.Add(TitleLabel);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1050, 45);
            panelHeader.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(18, 11);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(324, 22);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "\"Employee Dashboard - Jersey Shop\"";
            // 
            // Logoutbtn
            // 
            Logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.Location = new Point(936, 9);
            Logoutbtn.Margin = new Padding(3, 2, 3, 2);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(88, 26);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = true;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.MediumSeaGreen;
            LeftPanel.Controls.Add(pictureBox1);
            LeftPanel.Controls.Add(UpInformationButton);
            LeftPanel.Controls.Add(btnManageProducts);
            LeftPanel.Controls.Add(SellButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 45);
            LeftPanel.Margin = new Padding(3, 2, 3, 2);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(234, 480);
            LeftPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, -34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 174);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UpInformationButton
            // 
            UpInformationButton.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpInformationButton.Image = (Image)resources.GetObject("UpInformationButton.Image");
            UpInformationButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpInformationButton.Location = new Point(10, 327);
            UpInformationButton.Margin = new Padding(3, 2, 3, 2);
            UpInformationButton.Name = "UpInformationButton";
            UpInformationButton.Size = new Size(207, 54);
            UpInformationButton.TabIndex = 3;
            UpInformationButton.Text = "Update Information";
            UpInformationButton.TextAlign = ContentAlignment.MiddleRight;
            UpInformationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpInformationButton.UseVisualStyleBackColor = true;
            UpInformationButton.Click += UpdateInformation_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProducts.Image = (Image)resources.GetObject("btnManageProducts.Image");
            btnManageProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageProducts.Location = new Point(10, 247);
            btnManageProducts.Margin = new Padding(3, 2, 3, 2);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(207, 54);
            btnManageProducts.TabIndex = 1;
            btnManageProducts.Text = "View Inventory";
            btnManageProducts.TextAlign = ContentAlignment.MiddleRight;
            btnManageProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += ManageProducts_Click;
            // 
            // SellButton
            // 
            SellButton.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellButton.Image = (Image)resources.GetObject("SellButton.Image");
            SellButton.ImageAlign = ContentAlignment.MiddleLeft;
            SellButton.Location = new Point(10, 166);
            SellButton.Margin = new Padding(3, 2, 3, 2);
            SellButton.Name = "SellButton";
            SellButton.Size = new Size(207, 54);
            SellButton.TabIndex = 0;
            SellButton.Text = " Sell products";
            SellButton.TextAlign = ContentAlignment.MiddleRight;
            SellButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SellButton.UseVisualStyleBackColor = true;
            SellButton.Click += SellButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(474, 52);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // EmpInfoName
            // 
            EmpInfoName.BackColor = Color.Transparent;
            EmpInfoName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpInfoName.Location = new Point(409, 292);
            EmpInfoName.Name = "EmpInfoName";
            EmpInfoName.Size = new Size(168, 19);
            EmpInfoName.TabIndex = 4;
            EmpInfoName.Text = "Employee Name:";
            // 
            // EmpID
            // 
            EmpID.BackColor = Color.Transparent;
            EmpID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpID.Location = new Point(409, 339);
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(168, 19);
            EmpID.TabIndex = 5;
            EmpID.Text = "Employee ID:";
            // 
            // txtEmpname
            // 
            txtEmpname.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmpname.Location = new Point(564, 292);
            txtEmpname.Margin = new Padding(3, 2, 3, 2);
            txtEmpname.Multiline = true;
            txtEmpname.Name = "txtEmpname";
            txtEmpname.ReadOnly = true;
            txtEmpname.Size = new Size(265, 26);
            txtEmpname.TabIndex = 6;
            // 
            // txtempID
            // 
            txtempID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtempID.Location = new Point(564, 339);
            txtempID.Margin = new Padding(3, 2, 3, 2);
            txtempID.Multiline = true;
            txtempID.Name = "txtempID";
            txtempID.ReadOnly = true;
            txtempID.Size = new Size(265, 26);
            txtempID.TabIndex = 7;
            // 
            // lblwelcome
            // 
            lblwelcome.BackColor = Color.Transparent;
            lblwelcome.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(474, 244);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(242, 28);
            lblwelcome.TabIndex = 8;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1050, 525);
            Controls.Add(lblwelcome);
            Controls.Add(txtempID);
            Controls.Add(txtEmpname);
            Controls.Add(EmpID);
            Controls.Add(EmpInfoName);
            Controls.Add(pictureBox2);
            Controls.Add(LeftPanel);
            Controls.Add(Logoutbtn);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += EmployeeDashboard_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label TitleLabel;
        private Button Logoutbtn;
        private Panel LeftPanel;
        private Button SellButton;
        private Button UpInformationButton;
        private Button btnManageProducts;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label EmpInfoName;
        private Label EmpID;
        private TextBox txtEmpname;
        private TextBox txtempID;
        private Label lblwelcome;
    }
}

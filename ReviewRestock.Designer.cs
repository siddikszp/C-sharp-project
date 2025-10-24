namespace login_2
{
    partial class ReviewRestock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewRestock));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvRequests = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            txtQuantity = new TextBox();
            btnClear = new Button();
            lblQuantity = new Label();
            btnUpdateDetails = new Button();
            cmbSize = new ComboBox();
            txtJerseyID = new TextBox();
            txtRequestID = new TextBox();
            lblSize = new Label();
            lblJerseyID = new Label();
            lblRequestID = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(55, 85, 64);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1068, 68);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(972, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 41);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(95, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(164, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Review Restock";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = SystemColors.ActiveCaptionText;
            lblSearch.Location = new Point(429, 144);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 18);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(496, 144);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(143, 25);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 85, 64);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(496, 182);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(55, 85, 64);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(612, 537);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 31);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.GridColor = SystemColors.Window;
            dgvRequests.Location = new Point(406, 286);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(574, 206);
            dgvRequests.TabIndex = 5;
            dgvRequests.CellClick += dgvRequests_CellClick;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            dgvRequests.SelectionChanged += dgvRequests_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 85, 64);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(415, 535);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 33);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(55, 85, 64);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(512, 535);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 33);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.None;
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Controls.Add(btnUpdateDetails);
            groupBox1.Controls.Add(cmbSize);
            groupBox1.Controls.Add(txtJerseyID);
            groupBox1.Controls.Add(txtRequestID);
            groupBox1.Controls.Add(lblSize);
            groupBox1.Controls.Add(lblJerseyID);
            groupBox1.Controls.Add(lblRequestID);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 393);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFO's";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(120, 207);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(94, 29);
            txtQuantity.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(55, 85, 64);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(194, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 39);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(39, 215);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(60, 15);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity";
            // 
            // btnUpdateDetails
            // 
            btnUpdateDetails.BackColor = Color.FromArgb(55, 85, 64);
            btnUpdateDetails.FlatAppearance.BorderSize = 0;
            btnUpdateDetails.FlatStyle = FlatStyle.Flat;
            btnUpdateDetails.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateDetails.ForeColor = SystemColors.ControlLightLight;
            btnUpdateDetails.Location = new Point(39, 330);
            btnUpdateDetails.Name = "btnUpdateDetails";
            btnUpdateDetails.Size = new Size(109, 39);
            btnUpdateDetails.TabIndex = 9;
            btnUpdateDetails.Text = "Update  Details";
            btnUpdateDetails.UseVisualStyleBackColor = false;
            btnUpdateDetails.Click += btnUpdateDetails_Click;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(120, 149);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(94, 29);
            cmbSize.TabIndex = 9;
            // 
            // txtJerseyID
            // 
            txtJerseyID.Location = new Point(120, 98);
            txtJerseyID.Name = "txtJerseyID";
            txtJerseyID.ReadOnly = true;
            txtJerseyID.Size = new Size(94, 29);
            txtJerseyID.TabIndex = 6;
            // 
            // txtRequestID
            // 
            txtRequestID.Location = new Point(120, 50);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.ReadOnly = true;
            txtRequestID.Size = new Size(94, 29);
            txtRequestID.TabIndex = 5;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(39, 157);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(31, 15);
            lblSize.TabIndex = 4;
            lblSize.Text = "Size";
            // 
            // lblJerseyID
            // 
            lblJerseyID.AutoSize = true;
            lblJerseyID.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJerseyID.Location = new Point(39, 106);
            lblJerseyID.Name = "lblJerseyID";
            lblJerseyID.Size = new Size(61, 15);
            lblJerseyID.TabIndex = 1;
            lblJerseyID.Text = "Jersey ID";
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequestID.ForeColor = SystemColors.WindowText;
            lblRequestID.Location = new Point(39, 58);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(74, 15);
            lblRequestID.TabIndex = 0;
            lblRequestID.Text = "Request ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(406, 258);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 11;
            label1.Text = "Restock Requests";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 85, 64);
            panel1.Location = new Point(12, 508);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 60);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 85, 64);
            panel2.Location = new Point(12, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 29);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 85, 64);
            panel3.Location = new Point(1012, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(42, 494);
            panel3.TabIndex = 14;
            // 
            // ReviewRestock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1066, 606);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvRequests);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReviewRestock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReviewRestock";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Button btnBack;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvRequests;
        private Button btnAdd;
        private Button btnDelete;
        private GroupBox groupBox1;
        private Label lblSize;
        private Label lblJerseyID;
        private Label lblRequestID;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private ComboBox cmbSize;
        private TextBox txtJerseyID;
        private TextBox txtRequestID;
        private Button btnUpdateDetails;
        private Button btnClear;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
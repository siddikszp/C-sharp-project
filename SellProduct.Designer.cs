namespace login_2
{
    partial class SellProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellProduct));
            panelHeader = new Panel();
            TitleLabel = new Label();
            Logoutbtn = new Button();
            panelsearch = new Panel();
            comboBox1 = new ComboBox();
            labelsort = new Label();
            searchTextBox = new TextBox();
            labelsearch = new Label();
            ProcessToSaleBtn = new Button();
            button2 = new Button();
            dgvProduct = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            dgvCart = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            totalpricelbl = new Label();
            JerseyID = new DataGridViewTextBoxColumn();
            JerseyName = new DataGridViewTextBoxColumn();
            TeamName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            JerseyQuantity = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.RosyBrown;
            panelHeader.Controls.Add(TitleLabel);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1050, 45);
            panelHeader.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(331, 10);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(310, 26);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "WELCOME TO THE SELL PAGE";
            // 
            // Logoutbtn
            // 
            Logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.Location = new Point(936, 9);
            Logoutbtn.Margin = new Padding(3, 2, 3, 2);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(88, 26);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "BACK";
            Logoutbtn.UseVisualStyleBackColor = true;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // panelsearch
            // 
            panelsearch.BackColor = Color.Teal;
            panelsearch.Controls.Add(comboBox1);
            panelsearch.Controls.Add(labelsort);
            panelsearch.Controls.Add(searchTextBox);
            panelsearch.Controls.Add(labelsearch);
            panelsearch.Location = new Point(0, 50);
            panelsearch.Margin = new Padding(3, 2, 3, 2);
            panelsearch.Name = "panelsearch";
            panelsearch.Size = new Size(1050, 52);
            panelsearch.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 14);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += SortCombobox;
            // 
            // labelsort
            // 
            labelsort.AutoSize = true;
            labelsort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsort.Location = new Point(262, 15);
            labelsort.Name = "labelsort";
            labelsort.Size = new Size(31, 15);
            labelsort.TabIndex = 2;
            labelsort.Text = "Sort";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(70, 14);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(176, 20);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += productGridSearch;
            searchTextBox.KeyDown += searchTextBox_KeyDown;
            // 
            // labelsearch
            // 
            labelsearch.AutoSize = true;
            labelsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsearch.Location = new Point(18, 15);
            labelsearch.Name = "labelsearch";
            labelsearch.Size = new Size(54, 19);
            labelsearch.TabIndex = 0;
            labelsearch.Text = "Search";
            // 
            // ProcessToSaleBtn
            // 
            ProcessToSaleBtn.AutoSize = true;
            ProcessToSaleBtn.BackColor = Color.Aqua;
            ProcessToSaleBtn.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcessToSaleBtn.Location = new Point(919, 445);
            ProcessToSaleBtn.Margin = new Padding(3, 2, 3, 2);
            ProcessToSaleBtn.Name = "ProcessToSaleBtn";
            ProcessToSaleBtn.Size = new Size(121, 34);
            ProcessToSaleBtn.TabIndex = 6;
            ProcessToSaleBtn.Text = "Proceed to sale";
            ProcessToSaleBtn.UseVisualStyleBackColor = false;
            ProcessToSaleBtn.Click += ProcessToSaleBtn_work;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(926, 120);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 30);
            button2.TabIndex = 7;
            button2.Text = "ADD TO CART";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddToCart_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.Teal;
            dgvProduct.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(0, 106);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(906, 191);
            dgvProduct.TabIndex = 9;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(926, 170);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 30);
            button1.TabIndex = 10;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += removebtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCart);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 302);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 132);
            panel1.TabIndex = 11;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.BackgroundColor = Color.MistyRose;
            dgvCart.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { JerseyID, JerseyName, TeamName, UnitPrice, Size, JerseyQuantity });
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(0, 26);
            dgvCart.Margin = new Padding(3, 2, 3, 2);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1050, 106);
            dgvCart.TabIndex = 1;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // label1
            // 
            label1.BackColor = Color.LightPink;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1050, 26);
            label1.TabIndex = 0;
            label1.Text = "         ITEM CART";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 448);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 13;
            label2.Text = "Total Price:";
            // 
            // totalpricelbl
            // 
            totalpricelbl.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalpricelbl.Location = new Point(108, 448);
            totalpricelbl.Name = "totalpricelbl";
            totalpricelbl.Size = new Size(222, 20);
            totalpricelbl.TabIndex = 14;
            // 
            // JerseyID
            // 
            JerseyID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            JerseyID.HeaderText = "JerseyID";
            JerseyID.MinimumWidth = 6;
            JerseyID.Name = "JerseyID";
            JerseyID.ReadOnly = true;
            // 
            // JerseyName
            // 
            JerseyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            JerseyName.HeaderText = "Name";
            JerseyName.MinimumWidth = 6;
            JerseyName.Name = "JerseyName";
            JerseyName.ReadOnly = true;
            // 
            // TeamName
            // 
            TeamName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TeamName.HeaderText = "Team";
            TeamName.MinimumWidth = 6;
            TeamName.Name = "TeamName";
            TeamName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Size
            // 
            Size.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // JerseyQuantity
            // 
            JerseyQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            JerseyQuantity.HeaderText = "Quantity";
            JerseyQuantity.MinimumWidth = 6;
            JerseyQuantity.Name = "JerseyQuantity";
            JerseyQuantity.ReadOnly = true;
            // 
            // SellProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1050, 492);
            Controls.Add(totalpricelbl);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(dgvProduct);
            Controls.Add(panelsearch);
            Controls.Add(button2);
            Controls.Add(ProcessToSaleBtn);
            Controls.Add(Logoutbtn);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SellProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SELL PRODUCT DASHBOARD";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelsearch.ResumeLayout(false);
            panelsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label TitleLabel;
        private Button Logoutbtn;
        private Panel panelsearch;
        private ComboBox comboBox1;
        private Label labelsort;
        private TextBox searchTextBox;
        private Label labelsearch;
        private Button ProcessToSaleBtn;
        private Button button2;
        private DataGridView dgvProduct;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvCart;
        private Label label2;
        private Label totalpricelbl;
        private DataGridViewTextBoxColumn JerseyID;
        private DataGridViewTextBoxColumn JerseyName;
        private DataGridViewTextBoxColumn TeamName;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn JerseyQuantity;
    }
}

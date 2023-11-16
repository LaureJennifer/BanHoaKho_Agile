namespace App_QuanLiDuAn_Agile
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            SearchBtn = new Button();
            timKiemTxt = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            QuantityTxt = new TextBox();
            PriceTxt = new TextBox();
            NameTxt = new TextBox();
            IdTxt = new TextBox();
            ThemBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            HienthiBtn = new Button();
            ResetFormBtn = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lstDgrid = new DataGridView();
            SortByPriceBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstDgrid).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(SearchBtn);
            groupBox1.Controls.Add(timKiemTxt);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID ", "Tên sản phẩm ", "Giá nhập" });
            comboBox1.Location = new Point(537, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(66, 23);
            comboBox1.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(620, 22);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(109, 20);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm kiếm ";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // timKiemTxt
            // 
            timKiemTxt.Location = new Point(15, 22);
            timKiemTxt.Name = "timKiemTxt";
            timKiemTxt.Size = new Size(508, 23);
            timKiemTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(QuantityTxt);
            groupBox2.Controls.Add(PriceTxt);
            groupBox2.Controls.Add(NameTxt);
            groupBox2.Controls.Add(IdTxt);
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 262);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 198);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 6;
            label4.Text = "Số lượng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 147);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 5;
            label3.Text = "Giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 4;
            label2.Text = "Tên sản phẩm ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 51);
            label1.Name = "label1";
            label1.Size = new Size(21, 17);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // QuantityTxt
            // 
            QuantityTxt.Location = new Point(128, 195);
            QuantityTxt.Name = "QuantityTxt";
            QuantityTxt.Size = new Size(395, 23);
            QuantityTxt.TabIndex = 2;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(128, 141);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(395, 23);
            PriceTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(128, 93);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(395, 23);
            NameTxt.TabIndex = 0;
            // 
            // IdTxt
            // 
            IdTxt.Location = new Point(128, 48);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(395, 23);
            IdTxt.TabIndex = 0;
            // 
            // ThemBtn
            // 
            ThemBtn.Location = new Point(567, 128);
            ThemBtn.Name = "ThemBtn";
            ThemBtn.Size = new Size(154, 30);
            ThemBtn.TabIndex = 2;
            ThemBtn.Text = "Thêm ";
            ThemBtn.UseVisualStyleBackColor = true;
            ThemBtn.Click += ThemBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(567, 171);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(154, 30);
            UpdateBtn.TabIndex = 3;
            UpdateBtn.Text = "Sửa";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(567, 216);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(154, 30);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Xóa ";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // HienthiBtn
            // 
            HienthiBtn.Location = new Point(567, 260);
            HienthiBtn.Name = "HienthiBtn";
            HienthiBtn.Size = new Size(154, 30);
            HienthiBtn.TabIndex = 5;
            HienthiBtn.Text = "Hiển thị ";
            HienthiBtn.UseVisualStyleBackColor = true;
            HienthiBtn.Click += HienthiBtn_Click;
            // 
            // ResetFormBtn
            // 
            ResetFormBtn.Location = new Point(567, 360);
            ResetFormBtn.Name = "ResetFormBtn";
            ResetFormBtn.Size = new Size(154, 30);
            ResetFormBtn.TabIndex = 6;
            ResetFormBtn.Text = "Reset ";
            ResetFormBtn.UseVisualStyleBackColor = true;
            ResetFormBtn.Click += ResetFormBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(12, 398);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(725, 178);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bảng mặt hàng bán chạy";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lstDgrid, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(703, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lstDgrid
            // 
            lstDgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstDgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstDgrid.Location = new Point(3, 3);
            lstDgrid.Name = "lstDgrid";
            lstDgrid.RowHeadersWidth = 51;
            lstDgrid.RowTemplate.Height = 25;
            lstDgrid.Size = new Size(697, 144);
            lstDgrid.TabIndex = 0;
            lstDgrid.CellClick += lstDgrid_CellClick;
            // 
            // SortByPriceBtn
            // 
            SortByPriceBtn.Location = new Point(567, 305);
            SortByPriceBtn.Name = "SortByPriceBtn";
            SortByPriceBtn.Size = new Size(154, 30);
            SortByPriceBtn.TabIndex = 8;
            SortByPriceBtn.Text = "Sắp xếp";
            SortByPriceBtn.UseVisualStyleBackColor = true;
            SortByPriceBtn.Click += SortByPriceBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(759, 588);
            Controls.Add(SortByPriceBtn);
            Controls.Add(groupBox3);
            Controls.Add(ResetFormBtn);
            Controls.Add(HienthiBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ThemBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lstDgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox timKiemTxt;
        private GroupBox groupBox2;
        private Button SearchBtn;
        private Button ThemBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button HienthiBtn;
        private Button ResetFormBtn;
        private Label label1;
        private TextBox QuantityTxt;
        private TextBox PriceTxt;
        private TextBox NameTxt;
        private TextBox IdTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView lstDgrid;
        private Button SortByPriceBtn;
    }
}
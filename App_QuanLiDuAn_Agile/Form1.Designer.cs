﻿namespace App_QuanLiDuAn_Agile
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
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            QuantityTxt = new TextBox();
            PriceTxt = new TextBox();
            NameTxt = new TextBox();
            IdTxt = new TextBox();
            button2 = new Button();
            button3 = new Button();
            DeleteBtn = new Button();
            button5 = new Button();
            ResetFormBtn = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dvg = new DataGridView();
            SortByPriceBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(14, 60);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(840, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID ", "Tên sản phẩm ", "Giá nhập" });
            comboBox1.Location = new Point(614, 31);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(709, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 27);
            button1.TabIndex = 1;
            button1.Text = "Tìm kiếm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 29);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(580, 27);
            textBox1.TabIndex = 0;
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
            groupBox2.Location = new Point(14, 171);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(623, 349);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 264);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 6;
            label4.Text = "Số lượng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 196);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 5;
            label3.Text = "Giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 128);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 4;
            label2.Text = "Tên sản phẩm ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 68);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // QuantityTxt
            // 
            QuantityTxt.Location = new Point(146, 260);
            QuantityTxt.Margin = new Padding(3, 4, 3, 4);
            QuantityTxt.Name = "QuantityTxt";
            QuantityTxt.Size = new Size(451, 27);
            QuantityTxt.TabIndex = 2;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(146, 188);
            PriceTxt.Margin = new Padding(3, 4, 3, 4);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(451, 27);
            PriceTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(146, 124);
            NameTxt.Margin = new Padding(3, 4, 3, 4);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(451, 27);
            NameTxt.TabIndex = 0;
            // 
            // IdTxt
            // 
            IdTxt.Location = new Point(146, 64);
            IdTxt.Margin = new Padding(3, 4, 3, 4);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(451, 27);
            IdTxt.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(648, 171);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(176, 40);
            button2.TabIndex = 2;
            button2.Text = "Thêm ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(648, 228);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(176, 40);
            button3.TabIndex = 3;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(648, 288);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(176, 40);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Xóa ";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(648, 346);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(176, 40);
            button5.TabIndex = 5;
            button5.Text = "Hiển thị ";
            button5.UseVisualStyleBackColor = true;
            // 
            // ResetFormBtn
            // 
            ResetFormBtn.Location = new Point(648, 480);
            ResetFormBtn.Margin = new Padding(3, 4, 3, 4);
            ResetFormBtn.Name = "ResetFormBtn";
            ResetFormBtn.Size = new Size(176, 40);
            ResetFormBtn.TabIndex = 6;
            ResetFormBtn.Text = "Reset ";
            ResetFormBtn.UseVisualStyleBackColor = true;
            ResetFormBtn.Click += ResetFormBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(14, 531);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(829, 237);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bảng mặt hàng bán chạy";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dvg, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 29);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(803, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dvg
            // 
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Location = new Point(3, 4);
            dvg.Margin = new Padding(3, 4, 3, 4);
            dvg.Name = "dvg";
            dvg.RowHeadersWidth = 51;
            dvg.RowTemplate.Height = 25;
            dvg.Size = new Size(797, 192);
            dvg.TabIndex = 0;
            // 
            // SortByPriceBtn
            // 
            SortByPriceBtn.Location = new Point(648, 407);
            SortByPriceBtn.Margin = new Padding(3, 4, 3, 4);
            SortByPriceBtn.Name = "SortByPriceBtn";
            SortByPriceBtn.Size = new Size(176, 40);
            SortByPriceBtn.TabIndex = 8;
            SortByPriceBtn.Text = "Sắp xếp";
            SortByPriceBtn.UseVisualStyleBackColor = true;
            SortByPriceBtn.Click += SortByPriceBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(867, 784);
            Controls.Add(SortByPriceBtn);
            Controls.Add(groupBox3);
            Controls.Add(ResetFormBtn);
            Controls.Add(button5);
            Controls.Add(DeleteBtn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button DeleteBtn;
        private Button button5;
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
        private DataGridView dvg;
        private Button SortByPriceBtn;
    }
}
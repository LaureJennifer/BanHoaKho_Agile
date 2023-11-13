namespace App_QuanLiDuAn_Agile
{
    partial class Form2
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
            btnKhach = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKhach
            // 
            btnKhach.Location = new Point(131, 168);
            btnKhach.Name = "btnKhach";
            btnKhach.Size = new Size(225, 74);
            btnKhach.TabIndex = 0;
            btnKhach.Text = "KHÁCH";
            btnKhach.UseVisualStyleBackColor = true;
            btnKhach.Click += btnKhach_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(432, 168);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(225, 74);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 51);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnKhach);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKhach;
        private Button btnAdmin;
        private Label label1;
    }
}
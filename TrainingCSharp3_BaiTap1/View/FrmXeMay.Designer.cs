namespace TrainingCSharp3_BaiTap1.View
{
    partial class FrmXeMay
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cmbSoLuong = new ComboBox();
            txtGiaNhap = new TextBox();
            txtMoTa = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnXoaForm = new Button();
            btnHienThi = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvDSXeMay = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            err = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeMay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSoLuong);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cmbSoLuong
            // 
            cmbSoLuong.FormattingEnabled = true;
            cmbSoLuong.Location = new Point(135, 171);
            cmbSoLuong.Name = "cmbSoLuong";
            cmbSoLuong.Size = new Size(349, 28);
            cmbSoLuong.TabIndex = 7;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(135, 128);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(349, 27);
            txtGiaNhap.TabIndex = 6;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(135, 85);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(349, 27);
            txtMoTa.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(135, 42);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(349, 27);
            txtTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 174);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 131);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXoaForm);
            groupBox2.Controls.Add(btnHienThi);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(537, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(6, 132);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(236, 43);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(6, 185);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(236, 43);
            btnXoaForm.TabIndex = 2;
            btnXoaForm.Text = "Xóa Form";
            btnXoaForm.UseVisualStyleBackColor = true;
            btnXoaForm.Click += btnXoaForm_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(6, 79);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(236, 43);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(236, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDSXeMay);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 252);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(773, 245);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvDSXeMay
            // 
            dgvDSXeMay.BackgroundColor = SystemColors.ActiveCaption;
            dgvDSXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSXeMay.Location = new Point(0, 90);
            dgvDSXeMay.Name = "dgvDSXeMay";
            dgvDSXeMay.RowHeadersWidth = 51;
            dgvDSXeMay.RowTemplate.Height = 29;
            dgvDSXeMay.Size = new Size(773, 155);
            dgvDSXeMay.TabIndex = 8;
            dgvDSXeMay.CellClick += dgvDSXeMay_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(135, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.Size = new Size(612, 27);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 49);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm";
            // 
            // err
            // 
            err.ContainerControl = this;
            err.RightToLeft = true;
            // 
            // FrmXeMay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 509);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmXeMay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmXeMay";
            Load += FrmXeMay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSXeMay).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbSoLuong;
        private TextBox txtGiaNhap;
        private TextBox txtMoTa;
        private TextBox txtTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnXoaForm;
        private Button btnHienThi;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dgvDSXeMay;
        private TextBox txtTimKiem;
        private Label label5;
        private ErrorProvider err;
    }
}
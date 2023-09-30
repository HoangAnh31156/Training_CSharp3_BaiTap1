using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCSharp3_BaiTap1.Controllers.Services;
using TrainingCSharp3_BaiTap1.Models.DomainClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainingCSharp3_BaiTap1.View
{
    public partial class FrmXeMay : Form
    {
        XeMayService _service;
        Guid? _idWhenClick;
        public FrmXeMay()
        {
            InitializeComponent();
            _service = new XeMayService();
        }
        private void FrmXeMay_Load(object sender, EventArgs e)
        {
            cmbSoLuong.Items.Add("Từ 1 đến 100");
            for (int i = 1; i <= 100; i++)
            {
                cmbSoLuong.Items.Add(i);
            }
            cmbSoLuong.SelectedIndex = 0;
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            dgvDSXeMay.ColumnCount = 6;
            dgvDSXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSXeMay.Columns[0].Visible = false;
            dgvDSXeMay.Columns[1].Name = "STT";
            dgvDSXeMay.Columns[2].Name = "Tên xe";
            dgvDSXeMay.Columns[3].Name = "Mô tả";
            dgvDSXeMay.Columns[4].Name = "Số lượng";
            dgvDSXeMay.Columns[5].Name = "Tên loại xe";
            dgvDSXeMay.Rows.Clear();
            foreach (var item in _service.GetXeMays(input))
            {
                var result = _service.GetLoaiXms().FirstOrDefault(x => x.Id == item.IdLxm);
                dgvDSXeMay.Rows.Add(item.Id, stt++, item.Ten, item.Mota, item.SoLuong, (result != null ? result.Ten : "Xe Fa Ke"));
            }
        }
        private void dgvDSXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _service.GetXeMays(null).Count)
                return;
            _idWhenClick = Guid.Parse(dgvDSXeMay.Rows[index].Cells[0].Value.ToString());
            var xm = _service.GetXeMays(null).FirstOrDefault(x => x.Id == _idWhenClick);
            xm.Ten = txtTen.Text;
            xm.Mota = txtMoTa.Text;
            //xm.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            xm.SoLuong = cmbSoLuong.SelectedIndex;
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadGrid(null);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                XeMay newXM = new XeMay()
                {
                    Ten = txtTen.Text,
                    Mota = txtMoTa.Text,
                    GiaNhap = Convert.ToInt32(txtGiaNhap.Text),
                    SoLuong = cmbSoLuong.SelectedIndex,
                };
                _service.AddXeMay(newXM);
            }

            LoadGrid(null);
            //_idWhenClick = null;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _service.DeleteXeMay(_idWhenClick);
            LoadGrid(null);
        }
        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtTen.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
            cmbSoLuong.SelectedIndex = 5;
            txtTimKiem.Text = string.Empty;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                LoadGrid(null);
            }
            else
            {
                LoadGrid(txtTimKiem.Text);
            }
        }
        public bool CheckRegexText()
        {
            err.SetError(txtTen, "");

            err.SetError(txtGiaNhap, "");
            err.SetError(cmbSoLuong, "");
            if (txtTen.Text.Length == 0)
            {
                err.SetError(txtTen, "Không được bỏ trống tên !");
                return false;
            }

            if (txtGiaNhap.Text.Length == 0)
            {
                err.SetError(txtGiaNhap, "Không được bỏ trống giá nhập !");
                return false;
            }
            else if (!Regex.IsMatch(txtGiaNhap.Text, @"^[\d]+$"))
            {
                err.SetError(txtGiaNhap, "Chỉ được nhập số (giá phải là số nguyên dương)!");
                return false;
            }

            if (cmbSoLuong.SelectedIndex == 0)
            {
                err.SetError(cmbSoLuong, "Phải chọn số lượng !");
                return false;
            }
            if (txtMoTa.Text.Length == 0)
            {
                txtMoTa.Text = "Chưa có thông tin";
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tính_tiền_điện
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtlabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTienDien_Click(object sender, EventArgs e)
        {
            int thangTruoc, thangNay;

            if (!int.TryParse(txtnhapsodienthangtruoc.Text, out thangTruoc) ||
                !int.TryParse(txtnhapsodienthangnay.Text, out thangNay))
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện hợp lệ!");
                return;
            }

            if (thangTruoc < 0 || thangNay < thangTruoc)
            {
                MessageBox.Show("Chỉ số điện không hợp lệ!");
                return;
            }

            int tieuThu = thangNay - thangTruoc;
            decimal tienDien;

            if (tieuThu <= 50)
                tienDien = tieuThu * 1000m;
            else if (tieuThu <= 100)
                tienDien = 50 * 1000m + (tieuThu - 50) * 1200m;
            else if (tieuThu <= 200)
                tienDien = 50 * 1000m + 50 * 1200m
                         + (tieuThu - 100) * 1800m;
            else
                tienDien = 50 * 1000m + 50 * 1200m
                         + 100 * 1800m + (tieuThu - 200) * 3500m;

            decimal vat = tienDien * 0.08m;
            decimal tienDong = tienDien + vat;

            txtsodientieuthu.Text = tieuThu.ToString("N0");
            txttiendien.Text = tienDien.ToString("N0");
            txtVAT.Text = vat.ToString("N0");
            txttiendong.Text = tienDong.ToString("N0");
        }
    }
}

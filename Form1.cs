using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.Add(txtTen.Text);
            txtTen.Text = string.Empty;

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbketqua.Items.Add("AN\t lỏ"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.RemoveAt(lsbketqua.SelectedIndex);
        }
    }
}

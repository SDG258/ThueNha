using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueNha.Models;

namespace ThueNha
{
    public partial class DanhSachNhaChoThue : Form
    {
        public DanhSachNhaChoThue()
        {
            InitializeComponent();
        }

        private void DanhSachNhaChoThue_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DanhSachNhaChoThue_Load_1(object sender, EventArgs e)
        {
            NhaChoThue nhaChoThue = new ThueNhaContext().NhaChoThues.FirstOrDefault(status => status.TrangThaiChoThue == 0);
        }
    }
}

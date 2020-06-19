using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamVanLeBao_2001170836_BTVN5
{
    public partial class frmNhomNguoiDung : Form
    {
        public frmNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void ql_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ql_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ql_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.ql_NhomNguoiDungTableAdapter.Fill(this.dataSet1.ql_NhomNguoiDung);

        }
    }
}

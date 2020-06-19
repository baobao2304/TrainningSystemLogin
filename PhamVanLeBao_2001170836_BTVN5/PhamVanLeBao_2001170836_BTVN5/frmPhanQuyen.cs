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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void ql_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ql_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dataSet1.DataTable2);
            // TODO: This line of code loads data into the 'dataSet1.ql_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.ql_NhomNguoiDungTableAdapter.Fill(this.dataSet1.ql_NhomNguoiDung);

        }
        string lb11, lb22, lb33;
        private void ql_NhomNguoiDungDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1;
            if (e.RowIndex >= 0)
            {
                row1 = this.ql_NhomNguoiDungDataGridView.Rows[e.RowIndex];
                lb11 = row1.Cells[0].Value.ToString();
                lb22 = row1.Cells[1].Value.ToString();
                lb33 = row1.Cells[2].Value.ToString();

            }
            this.dataTable2TableAdapter.FillBy(dataSet1.DataTable2, lb11);
        }
    }
}

using PhamVanLeBao_2001170836_BTVN5.DataSet1TableAdapters;
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
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void ql_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ql_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ql_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.ql_NguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSet1.ql_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.ql_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.ql_NhomNguoiDungTableAdapter.Fill(this.dataSet1.ql_NhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.ql_NguoiDung' table. You can move, or remove it, as needed.
            this.ql_NguoiDungTableAdapter.Fill(this.dataSet1.ql_NguoiDung);

        }
        string lb1="", lb2, lb3;
        string lb11 = "", lb22, lb33;

        private void ql_NhomNguoiDungComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ql_NhomNguoiDungComboBox.SelectedValue != null)
            {
                this.ql_NguoiDungNhomNguoiDungTableAdapter.Fill_DK(this.dataSet1.ql_NguoiDungNhomNguoiDung, ql_NhomNguoiDungComboBox.SelectedValue.ToString());

                //MessageBox.Show(this.dataTable1TableAdapter.Fill_DK(this.dataSet1.DataTable1, ql_NhomNguoiDungComboBox.SelectedValue.ToString()).ToString());
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.ql_NguoiDungNhomNguoiDungTableAdapter.DeleteQuery(lb11,lb22);
          
        }

        private void ql_NguoiDungNhomNguoiDungDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row1;
            if (e.RowIndex >= 0)
            {
                row1 = this.ql_NguoiDungNhomNguoiDungDataGridView.Rows[e.RowIndex];
                lb11 = row1.Cells[0].Value.ToString();
                lb22 = row1.Cells[1].Value.ToString();
                lb33 = row1.Cells[2].Value.ToString();

            }
            
        }

        private void btnRight_Click_1(object sender, EventArgs e)
        {
            if (lb1 == "")
            {
                MessageBox.Show("Ban chua chon item nao");
                return;
            }
            //MessageBox.Show("l1 :" + lb1);
            //MessageBox.Show("l2 :" + this.ql_NhomNguoiDungComboBox.SelectedValue.ToString());
            MessageBox.Show(this.ql_NguoiDungNhomNguoiDungTableAdapter.FillBy(this.dataSet1.ql_NguoiDungNhomNguoiDung, this.ql_NhomNguoiDungComboBox.SelectedValue.ToString(), lb1).ToString());
            try
            {
                
                if (this.ql_NguoiDungNhomNguoiDungTableAdapter.FillBy(this.dataSet1.ql_NguoiDungNhomNguoiDung, this.ql_NhomNguoiDungComboBox.SelectedValue.ToString(), lb1) == 0)
                {
                    this.ql_NguoiDungNhomNguoiDungTableAdapter.InsertQuery(lb1, this.ql_NhomNguoiDungComboBox.SelectedValue.ToString(),1);
                    MessageBox.Show("Thanh cong");
                    return;
                }
            }
            catch
            {

            }
            MessageBox.Show("That Bai");
        }

        private void ql_NguoiDungDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1;
            if (e.RowIndex >= 0)
            {
                row1 = this.ql_NguoiDungDataGridView.Rows[e.RowIndex];
                lb1 = row1.Cells[0].Value.ToString();
                lb2 = row1.Cells[1].Value.ToString();
                lb3 = row1.Cells[2].Value.ToString();

            }
        }
    }
}

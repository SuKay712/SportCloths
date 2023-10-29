using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DoAn
{
    public partial class SanPham : UserControl
    {
        private DataGridViewRow row1;
        private ProductBLL a = new ProductBLL();
        void Add()
        {
            foreach (Products temp in a.getAll())
            {
                this.dataGridView1.Rows.Add(temp.ID, temp.NameProduct, temp.Cost, temp.Quantity);
            }
        }
        public SanPham()
        {
            InitializeComponent();
            TextReadOnlyTrue();
            HideAdd();
            HideUpdate();
            Add();
            //add1.Hide();
        }

        
        private void ShowInfo()
        {
            bttAdd.Show();
            bttCancel.Show();
            bttUpdate.Show();
            bttDelete.Show();
        }
        private void HideInfo()
        {
            bttAdd.Hide();
            bttCancel.Hide();
            bttUpdate.Hide();
            bttDelete.Hide();
        }
        private void HideAdd()
        {
            bttSave_Add.Hide();
            bttCancel_Add.Hide();
            bttDelete_Add.Hide();
            bttUpdate_Add.Hide();
        }
        private void ShowAdd()
        {
            bttSave_Add.Show();
            bttCancel_Add.Show();
            bttDelete_Add.Show();
            bttUpdate_Add.Show();
        }
        private void TextReadOnLyFalse()
        {
            txtMaSp.Enabled = true;
            txtMaSp.ReadOnly = false;
            txtTenSp.Enabled = true;
            txtTenSp.ReadOnly = false;
            txtGiaSp.Enabled = true;
            txtGiaSp.ReadOnly = false;
            
            txtQuantity.Enabled = true;
            txtQuantity.ReadOnly = false;
            
            
            
            
            
            
        }
        private void TextReadOnlyTrue()

        {
            txtMaSp.Enabled = false;
            txtMaSp.ReadOnly = true;
            txtTenSp.ReadOnly = true;
            txtTenSp.Enabled = false;
            txtGiaSp.ReadOnly = true;
            txtGiaSp.Enabled = false;
            
           
            
            
            txtQuantity.ReadOnly = true;
            txtQuantity.Enabled = false;


        }
        private void ShowUpdate()
        {
            bttAdd_Update.Show();
            bttCancel_Update.Show();
            bttSave_Update.Show();
            bttDelete_Update.Show();

        }
        private void HideUpdate()
        {
            bttAdd_Update.Hide();
            bttCancel_Update.Hide();
            bttSave_Update.Hide();
            bttDelete_Update.Hide();

        }
        private void ClearText()
        {
            txtQuantity.Clear();
            txtGiaSp.Clear();
            txtMaSp.Clear();
            txtTenSp.Clear();
           
        }
        private void bttAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            HideInfo();
            HideUpdate();
            TextReadOnLyFalse();
            ShowAdd();


        }

        private void bttSave_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtMaSp.Text, txtTenSp.Text, txtGiaSp.Text, txtQuantity.Text);
            a.AddProduct(new Products(Int32.Parse(txtMaSp.Text),
                txtTenSp.Text, Int32.Parse(txtGiaSp.Text), Int32.Parse(txtQuantity.Text)));


            TextReadOnlyTrue();
            HideAdd();
            HideUpdate();
            ShowInfo();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row1 = dataGridView1.Rows[e.RowIndex];
            txtMaSp.Text = Convert.ToString(row1.Cells["ID"].Value);
            txtTenSp.Text = Convert.ToString(row1.Cells["NameCl"].Value);
            txtGiaSp.Text = Convert.ToString(row1.Cells["Cost"].Value);
           
            txtQuantity.Text = Convert.ToString(row1.Cells["Quantity"].Value);
            
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            TextReadOnLyFalse();
            HideInfo();
            HideAdd();
            ShowUpdate();
        }

        private void bttSave_Update_Click(object sender, EventArgs e)
        {
            row1 = dataGridView1.CurrentRow;
            row1.Cells["ID"].Value = txtMaSp.Text;
            row1.Cells["NameCl"].Value = txtTenSp.Text;
            row1.Cells["Cost"].Value = txtGiaSp.Text;
            
            row1.Cells["Quantity"].Value = txtQuantity.Text;

            a.UpdateProduct(new Products(Int32.Parse(txtMaSp.Text),
                txtTenSp.Text, Int32.Parse(txtGiaSp.Text), Int32.Parse(txtQuantity.Text)));
            TextReadOnlyTrue();
            HideUpdate();
            ShowInfo();
        }

        private void bttCancel_Update_Click(object sender, EventArgs e)
        {
            ClearText();
            TextReadOnlyTrue();
            HideUpdate();
            ShowInfo();
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            a.DeleteProduct(Int32.Parse(txtMaSp.Text));
            row1 = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(row1);
        }

        private void bttCancel_Add_Click(object sender, EventArgs e)
        {
            ClearText();
            TextReadOnlyTrue();
            HideAdd();
            ShowInfo();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        // init
        CashierDBEntities db = new CashierDBEntities();
        PRODUCT tb_product = new PRODUCT();

        int id;

        public FRM_PRODUCTS()
        {
            InitializeComponent();
        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cashierDBDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.cashierDBDataSet.PRODUCT);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS_ADD frm_products_add = new FRM_PRODUCTS_ADD();
            frm_products_add.btn_add.Text = "Add";
            frm_products_add.id = 0;
            frm_products_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = MessageBox.Show("Are you sure that you want to delete this Row?", "Alert", MessageBoxButtons.YesNoCancel);
                if (rs == DialogResult.Yes)
                {
                    id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    tb_product = db.PRODUCTs.Where(x => x.ProductID == id).FirstOrDefault();
                    db.Entry(tb_product).State = EntityState.Deleted;
                    db.SaveChanges();
                    update_data();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a row to delete it!");
            }
        }

        private void update_data()
        {
            db = new CashierDBEntities();
            dataGridView1.DataSource = db.PRODUCTs.ToList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_PRODUCTS_ADD frm_products_add = new FRM_PRODUCTS_ADD();

                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                tb_product = db.PRODUCTs.Where(x => x.ProductID == id).FirstOrDefault();

                frm_products_add.txt_name.Text = tb_product.ProductName.ToString();
                frm_products_add.txt_barcode.Text = tb_product.ProductBarcode.ToString();
                frm_products_add.cbx_unit.Text = tb_product.UnitID.ToString();
                frm_products_add.cbx_group.Text = tb_product.ProductGoupID.ToString();
                frm_products_add.txt_desc.Text = tb_product.ProductDesc.ToString();

                frm_products_add.btn_add.Text = "Edit";
                frm_products_add.btn_add.Image = Properties.Resources.edit_32_2;
                frm_products_add.id = id;
                frm_products_add.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a row to edit it!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = txt_search.Text;
            dataGridView1.DataSource = db.PRODUCTs.Where(x => x.ProductName.Contains(_search) || x.ProductBarcode.Contains(_search) || x.ProductDesc.Contains(_search)).ToList();
        }
    }
}

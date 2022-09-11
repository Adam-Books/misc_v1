using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem.PL
{
    public partial class FRM_PRODUCTS_ADD : Form
    {
        // init
        CashierDBEntities db = new CashierDBEntities();
        PRODUCT tb_product = new PRODUCT();
        FRM_PRODUCTS frm_products = new FRM_PRODUCTS();

        public int id;

        public FRM_PRODUCTS_ADD()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add OR Edit
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Check if it's add or edit
            if(txt_name.Text == "" || cbx_unit.Text == "" || cbx_group.Text == "")
            {
                MessageBox.Show("The all fields are required", "Alert");
            }
            else
            {
                if(id == 0)
                {
                    // Add
                    tb_product.ProductName = txt_name.Text;
                    tb_product.ProductBarcode = txt_barcode.Text;
                    tb_product.UnitID = (int)cbx_unit.SelectedValue;
                    tb_product.ProductGoupID = (int)cbx_group.SelectedValue;
                    tb_product.ProductDesc = txt_desc.Text;

                    db.PRODUCTs.Add(tb_product);
                    db.SaveChanges();

                    db = new CashierDBEntities();
                    frm_products.dataGridView1.DataSource = db.PRODUCTs.ToList();

                    this.Close();

                }
                else
                {
                    // Edit
                    tb_product.ProductName = txt_name.Text;
                    tb_product.ProductBarcode = txt_barcode.Text;
                    tb_product.UnitID = (int)cbx_unit.SelectedValue;
                    tb_product.ProductGoupID = (int)cbx_group.SelectedValue;
                    tb_product.ProductDesc = txt_desc.Text;

                    tb_product.ProductID = id;

                    db.Entry(tb_product).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    db = new CashierDBEntities();
                    frm_products.dataGridView1.DataSource = db.PRODUCTs.ToList();

                    this.Close();
                }
            }
        }

        private void FRM_PRODUCTS_ADD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cashierDBDataSet4.PRODUCT_GROUPS' table. You can move, or remove it, as needed.
            this.pRODUCT_GROUPSTableAdapter.Fill(this.cashierDBDataSet4.PRODUCT_GROUPS);
            // TODO: This line of code loads data into the 'cashierDBDataSet3.UNITS' table. You can move, or remove it, as needed.
            this.uNITSTableAdapter.Fill(this.cashierDBDataSet3.UNITS);

        }
    }
}

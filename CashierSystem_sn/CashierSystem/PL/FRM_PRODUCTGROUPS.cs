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
    public partial class FRM_PRODUCTGROUPS : Form
    {
        // init
        CashierDBEntities db = new CashierDBEntities();
        PRODUCT_GROUPS tb_productgroups = new PRODUCT_GROUPS();

        int id;

        public FRM_PRODUCTGROUPS()
        {
            InitializeComponent();
        }

        private void FRM_PRODUCTGROUPS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cashierDBDataSet2.PRODUCT_GROUPS' table. You can move, or remove it, as needed.
            this.pRODUCT_GROUPSTableAdapter.Fill(this.cashierDBDataSet2.PRODUCT_GROUPS);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_PRODUCTGROUPS_ADD frm_productgroups_add = new FRM_PRODUCTGROUPS_ADD();
            frm_productgroups_add.btn_add.Text = "Add";
            frm_productgroups_add.id = 0;
            frm_productgroups_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            db = new CashierDBEntities();
            dataGridView1.DataSource = db.PRODUCT_GROUPS.ToList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_PRODUCTGROUPS_ADD frm_productgroups_add = new FRM_PRODUCTGROUPS_ADD();

                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                tb_productgroups = db.PRODUCT_GROUPS.Where(x => x.ProductGroupID == id).FirstOrDefault();

                frm_productgroups_add.txt_name.Text = tb_productgroups.ProductGroupName.ToString();

                frm_productgroups_add.btn_add.Text = "Edit";
                frm_productgroups_add.btn_add.Image = Properties.Resources.edit_32_2;
                frm_productgroups_add.id = id;
                frm_productgroups_add.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a row to edit it!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = MessageBox.Show("Are you sure that you want to delete this Row?", "Alert", MessageBoxButtons.YesNoCancel);
                if (rs == DialogResult.Yes)
                {
                    id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    tb_productgroups = db.PRODUCT_GROUPS.Where(x => x.ProductGroupID == id).FirstOrDefault();
                    db.Entry(tb_productgroups).State = EntityState.Deleted;
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = txt_search.Text;
            dataGridView1.DataSource = db.PRODUCT_GROUPS.Where(x => x.ProductGroupName.Contains(_search)).ToList();
        }

    }
}

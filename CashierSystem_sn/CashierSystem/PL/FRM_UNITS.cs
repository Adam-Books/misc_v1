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
    public partial class FRM_UNITS : Form
    {
        // init
        CashierDBEntities db = new CashierDBEntities();
        UNIT tb_unit = new UNIT();

        int id;

        public FRM_UNITS()
        {
            InitializeComponent();
        }

        private void FRM_UNITS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cashierDBDataSet1.UNITS' table. You can move, or remove it, as needed.
            this.uNITSTableAdapter.Fill(this.cashierDBDataSet1.UNITS);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_UNITS_ADD frm_units_add = new FRM_UNITS_ADD();
            frm_units_add.btn_add.Text = "Add";
            frm_units_add.id = 0;
            frm_units_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            db = new CashierDBEntities();
            dataGridView1.DataSource = db.UNITS.ToList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = MessageBox.Show("Are you sure that you want to delete this Row?", "Alert", MessageBoxButtons.YesNoCancel);
                if (rs == DialogResult.Yes)
                {
                    id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    tb_unit = db.UNITS.Where(x => x.UnitID == id).FirstOrDefault();
                    db.Entry(tb_unit).State = EntityState.Deleted;
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
                FRM_UNITS_ADD frm_units_add = new FRM_UNITS_ADD();

                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                tb_unit = db.UNITS.Where(x => x.UnitID == id).FirstOrDefault();

                frm_units_add.txt_name.Text = tb_unit.UnitName.ToString();

                frm_units_add.btn_add.Text = "Edit";
                frm_units_add.btn_add.Image = Properties.Resources.edit_32_2;
                frm_units_add.id = id;
                frm_units_add.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a row to edit it!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = txt_search.Text;
            dataGridView1.DataSource = db.UNITS.Where(x => x.UnitName.Contains(_search)).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem.PL
{
    public partial class FRM_UNITS_ADD : Form
    {
        // init
        CashierDBEntities db = new CashierDBEntities();
        UNIT tb_unit = new UNIT();
        FRM_UNITS frm_units = new FRM_UNITS();

        public int id;

        public FRM_UNITS_ADD()
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
            if(txt_name.Text == "")
            {
                MessageBox.Show("The unit name is required", "Alert");
            }
            else
            {
                if(id == 0)
                {
                    // Add
                    tb_unit.UnitName = txt_name.Text;

                    db.UNITS.Add(tb_unit);
                    db.SaveChanges();

                    db = new CashierDBEntities();
                    frm_units.dataGridView1.DataSource = db.UNITS.ToList();

                    this.Close();

                }
                else
                {
                    // Edit
                    tb_unit.UnitName = txt_name.Text;

                    tb_unit.UnitID = id;

                    db.Entry(tb_unit).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    db = new CashierDBEntities();
                    frm_units.dataGridView1.DataSource = db.UNITS.ToList();

                    this.Close();
                }
            }
        }
    }
}

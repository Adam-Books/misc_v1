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
    public partial class FRM_PRODUCTGROUPS_ADD : Form
    {
        // init
        CashierDBEntities db = new CashierDBEntities();
        PRODUCT_GROUPS tb_productgroups = new PRODUCT_GROUPS();
        FRM_PRODUCTGROUPS frm_productgroups = new FRM_PRODUCTGROUPS();

        public int id;

        public FRM_PRODUCTGROUPS_ADD()
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
                if (txt_name.Text == "")
                {
                    MessageBox.Show("The product group name is required", "Alert");
                }
                else
                {
                    if (id == 0)
                    {
                        // Add
                        tb_productgroups.ProductGroupName = txt_name.Text;

                        db.PRODUCT_GROUPS.Add(tb_productgroups);
                        db.SaveChanges();

                        db = new CashierDBEntities();
                        frm_productgroups.dataGridView1.DataSource = db.PRODUCT_GROUPS.ToList();

                        this.Close();

                    }
                    else
                    {
                        // Edit
                    }
                }

        }
    }
}

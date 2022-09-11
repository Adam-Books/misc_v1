using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem
{
    public partial class Main : Form
    {
        // init forms
        PL.FRM_HOME frm_home = new PL.FRM_HOME();
        PL.FRM_PRODUCTS frm_products = new PL.FRM_PRODUCTS();
        PL.FRM_UNITS frm_units = new PL.FRM_UNITS();
        PL.FRM_PRODUCTGROUPS frm_productgroups = new PL.FRM_PRODUCTGROUPS();
        PL.FRM_SETTINGS frm_settings = new PL.FRM_SETTINGS();

        CashierDBEntities db = new CashierDBEntities();

        public Main()
        {
            InitializeComponent();
        }

        // Main Page
        private void btn_main_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_home.pn_home);
        }

        // Main Loading
        private void Main_Load(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_home.pn_home);
        }

        // Load products page
        private void btn_products_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_products.pn_products);
            lbl_title.Text = "Products";

            db = new CashierDBEntities();
            frm_products.dataGridView1.DataSource = db.PRODUCTs.ToList();

        }

        private void btn_units_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_units.pn_units);
            lbl_title.Text = "Units";

            db = new CashierDBEntities();
            frm_units.dataGridView1.DataSource = db.UNITS.ToList();
        }

        private void btn_productGroups_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_productgroups.pn_productgroups);
            lbl_title.Text = "Product groups";

            db = new CashierDBEntities();
            frm_productgroups.dataGridView1.DataSource = db.PRODUCT_GROUPS.ToList();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_settings.pn_settings);
            lbl_title.Text = "Settings";
        }
    }
}

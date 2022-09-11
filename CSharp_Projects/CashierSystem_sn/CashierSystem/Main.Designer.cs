namespace CashierSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_main = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_units = new System.Windows.Forms.Button();
            this.btn_productGroups = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.pn_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pn_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 677);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pic_main);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 241);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(10, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cashier System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_main
            // 
            this.pic_main.Image = global::CashierSystem.Properties.Resources.pngfind_com_cashier_png_6183136;
            this.pic_main.Location = new System.Drawing.Point(3, 6);
            this.pic_main.Name = "pic_main";
            this.pic_main.Size = new System.Drawing.Size(194, 197);
            this.pic_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_main.TabIndex = 0;
            this.pic_main.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_main);
            this.flowLayoutPanel1.Controls.Add(this.btn_products);
            this.flowLayoutPanel1.Controls.Add(this.btn_units);
            this.flowLayoutPanel1.Controls.Add(this.btn_productGroups);
            this.flowLayoutPanel1.Controls.Add(this.btn_settings);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 241);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 436);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_main
            // 
            this.btn_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main.Location = new System.Drawing.Point(3, 3);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(194, 46);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "Main";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_products
            // 
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(3, 55);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(194, 46);
            this.btn_products.TabIndex = 4;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_units
            // 
            this.btn_units.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_units.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_units.Location = new System.Drawing.Point(3, 107);
            this.btn_units.Name = "btn_units";
            this.btn_units.Size = new System.Drawing.Size(194, 46);
            this.btn_units.TabIndex = 1;
            this.btn_units.Text = "Units";
            this.btn_units.UseVisualStyleBackColor = true;
            this.btn_units.Click += new System.EventHandler(this.btn_units_Click);
            // 
            // btn_productGroups
            // 
            this.btn_productGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productGroups.Location = new System.Drawing.Point(3, 159);
            this.btn_productGroups.Name = "btn_productGroups";
            this.btn_productGroups.Size = new System.Drawing.Size(194, 46);
            this.btn_productGroups.TabIndex = 2;
            this.btn_productGroups.Text = "Product groups";
            this.btn_productGroups.UseVisualStyleBackColor = true;
            this.btn_productGroups.Click += new System.EventHandler(this.btn_productGroups_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(3, 211);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(194, 46);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pn_title
            // 
            this.pn_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.pn_title.Controls.Add(this.lbl_title);
            this.pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_title.Location = new System.Drawing.Point(200, 0);
            this.pn_title.Name = "pn_title";
            this.pn_title.Size = new System.Drawing.Size(1060, 60);
            this.pn_title.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_title.Location = new System.Drawing.Point(501, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(59, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Main";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_container
            // 
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(200, 60);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1060, 617);
            this.pn_container.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.pn_title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_units;
        private System.Windows.Forms.Button btn_productGroups;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.PictureBox pic_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_products;
        public System.Windows.Forms.Label lbl_title;
    }
}


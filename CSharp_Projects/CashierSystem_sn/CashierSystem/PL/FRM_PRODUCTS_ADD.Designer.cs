namespace CashierSystem.PL
{
    partial class FRM_PRODUCTS_ADD
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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cbx_unit = new System.Windows.Forms.ComboBox();
            this.uNITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDBDataSet3 = new CashierSystem.CashierDBDataSet3();
            this.cbx_group = new System.Windows.Forms.ComboBox();
            this.pRODUCTGROUPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDBDataSet4 = new CashierSystem.CashierDBDataSet4();
            this.uNITSTableAdapter = new CashierSystem.CashierDBDataSet3TableAdapters.UNITSTableAdapter();
            this.pRODUCT_GROUPSTableAdapter = new CashierSystem.CashierDBDataSet4TableAdapters.PRODUCT_GROUPSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uNITSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTGROUPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(48, 166);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(79, 26);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Unit ID";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Image = global::CashierSystem.Properties.Resources.add_32;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(268, 475);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_add.Size = new System.Drawing.Size(103, 46);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::CashierSystem.Properties.Resources.close_32_2;
            this.btn_close.Location = new System.Drawing.Point(559, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_close.Size = new System.Drawing.Size(42, 46);
            this.btn_close.TabIndex = 10;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(48, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product barcode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(48, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_desc
            // 
            this.txt_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(255, 280);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(281, 173);
            this.txt_desc.TabIndex = 8;
            this.txt_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(48, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product group ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(255, 104);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(281, 35);
            this.txt_barcode.TabIndex = 8;
            this.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(48, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(255, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(281, 35);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbx_unit
            // 
            this.cbx_unit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uNITSBindingSource, "UnitID", true));
            this.cbx_unit.DataSource = this.uNITSBindingSource;
            this.cbx_unit.DisplayMember = "UnitID";
            this.cbx_unit.FormattingEnabled = true;
            this.cbx_unit.Location = new System.Drawing.Point(255, 164);
            this.cbx_unit.Name = "cbx_unit";
            this.cbx_unit.Size = new System.Drawing.Size(281, 33);
            this.cbx_unit.TabIndex = 11;
            this.cbx_unit.ValueMember = "UnitID";
            // 
            // uNITSBindingSource
            // 
            this.uNITSBindingSource.DataMember = "UNITS";
            this.uNITSBindingSource.DataSource = this.cashierDBDataSet3;
            // 
            // cashierDBDataSet3
            // 
            this.cashierDBDataSet3.DataSetName = "CashierDBDataSet3";
            this.cashierDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_group
            // 
            this.cbx_group.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUCTGROUPSBindingSource, "ProductGroupID", true));
            this.cbx_group.DataSource = this.pRODUCTGROUPSBindingSource;
            this.cbx_group.DisplayMember = "ProductGroupID";
            this.cbx_group.FormattingEnabled = true;
            this.cbx_group.Location = new System.Drawing.Point(255, 222);
            this.cbx_group.Name = "cbx_group";
            this.cbx_group.Size = new System.Drawing.Size(281, 33);
            this.cbx_group.TabIndex = 11;
            this.cbx_group.ValueMember = "ProductGroupID";
            // 
            // pRODUCTGROUPSBindingSource
            // 
            this.pRODUCTGROUPSBindingSource.DataMember = "PRODUCT_GROUPS";
            this.pRODUCTGROUPSBindingSource.DataSource = this.cashierDBDataSet4;
            // 
            // cashierDBDataSet4
            // 
            this.cashierDBDataSet4.DataSetName = "CashierDBDataSet4";
            this.cashierDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNITSTableAdapter
            // 
            this.uNITSTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCT_GROUPSTableAdapter
            // 
            this.pRODUCT_GROUPSTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_PRODUCTS_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(603, 533);
            this.Controls.Add(this.cbx_group);
            this.Controls.Add(this.cbx_unit);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_PRODUCTS_ADD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_PRODUCTS_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uNITSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTGROUPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_add;
        private CashierDBDataSet3 cashierDBDataSet3;
        private System.Windows.Forms.BindingSource uNITSBindingSource;
        private CashierDBDataSet3TableAdapters.UNITSTableAdapter uNITSTableAdapter;
        private CashierDBDataSet4 cashierDBDataSet4;
        private System.Windows.Forms.BindingSource pRODUCTGROUPSBindingSource;
        private CashierDBDataSet4TableAdapters.PRODUCT_GROUPSTableAdapter pRODUCT_GROUPSTableAdapter;
        public System.Windows.Forms.TextBox txt_desc;
        public System.Windows.Forms.TextBox txt_barcode;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.ComboBox cbx_unit;
        public System.Windows.Forms.ComboBox cbx_group;
    }
}
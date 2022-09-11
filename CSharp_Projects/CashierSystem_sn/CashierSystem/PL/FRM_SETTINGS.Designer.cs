namespace CashierSystem.PL
{
    partial class FRM_SETTINGS
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
            this.pn_settings = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.pn_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_settings
            // 
            this.pn_settings.Controls.Add(this.btn_update);
            this.pn_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_settings.Location = new System.Drawing.Point(0, 0);
            this.pn_settings.Name = "pn_settings";
            this.pn_settings.Size = new System.Drawing.Size(1060, 617);
            this.pn_settings.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::CashierSystem.Properties.Resources.language_32;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(333, 267);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_update.Size = new System.Drawing.Size(395, 83);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Change your language to Arabic";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // FRM_SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 617);
            this.Controls.Add(this.pn_settings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_SETTINGS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FRM_SETTINGS";
            this.pn_settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Panel pn_settings;
    }
}
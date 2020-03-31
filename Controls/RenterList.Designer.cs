namespace RentKrok.Controls
{
    partial class RenterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenterList));
            this.dgRenters = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNewRenter = new System.Windows.Forms.ToolStripButton();
            this.editRenter = new System.Windows.Forms.ToolStripButton();
            this.delRenter = new System.Windows.Forms.ToolStripButton();
            this.lCount = new System.Windows.Forms.ToolStripLabel();
            this.refresgRenter = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgRenters)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRenters
            // 
            this.dgRenters.AllowUserToAddRows = false;
            this.dgRenters.AllowUserToDeleteRows = false;
            this.dgRenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRenters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRenters.Location = new System.Drawing.Point(0, 0);
            this.dgRenters.MultiSelect = false;
            this.dgRenters.Name = "dgRenters";
            this.dgRenters.ReadOnly = true;
            this.dgRenters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRenters.Size = new System.Drawing.Size(706, 418);
            this.dgRenters.TabIndex = 0;
            this.dgRenters.DoubleClick += new System.EventHandler(this.dgRenters_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRenter,
            this.editRenter,
            this.delRenter,
            this.lCount,
            this.refresgRenter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(706, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNewRenter
            // 
            this.addNewRenter.Image = ((System.Drawing.Image)(resources.GetObject("addNewRenter.Image")));
            this.addNewRenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewRenter.Name = "addNewRenter";
            this.addNewRenter.Size = new System.Drawing.Size(79, 22);
            this.addNewRenter.Text = "Добавить";
            this.addNewRenter.Click += new System.EventHandler(this.addNewRenter_Click);
            // 
            // editRenter
            // 
            this.editRenter.Image = ((System.Drawing.Image)(resources.GetObject("editRenter.Image")));
            this.editRenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editRenter.Name = "editRenter";
            this.editRenter.Size = new System.Drawing.Size(107, 22);
            this.editRenter.Text = "Редактировать";
            this.editRenter.Click += new System.EventHandler(this.editRenter_Click);
            // 
            // delRenter
            // 
            this.delRenter.Image = ((System.Drawing.Image)(resources.GetObject("delRenter.Image")));
            this.delRenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delRenter.Name = "delRenter";
            this.delRenter.Size = new System.Drawing.Size(71, 22);
            this.delRenter.Text = "Удалить";
            this.delRenter.Click += new System.EventHandler(this.delRenter_Click);
            // 
            // lCount
            // 
            this.lCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(0, 22);
            // 
            // refresgRenter
            // 
            this.refresgRenter.Image = ((System.Drawing.Image)(resources.GetObject("refresgRenter.Image")));
            this.refresgRenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresgRenter.Name = "refresgRenter";
            this.refresgRenter.Size = new System.Drawing.Size(81, 22);
            this.refresgRenter.Text = "Обновить";
            this.refresgRenter.Click += new System.EventHandler(this.refresgRenter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgRenters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 418);
            this.panel1.TabIndex = 2;
            // 
            // RenterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenterList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Арендаторы";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenterList_FormClosed);
            this.Load += new System.EventHandler(this.RenterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRenters)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRenters;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNewRenter;
        private System.Windows.Forms.ToolStripButton editRenter;
        private System.Windows.Forms.ToolStripButton delRenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel lCount;
        private System.Windows.Forms.ToolStripButton refresgRenter;
    }
}
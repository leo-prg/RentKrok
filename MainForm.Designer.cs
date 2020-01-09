namespace RentKrok
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPageRent = new System.Windows.Forms.TabPage();
            this.tabControAdmin = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.tabControAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageRent
            // 
            this.tabPageRent.Location = new System.Drawing.Point(4, 24);
            this.tabPageRent.Name = "tabPageRent";
            this.tabPageRent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRent.Size = new System.Drawing.Size(1341, 578);
            this.tabPageRent.TabIndex = 2;
            this.tabPageRent.Text = "Арендаторы";
            this.tabPageRent.UseVisualStyleBackColor = true;
            // 
            // tabControAdmin
            // 
            this.tabControAdmin.Controls.Add(this.tabPageView);
            this.tabControAdmin.Controls.Add(this.tabPageRent);
            this.tabControAdmin.Controls.Add(this.tabPageMap);
            this.tabControAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControAdmin.Name = "tabControAdmin";
            this.tabControAdmin.SelectedIndex = 0;
            this.tabControAdmin.Size = new System.Drawing.Size(1349, 606);
            this.tabControAdmin.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControAdmin.TabIndex = 0;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Location = new System.Drawing.Point(4, 24);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(1341, 578);
            this.tabPageMap.TabIndex = 3;
            this.tabPageMap.Text = "Карта";
            this.tabPageMap.UseVisualStyleBackColor = true;
            this.tabPageMap.Enter += new System.EventHandler(this.tabPageMap_Enter);
            // 
            // tabPageView
            // 
            this.tabPageView.Location = new System.Drawing.Point(4, 24);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1341, 578);
            this.tabPageView.TabIndex = 1;
            this.tabPageView.Text = "Схемы размещения";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 606);
            this.Controls.Add(this.tabControAdmin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRent;
        private System.Windows.Forms.TabControl tabControAdmin;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabPage tabPageView;
    }
}
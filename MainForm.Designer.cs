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
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.tabControlView = new System.Windows.Forms.TabControl();
            this.tabControlView.SuspendLayout();
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
            // tabPageView
            // 
            this.tabPageView.Location = new System.Drawing.Point(4, 24);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1325, 496);
            this.tabPageView.TabIndex = 1;
            this.tabPageView.Text = "Схемы и представления";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // tabControlView
            // 
            this.tabControlView.Controls.Add(this.tabPageView);
            this.tabControlView.Controls.Add(this.tabPageRent);
            this.tabControlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlView.Location = new System.Drawing.Point(0, 0);
            this.tabControlView.Name = "tabControlView";
            this.tabControlView.SelectedIndex = 0;
            this.tabControlView.Size = new System.Drawing.Size(1349, 606);
            this.tabControlView.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 606);
            this.Controls.Add(this.tabControlView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда ООО Крок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRent;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.TabControl tabControlView;
    }
}
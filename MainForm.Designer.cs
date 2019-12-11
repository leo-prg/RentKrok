namespace RentKrok
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LayerPanel = new System.Windows.Forms.Panel();
            this.LayerPicture = new System.Windows.Forms.PictureBox();
            this.addLayer = new System.Windows.Forms.Button();
            this.addObject = new System.Windows.Forms.Button();
            this.dgObjects = new System.Windows.Forms.DataGridView();
            this.dgLayers = new System.Windows.Forms.DataGridView();
            this.AddArea = new System.Windows.Forms.Button();
            this.dgAreas = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.AddAreaInfo = new System.Windows.Forms.Button();
            this.LayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAreas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayerPanel
            // 
            this.LayerPanel.AutoScroll = true;
            this.LayerPanel.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.LayerPanel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.LayerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayerPanel.Controls.Add(this.LayerPicture);
            this.LayerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LayerPanel.Location = new System.Drawing.Point(0, 0);
            this.LayerPanel.Name = "LayerPanel";
            this.LayerPanel.Size = new System.Drawing.Size(748, 536);
            this.LayerPanel.TabIndex = 2;
            // 
            // LayerPicture
            // 
            this.LayerPicture.Location = new System.Drawing.Point(3, 0);
            this.LayerPicture.Name = "LayerPicture";
            this.LayerPicture.Size = new System.Drawing.Size(727, 524);
            this.LayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LayerPicture.TabIndex = 0;
            this.LayerPicture.TabStop = false;
            this.LayerPicture.Click += new System.EventHandler(this.LayerPicture_Click);
            this.LayerPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LayerPicture_MouseMove);
            // 
            // addLayer
            // 
            this.addLayer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addLayer.Location = new System.Drawing.Point(763, 166);
            this.addLayer.Name = "addLayer";
            this.addLayer.Size = new System.Drawing.Size(162, 23);
            this.addLayer.TabIndex = 3;
            this.addLayer.Text = "Добавить слой объекта";
            this.addLayer.UseVisualStyleBackColor = true;
            this.addLayer.Click += new System.EventHandler(this.addLayer_Click);
            // 
            // addObject
            // 
            this.addObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addObject.Location = new System.Drawing.Point(763, 12);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(162, 23);
            this.addObject.TabIndex = 4;
            this.addObject.Text = "Добавить объект";
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // dgObjects
            // 
            this.dgObjects.AllowUserToAddRows = false;
            this.dgObjects.AllowUserToDeleteRows = false;
            this.dgObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObjects.Location = new System.Drawing.Point(763, 41);
            this.dgObjects.Name = "dgObjects";
            this.dgObjects.ReadOnly = true;
            this.dgObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgObjects.Size = new System.Drawing.Size(378, 101);
            this.dgObjects.TabIndex = 5;
            this.dgObjects.Click += new System.EventHandler(this.dgObjects_Click);
            // 
            // dgLayers
            // 
            this.dgLayers.AllowUserToAddRows = false;
            this.dgLayers.AllowUserToDeleteRows = false;
            this.dgLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLayers.Location = new System.Drawing.Point(763, 195);
            this.dgLayers.Name = "dgLayers";
            this.dgLayers.ReadOnly = true;
            this.dgLayers.Size = new System.Drawing.Size(378, 117);
            this.dgLayers.TabIndex = 6;
            this.dgLayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLayers_CellClick);
            // 
            // AddArea
            // 
            this.AddArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddArea.Location = new System.Drawing.Point(763, 334);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(162, 23);
            this.AddArea.TabIndex = 7;
            this.AddArea.Text = "Добавить площадь в слой";
            this.AddArea.UseVisualStyleBackColor = true;
            this.AddArea.Click += new System.EventHandler(this.AddArea_Click);
            // 
            // dgAreas
            // 
            this.dgAreas.AllowUserToAddRows = false;
            this.dgAreas.AllowUserToDeleteRows = false;
            this.dgAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAreas.Location = new System.Drawing.Point(763, 363);
            this.dgAreas.Name = "dgAreas";
            this.dgAreas.ReadOnly = true;
            this.dgAreas.Size = new System.Drawing.Size(378, 117);
            this.dgAreas.TabIndex = 8;
            this.dgAreas.Click += new System.EventHandler(this.dgAreas_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPosition});
            this.statusStrip1.Location = new System.Drawing.Point(748, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(405, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mPosition
            // 
            this.mPosition.Name = "mPosition";
            this.mPosition.Size = new System.Drawing.Size(0, 17);
            // 
            // AddAreaInfo
            // 
            this.AddAreaInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddAreaInfo.Location = new System.Drawing.Point(763, 486);
            this.AddAreaInfo.Name = "AddAreaInfo";
            this.AddAreaInfo.Size = new System.Drawing.Size(206, 23);
            this.AddAreaInfo.TabIndex = 10;
            this.AddAreaInfo.Text = "Добавить информацию о площади";
            this.AddAreaInfo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 536);
            this.Controls.Add(this.AddAreaInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgAreas);
            this.Controls.Add(this.AddArea);
            this.Controls.Add(this.dgLayers);
            this.Controls.Add(this.dgObjects);
            this.Controls.Add(this.addObject);
            this.Controls.Add(this.addLayer);
            this.Controls.Add(this.LayerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аренда помещений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LayerPanel.ResumeLayout(false);
            this.LayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAreas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel LayerPanel;
        private System.Windows.Forms.PictureBox LayerPicture;
        private System.Windows.Forms.Button addLayer;
        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.DataGridView dgObjects;
        private System.Windows.Forms.DataGridView dgLayers;
        private System.Windows.Forms.Button AddArea;
        private System.Windows.Forms.DataGridView dgAreas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mPosition;
        private System.Windows.Forms.Button AddAreaInfo;
    }
}


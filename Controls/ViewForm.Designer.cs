namespace RentKrok
{
    partial class ViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
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
            this.editObject = new System.Windows.Forms.Button();
            this.editLayer = new System.Windows.Forms.Button();
            this.editArea = new System.Windows.Forms.Button();
            this.removeObject = new System.Windows.Forms.Button();
            this.NoArenda = new System.Windows.Forms.Button();
            this.DelArea = new System.Windows.Forms.Button();
            this.DelLayer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAreas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayerPanel
            // 
            this.LayerPanel.AutoScroll = true;
            this.LayerPanel.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.LayerPanel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.LayerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayerPanel.Controls.Add(this.LayerPicture);
            this.LayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayerPanel.Location = new System.Drawing.Point(469, 0);
            this.LayerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LayerPanel.Name = "LayerPanel";
            this.LayerPanel.Size = new System.Drawing.Size(876, 588);
            this.LayerPanel.TabIndex = 2;
            // 
            // LayerPicture
            // 
            this.LayerPicture.Location = new System.Drawing.Point(12, 13);
            this.LayerPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.addLayer.Location = new System.Drawing.Point(8, 170);
            this.addLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addLayer.Name = "addLayer";
            this.addLayer.Size = new System.Drawing.Size(149, 26);
            this.addLayer.TabIndex = 3;
            this.addLayer.Text = "Добавить размещение";
            this.addLayer.UseVisualStyleBackColor = true;
            this.addLayer.Click += new System.EventHandler(this.addLayer_Click);
            // 
            // addObject
            // 
            this.addObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addObject.Location = new System.Drawing.Point(8, 13);
            this.addObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(126, 26);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgObjects.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgObjects.Location = new System.Drawing.Point(8, 47);
            this.dgObjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgObjects.Name = "dgObjects";
            this.dgObjects.ReadOnly = true;
            this.dgObjects.RowHeadersWidth = 10;
            this.dgObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgObjects.Size = new System.Drawing.Size(441, 116);
            this.dgObjects.TabIndex = 5;
            this.dgObjects.Click += new System.EventHandler(this.dgObjects_Click);
            // 
            // dgLayers
            // 
            this.dgLayers.AllowUserToAddRows = false;
            this.dgLayers.AllowUserToDeleteRows = false;
            this.dgLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLayers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLayers.Location = new System.Drawing.Point(8, 203);
            this.dgLayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLayers.Name = "dgLayers";
            this.dgLayers.ReadOnly = true;
            this.dgLayers.RowHeadersWidth = 10;
            this.dgLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLayers.Size = new System.Drawing.Size(441, 135);
            this.dgLayers.TabIndex = 6;
            this.dgLayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLayers_CellClick);
            // 
            // AddArea
            // 
            this.AddArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddArea.Location = new System.Drawing.Point(8, 344);
            this.AddArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(143, 26);
            this.AddArea.TabIndex = 7;
            this.AddArea.Text = "Добавить площадь";
            this.AddArea.UseVisualStyleBackColor = true;
            this.AddArea.Click += new System.EventHandler(this.addArea_Click);
            // 
            // dgAreas
            // 
            this.dgAreas.AllowUserToAddRows = false;
            this.dgAreas.AllowUserToDeleteRows = false;
            this.dgAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAreas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgAreas.Location = new System.Drawing.Point(8, 378);
            this.dgAreas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgAreas.Name = "dgAreas";
            this.dgAreas.ReadOnly = true;
            this.dgAreas.RowHeadersWidth = 10;
            this.dgAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAreas.Size = new System.Drawing.Size(441, 135);
            this.dgAreas.TabIndex = 8;
            this.dgAreas.DoubleClick += new System.EventHandler(this.dgAreas_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1345, 22);
            this.statusStrip1.SizingGrip = false;
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
            this.AddAreaInfo.Location = new System.Drawing.Point(8, 520);
            this.AddAreaInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddAreaInfo.Name = "AddAreaInfo";
            this.AddAreaInfo.Size = new System.Drawing.Size(149, 42);
            this.AddAreaInfo.TabIndex = 10;
            this.AddAreaInfo.Text = "Добавить информацию об арендаторе";
            this.AddAreaInfo.UseVisualStyleBackColor = true;
            this.AddAreaInfo.Click += new System.EventHandler(this.AddAreaInfo_Click);
            // 
            // editObject
            // 
            this.editObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editObject.Location = new System.Drawing.Point(176, 12);
            this.editObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editObject.Name = "editObject";
            this.editObject.Size = new System.Drawing.Size(122, 26);
            this.editObject.TabIndex = 11;
            this.editObject.Text = "Изменить объект";
            this.editObject.UseVisualStyleBackColor = true;
            this.editObject.Click += new System.EventHandler(this.editObject_Click);
            // 
            // editLayer
            // 
            this.editLayer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editLayer.Location = new System.Drawing.Point(164, 169);
            this.editLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editLayer.Name = "editLayer";
            this.editLayer.Size = new System.Drawing.Size(147, 26);
            this.editLayer.TabIndex = 12;
            this.editLayer.Text = "Изменить размещение";
            this.editLayer.UseVisualStyleBackColor = true;
            this.editLayer.Click += new System.EventHandler(this.editLayer_Click);
            // 
            // editArea
            // 
            this.editArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editArea.Location = new System.Drawing.Point(167, 344);
            this.editArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editArea.Name = "editArea";
            this.editArea.Size = new System.Drawing.Size(134, 26);
            this.editArea.TabIndex = 13;
            this.editArea.Text = "Изменить площадь";
            this.editArea.UseVisualStyleBackColor = true;
            this.editArea.Click += new System.EventHandler(this.editArea_Click);
            // 
            // removeObject
            // 
            this.removeObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeObject.Location = new System.Drawing.Point(327, 12);
            this.removeObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeObject.Name = "removeObject";
            this.removeObject.Size = new System.Drawing.Size(122, 26);
            this.removeObject.TabIndex = 14;
            this.removeObject.Text = "Удалить объект";
            this.removeObject.UseVisualStyleBackColor = true;
            this.removeObject.Click += new System.EventHandler(this.removeObject_Click);
            // 
            // NoArenda
            // 
            this.NoArenda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NoArenda.Location = new System.Drawing.Point(315, 520);
            this.NoArenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoArenda.Name = "NoArenda";
            this.NoArenda.Size = new System.Drawing.Size(136, 42);
            this.NoArenda.TabIndex = 15;
            this.NoArenda.Text = "Снять с аренды";
            this.NoArenda.UseVisualStyleBackColor = true;
            this.NoArenda.Click += new System.EventHandler(this.NoArenda_Click);
            // 
            // DelArea
            // 
            this.DelArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DelArea.Location = new System.Drawing.Point(315, 344);
            this.DelArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelArea.Name = "DelArea";
            this.DelArea.Size = new System.Drawing.Size(134, 26);
            this.DelArea.TabIndex = 16;
            this.DelArea.Text = "Удалить площадь";
            this.DelArea.UseVisualStyleBackColor = true;
            this.DelArea.Click += new System.EventHandler(this.DelArea_Click);
            // 
            // DelLayer
            // 
            this.DelLayer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DelLayer.Location = new System.Drawing.Point(317, 169);
            this.DelLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelLayer.Name = "DelLayer";
            this.DelLayer.Size = new System.Drawing.Size(132, 26);
            this.DelLayer.TabIndex = 17;
            this.DelLayer.Text = "Удалить размещение";
            this.DelLayer.UseVisualStyleBackColor = true;
            this.DelLayer.Click += new System.EventHandler(this.DelLayer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DelLayer);
            this.panel1.Controls.Add(this.DelArea);
            this.panel1.Controls.Add(this.NoArenda);
            this.panel1.Controls.Add(this.removeObject);
            this.panel1.Controls.Add(this.editArea);
            this.panel1.Controls.Add(this.editLayer);
            this.panel1.Controls.Add(this.editObject);
            this.panel1.Controls.Add(this.AddAreaInfo);
            this.panel1.Controls.Add(this.dgAreas);
            this.panel1.Controls.Add(this.AddArea);
            this.panel1.Controls.Add(this.dgLayers);
            this.panel1.Controls.Add(this.dgObjects);
            this.panel1.Controls.Add(this.addObject);
            this.panel1.Controls.Add(this.addLayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 588);
            this.panel1.TabIndex = 18;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 610);
            this.Controls.Add(this.LayerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button editObject;
        private System.Windows.Forms.Button editLayer;
        private System.Windows.Forms.Button editArea;
        private System.Windows.Forms.Button removeObject;
        private System.Windows.Forms.Button NoArenda;
        private System.Windows.Forms.Button DelArea;
        private System.Windows.Forms.Button DelLayer;
        private System.Windows.Forms.Panel panel1;
    }
}


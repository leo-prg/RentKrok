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
            this.button2 = new System.Windows.Forms.Button();
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
            this.LayerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LayerPanel.Name = "LayerPanel";
            this.LayerPanel.Size = new System.Drawing.Size(873, 589);
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
            this.addLayer.Location = new System.Drawing.Point(890, 171);
            this.addLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addLayer.Name = "addLayer";
            this.addLayer.Size = new System.Drawing.Size(189, 26);
            this.addLayer.TabIndex = 3;
            this.addLayer.Text = "Добавить слой объекта";
            this.addLayer.UseVisualStyleBackColor = true;
            this.addLayer.Click += new System.EventHandler(this.addLayer_Click);
            // 
            // addObject
            // 
            this.addObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addObject.Location = new System.Drawing.Point(890, 14);
            this.addObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(189, 26);
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
            this.dgObjects.Location = new System.Drawing.Point(890, 48);
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
            this.dgLayers.Location = new System.Drawing.Point(890, 204);
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
            this.AddArea.Location = new System.Drawing.Point(890, 345);
            this.AddArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(189, 26);
            this.AddArea.TabIndex = 7;
            this.AddArea.Text = "Добавить площадь в слой";
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
            this.dgAreas.Location = new System.Drawing.Point(890, 379);
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
            this.statusStrip1.Location = new System.Drawing.Point(873, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
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
            this.AddAreaInfo.Location = new System.Drawing.Point(890, 521);
            this.AddAreaInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddAreaInfo.Name = "AddAreaInfo";
            this.AddAreaInfo.Size = new System.Drawing.Size(441, 26);
            this.AddAreaInfo.TabIndex = 10;
            this.AddAreaInfo.Text = "Добавить информацию об арендаторе";
            this.AddAreaInfo.UseVisualStyleBackColor = true;
            this.AddAreaInfo.Click += new System.EventHandler(this.AddAreaInfo_Click);
            // 
            // editObject
            // 
            this.editObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editObject.Location = new System.Drawing.Point(1142, 14);
            this.editObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editObject.Name = "editObject";
            this.editObject.Size = new System.Drawing.Size(189, 26);
            this.editObject.TabIndex = 11;
            this.editObject.Text = "Изменить объект";
            this.editObject.UseVisualStyleBackColor = true;
            this.editObject.Click += new System.EventHandler(this.editObject_Click);
            // 
            // editLayer
            // 
            this.editLayer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editLayer.Location = new System.Drawing.Point(1142, 171);
            this.editLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editLayer.Name = "editLayer";
            this.editLayer.Size = new System.Drawing.Size(189, 26);
            this.editLayer.TabIndex = 12;
            this.editLayer.Text = "Изменить слой объекта";
            this.editLayer.UseVisualStyleBackColor = true;
            this.editLayer.Click += new System.EventHandler(this.editLayer_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(1142, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Изменить площадь в слое";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editLayer);
            this.Controls.Add(this.editObject);
            this.Controls.Add(this.AddAreaInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgAreas);
            this.Controls.Add(this.AddArea);
            this.Controls.Add(this.dgLayers);
            this.Controls.Add(this.dgObjects);
            this.Controls.Add(this.addObject);
            this.Controls.Add(this.addLayer);
            this.Controls.Add(this.LayerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button button2;
    }
}


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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ShowRenter = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxObjects = new System.Windows.Forms.GroupBox();
            this.groupBoxLayers = new System.Windows.Forms.GroupBox();
            this.groupBoxAreas = new System.Windows.Forms.GroupBox();
            this.LayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAreas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxObjects.SuspendLayout();
            this.groupBoxLayers.SuspendLayout();
            this.groupBoxAreas.SuspendLayout();
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
            this.LayerPanel.Location = new System.Drawing.Point(527, 0);
            this.LayerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LayerPanel.Name = "LayerPanel";
            this.LayerPanel.Size = new System.Drawing.Size(818, 588);
            this.LayerPanel.TabIndex = 2;
            // 
            // LayerPicture
            // 
            this.LayerPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayerPicture.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.addLayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLayer.ImageIndex = 0;
            this.addLayer.ImageList = this.imageList;
            this.addLayer.Location = new System.Drawing.Point(8, 20);
            this.addLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addLayer.Name = "addLayer";
            this.addLayer.Size = new System.Drawing.Size(88, 25);
            this.addLayer.TabIndex = 3;
            this.addLayer.Text = "Добавить";
            this.addLayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addLayer.UseVisualStyleBackColor = true;
            this.addLayer.Click += new System.EventHandler(this.addLayer_Click);
            // 
            // addObject
            // 
            this.addObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addObject.ImageIndex = 0;
            this.addObject.ImageList = this.imageList;
            this.addObject.Location = new System.Drawing.Point(9, 18);
            this.addObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(88, 25);
            this.addObject.TabIndex = 4;
            this.addObject.Text = "Добавить";
            this.addObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // dgObjects
            // 
            this.dgObjects.AllowUserToAddRows = false;
            this.dgObjects.AllowUserToDeleteRows = false;
            this.dgObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgObjects.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgObjects.Location = new System.Drawing.Point(11, 48);
            this.dgObjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgObjects.Name = "dgObjects";
            this.dgObjects.ReadOnly = true;
            this.dgObjects.RowHeadersWidth = 10;
            this.dgObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgObjects.Size = new System.Drawing.Size(486, 105);
            this.dgObjects.TabIndex = 5;
            this.dgObjects.Click += new System.EventHandler(this.dgObjects_Click);
            // 
            // dgLayers
            // 
            this.dgLayers.AllowUserToAddRows = false;
            this.dgLayers.AllowUserToDeleteRows = false;
            this.dgLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLayers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgLayers.Location = new System.Drawing.Point(11, 52);
            this.dgLayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLayers.Name = "dgLayers";
            this.dgLayers.ReadOnly = true;
            this.dgLayers.RowHeadersWidth = 10;
            this.dgLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLayers.Size = new System.Drawing.Size(486, 111);
            this.dgLayers.TabIndex = 6;
            this.dgLayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLayers_CellClick);
            // 
            // AddArea
            // 
            this.AddArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddArea.ImageKey = "add.ico";
            this.AddArea.ImageList = this.imageList;
            this.AddArea.Location = new System.Drawing.Point(11, 18);
            this.AddArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(88, 25);
            this.AddArea.TabIndex = 7;
            this.AddArea.Text = "Добавить площадь";
            this.AddArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddArea.UseVisualStyleBackColor = true;
            this.AddArea.Click += new System.EventHandler(this.addArea_Click);
            // 
            // dgAreas
            // 
            this.dgAreas.AllowUserToAddRows = false;
            this.dgAreas.AllowUserToDeleteRows = false;
            this.dgAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAreas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgAreas.Location = new System.Drawing.Point(11, 51);
            this.dgAreas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgAreas.Name = "dgAreas";
            this.dgAreas.ReadOnly = true;
            this.dgAreas.RowHeadersWidth = 10;
            this.dgAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAreas.Size = new System.Drawing.Size(484, 135);
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
            this.AddAreaInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAreaInfo.ImageIndex = 3;
            this.AddAreaInfo.ImageList = this.imageList;
            this.AddAreaInfo.Location = new System.Drawing.Point(9, 194);
            this.AddAreaInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddAreaInfo.Name = "AddAreaInfo";
            this.AddAreaInfo.Size = new System.Drawing.Size(153, 26);
            this.AddAreaInfo.TabIndex = 10;
            this.AddAreaInfo.Text = "Добавить арендатора";
            this.AddAreaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddAreaInfo.UseVisualStyleBackColor = true;
            this.AddAreaInfo.Click += new System.EventHandler(this.AddAreaInfo_Click);
            // 
            // editObject
            // 
            this.editObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editObject.ImageKey = "file_edit.ico";
            this.editObject.ImageList = this.imageList;
            this.editObject.Location = new System.Drawing.Point(210, 18);
            this.editObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editObject.Name = "editObject";
            this.editObject.Size = new System.Drawing.Size(90, 25);
            this.editObject.TabIndex = 11;
            this.editObject.Text = "Изменить";
            this.editObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editObject.UseVisualStyleBackColor = true;
            this.editObject.Click += new System.EventHandler(this.editObject_Click);
            // 
            // editLayer
            // 
            this.editLayer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editLayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editLayer.ImageIndex = 1;
            this.editLayer.ImageList = this.imageList;
            this.editLayer.Location = new System.Drawing.Point(209, 20);
            this.editLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editLayer.Name = "editLayer";
            this.editLayer.Size = new System.Drawing.Size(90, 25);
            this.editLayer.TabIndex = 12;
            this.editLayer.Text = "Изменить";
            this.editLayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editLayer.UseVisualStyleBackColor = true;
            this.editLayer.Click += new System.EventHandler(this.editLayer_Click);
            // 
            // editArea
            // 
            this.editArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editArea.ImageKey = "file_edit.ico";
            this.editArea.ImageList = this.imageList;
            this.editArea.Location = new System.Drawing.Point(210, 19);
            this.editArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editArea.Name = "editArea";
            this.editArea.Size = new System.Drawing.Size(90, 25);
            this.editArea.TabIndex = 13;
            this.editArea.Text = "Изменить площадь";
            this.editArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editArea.UseVisualStyleBackColor = true;
            this.editArea.Click += new System.EventHandler(this.editArea_Click);
            // 
            // removeObject
            // 
            this.removeObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeObject.ImageIndex = 2;
            this.removeObject.ImageList = this.imageList;
            this.removeObject.Location = new System.Drawing.Point(413, 18);
            this.removeObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeObject.Name = "removeObject";
            this.removeObject.Size = new System.Drawing.Size(81, 25);
            this.removeObject.TabIndex = 14;
            this.removeObject.Text = "Удалить";
            this.removeObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeObject.UseVisualStyleBackColor = true;
            this.removeObject.Click += new System.EventHandler(this.removeObject_Click);
            // 
            // NoArenda
            // 
            this.NoArenda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NoArenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoArenda.ImageIndex = 5;
            this.NoArenda.ImageList = this.imageList;
            this.NoArenda.Location = new System.Drawing.Point(376, 194);
            this.NoArenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoArenda.Name = "NoArenda";
            this.NoArenda.Size = new System.Drawing.Size(114, 26);
            this.NoArenda.TabIndex = 15;
            this.NoArenda.Text = "Снять с аренды";
            this.NoArenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoArenda.UseVisualStyleBackColor = true;
            this.NoArenda.Click += new System.EventHandler(this.NoArenda_Click);
            // 
            // DelArea
            // 
            this.DelArea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DelArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelArea.ImageIndex = 2;
            this.DelArea.ImageList = this.imageList;
            this.DelArea.Location = new System.Drawing.Point(414, 19);
            this.DelArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelArea.Name = "DelArea";
            this.DelArea.Size = new System.Drawing.Size(81, 25);
            this.DelArea.TabIndex = 16;
            this.DelArea.Text = "Удалить площадь";
            this.DelArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelArea.UseVisualStyleBackColor = true;
            this.DelArea.Click += new System.EventHandler(this.DelArea_Click);
            // 
            // DelLayer
            // 
            this.DelLayer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DelLayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelLayer.ImageIndex = 2;
            this.DelLayer.ImageList = this.imageList;
            this.DelLayer.Location = new System.Drawing.Point(412, 20);
            this.DelLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelLayer.Name = "DelLayer";
            this.DelLayer.Size = new System.Drawing.Size(81, 25);
            this.DelLayer.TabIndex = 17;
            this.DelLayer.Text = "Удалить";
            this.DelLayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelLayer.UseVisualStyleBackColor = true;
            this.DelLayer.Click += new System.EventHandler(this.DelLayer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxAreas);
            this.panel1.Controls.Add(this.groupBoxLayers);
            this.panel1.Controls.Add(this.groupBoxObjects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 588);
            this.panel1.TabIndex = 18;
            // 
            // ShowRenter
            // 
            this.ShowRenter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ShowRenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRenter.ImageIndex = 4;
            this.ShowRenter.ImageList = this.imageList;
            this.ShowRenter.Location = new System.Drawing.Point(196, 194);
            this.ShowRenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowRenter.Name = "ShowRenter";
            this.ShowRenter.Size = new System.Drawing.Size(146, 26);
            this.ShowRenter.TabIndex = 18;
            this.ShowRenter.Text = "Показать арендатора";
            this.ShowRenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowRenter.UseVisualStyleBackColor = true;
            this.ShowRenter.Click += new System.EventHandler(this.ShowRenter_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "add.ico");
            this.imageList.Images.SetKeyName(1, "file_edit.ico");
            this.imageList.Images.SetKeyName(2, "error.ico");
            this.imageList.Images.SetKeyName(3, "user_add.ico");
            this.imageList.Images.SetKeyName(4, "user(3).ico");
            this.imageList.Images.SetKeyName(5, "user_remove.ico");
            // 
            // groupBoxObjects
            // 
            this.groupBoxObjects.Controls.Add(this.removeObject);
            this.groupBoxObjects.Controls.Add(this.editObject);
            this.groupBoxObjects.Controls.Add(this.dgObjects);
            this.groupBoxObjects.Controls.Add(this.addObject);
            this.groupBoxObjects.Location = new System.Drawing.Point(8, 13);
            this.groupBoxObjects.Name = "groupBoxObjects";
            this.groupBoxObjects.Size = new System.Drawing.Size(505, 160);
            this.groupBoxObjects.TabIndex = 19;
            this.groupBoxObjects.TabStop = false;
            this.groupBoxObjects.Text = "Объекты";
            // 
            // groupBoxLayers
            // 
            this.groupBoxLayers.Controls.Add(this.DelLayer);
            this.groupBoxLayers.Controls.Add(this.editLayer);
            this.groupBoxLayers.Controls.Add(this.dgLayers);
            this.groupBoxLayers.Controls.Add(this.addLayer);
            this.groupBoxLayers.Location = new System.Drawing.Point(8, 179);
            this.groupBoxLayers.Name = "groupBoxLayers";
            this.groupBoxLayers.Size = new System.Drawing.Size(505, 170);
            this.groupBoxLayers.TabIndex = 20;
            this.groupBoxLayers.TabStop = false;
            this.groupBoxLayers.Text = "Схемы объекта";
            // 
            // groupBoxAreas
            // 
            this.groupBoxAreas.Controls.Add(this.ShowRenter);
            this.groupBoxAreas.Controls.Add(this.DelArea);
            this.groupBoxAreas.Controls.Add(this.NoArenda);
            this.groupBoxAreas.Controls.Add(this.editArea);
            this.groupBoxAreas.Controls.Add(this.AddAreaInfo);
            this.groupBoxAreas.Controls.Add(this.dgAreas);
            this.groupBoxAreas.Controls.Add(this.AddArea);
            this.groupBoxAreas.Location = new System.Drawing.Point(8, 355);
            this.groupBoxAreas.Name = "groupBoxAreas";
            this.groupBoxAreas.Size = new System.Drawing.Size(505, 230);
            this.groupBoxAreas.TabIndex = 21;
            this.groupBoxAreas.TabStop = false;
            this.groupBoxAreas.Text = "Площади";
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
            this.groupBoxObjects.ResumeLayout(false);
            this.groupBoxLayers.ResumeLayout(false);
            this.groupBoxAreas.ResumeLayout(false);
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
        private System.Windows.Forms.Button ShowRenter;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBoxAreas;
        private System.Windows.Forms.GroupBox groupBoxLayers;
        private System.Windows.Forms.GroupBox groupBoxObjects;
    }
}


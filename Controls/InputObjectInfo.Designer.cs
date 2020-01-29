namespace RentKrok.Controls
{
    partial class InputObjectInfo
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cdNumber = new System.Windows.Forms.Label();
            this.tbCdNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLon = new System.Windows.Forms.TextBox();
            this.btnGetGeolocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(276, 23);
            this.tbName.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(14, 75);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(238, 23);
            this.tbAddress.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(45, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование объекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес объекта";
            // 
            // cdNumber
            // 
            this.cdNumber.AutoSize = true;
            this.cdNumber.Location = new System.Drawing.Point(14, 103);
            this.cdNumber.Name = "cdNumber";
            this.cdNumber.Size = new System.Drawing.Size(118, 15);
            this.cdNumber.TabIndex = 7;
            this.cdNumber.Text = "Кадастровый номер";
            // 
            // tbCdNumber
            // 
            this.tbCdNumber.Location = new System.Drawing.Point(14, 120);
            this.tbCdNumber.Name = "tbCdNumber";
            this.tbCdNumber.Size = new System.Drawing.Size(276, 23);
            this.tbCdNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Широта";
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(14, 163);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(130, 23);
            this.tbLat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Долгота";
            // 
            // tbLon
            // 
            this.tbLon.Location = new System.Drawing.Point(160, 163);
            this.tbLon.Name = "tbLon";
            this.tbLon.Size = new System.Drawing.Size(130, 23);
            this.tbLon.TabIndex = 10;
            // 
            // btnGetGeolocation
            // 
            this.btnGetGeolocation.Image = global::RentKrok.Properties.Resources.GMap;
            this.btnGetGeolocation.Location = new System.Drawing.Point(258, 65);
            this.btnGetGeolocation.Name = "btnGetGeolocation";
            this.btnGetGeolocation.Size = new System.Drawing.Size(35, 41);
            this.btnGetGeolocation.TabIndex = 12;
            this.btnGetGeolocation.UseVisualStyleBackColor = true;
            this.btnGetGeolocation.Click += new System.EventHandler(this.btnGetGeolocation_Click);
            // 
            // InputObjectInfo
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(303, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btnGetGeolocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLat);
            this.Controls.Add(this.cdNumber);
            this.Controls.Add(this.tbCdNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputObjectInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация об объекте";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputObjectInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cdNumber;
        private System.Windows.Forms.TextBox tbCdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLon;
        private System.Windows.Forms.Button btnGetGeolocation;
    }
}
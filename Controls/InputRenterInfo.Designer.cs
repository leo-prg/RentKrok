namespace RentKrok.Controls
{
    partial class InputRenterInfo
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbRenterName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbContract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContacts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAnnotation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Наименование арендатора";
            // 
            // tbRenterName
            // 
            this.tbRenterName.Location = new System.Drawing.Point(166, 15);
            this.tbRenterName.Name = "tbRenterName";
            this.tbRenterName.Size = new System.Drawing.Size(351, 20);
            this.tbRenterName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(166, 263);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbContract
            // 
            this.tbContract.Location = new System.Drawing.Point(72, 54);
            this.tbContract.Name = "tbContract";
            this.tbContract.Size = new System.Drawing.Size(88, 20);
            this.tbContract.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Договор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "действует с";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(248, 54);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(96, 20);
            this.dtpStart.TabIndex = 15;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(375, 54);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(96, 20);
            this.dtpEnd.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "по";
            // 
            // tbContacts
            // 
            this.tbContacts.Location = new System.Drawing.Point(90, 87);
            this.tbContacts.Multiline = true;
            this.tbContacts.Name = "tbContacts";
            this.tbContacts.Size = new System.Drawing.Size(427, 67);
            this.tbContacts.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 67);
            this.label4.TabIndex = 18;
            this.label4.Text = "Контактные лица";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPhones
            // 
            this.tbPhones.Location = new System.Drawing.Point(90, 160);
            this.tbPhones.Multiline = true;
            this.tbPhones.Name = "tbPhones";
            this.tbPhones.Size = new System.Drawing.Size(427, 67);
            this.tbPhones.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 67);
            this.label5.TabIndex = 22;
            this.label5.Text = "Телефоны, электронная почта";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAnnotation
            // 
            this.tbAnnotation.Location = new System.Drawing.Point(90, 233);
            this.tbAnnotation.Name = "tbAnnotation";
            this.tbAnnotation.Size = new System.Drawing.Size(427, 20);
            this.tbAnnotation.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Примечание";
            // 
            // InputRenterInfo
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(539, 296);
            this.Controls.Add(this.tbAnnotation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPhones);
            this.Controls.Add(this.tbContacts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbContract);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbRenterName);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputRenterInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод информации";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbRenterName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContacts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAnnotation;
        private System.Windows.Forms.Label label6;
    }
}
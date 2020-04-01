namespace RentKrok.Controls
{
    partial class InputAreaInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.calcFromSum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Площадь помещения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование помещения";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(70, 164);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(14, 75);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(145, 23);
            this.tbSquare.TabIndex = 1;
            this.tbSquare.TextChanged += new System.EventHandler(this.tbSquare_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(276, 23);
            this.tbName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цена за eдиницу";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(170, 75);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(119, 23);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сумма аренды";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(14, 120);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(145, 23);
            this.tbCost.TabIndex = 14;
            this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
            // 
            // calcFromSum
            // 
            this.calcFromSum.AutoSize = true;
            this.calcFromSum.Location = new System.Drawing.Point(176, 122);
            this.calcFromSum.Name = "calcFromSum";
            this.calcFromSum.Size = new System.Drawing.Size(120, 19);
            this.calcFromSum.TabIndex = 16;
            this.calcFromSum.Text = "расчет от суммы";
            this.calcFromSum.UseVisualStyleBackColor = true;
            this.calcFromSum.CheckedChanged += new System.EventHandler(this.calcFromSum_CheckedChanged);
            // 
            // InputAreaInfo
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(313, 207);
            this.ControlBox = false;
            this.Controls.Add(this.calcFromSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbSquare);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputAreaInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о площади";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputAreaInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.CheckBox calcFromSum;
    }
}
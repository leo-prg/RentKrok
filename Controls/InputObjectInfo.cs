using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentLibrary;

namespace RentKrok.Controls
{
    public partial class InputObjectInfo : Form
    {

        public ObjectRect orNew;
        public InputObjectInfo()
        {
            InitializeComponent();
        }

        private void InputObjectInfo_Load(object sender, EventArgs e)
        {
            if (orNew != null)
            {
                tbName.Text = orNew.Name;
                tbAddress.Text = orNew.Address;
                tbCdNumber.Text = orNew.CNo;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ObjectRect or = new ObjectRect() { Name = this.tbName.Text, Address = this.tbAddress.Text, CNo = this.tbCdNumber.Text };
            orNew = or;
            DialogResult = DialogResult.OK;
        }

       
    }
}

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

   
    public partial class InputRenterInfo : Form
    {

        public RenterRect rrNew;
        public InputRenterInfo()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            rrNew = new RenterRect() { RenterName = tbRenterName.Text, Contract = tbContract.Text,
                                       StartDate = dtpStart.Value, EndDate = dtpEnd.Value, 
                                       ContactPerson = tbContacts.Text, ContactPhone = tbPhones.Text, 
                                       Annotation = tbAnnotation.Text };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void InputRenterInfo_Load(object sender, EventArgs e)
        {
            if (rrNew != null)
            {
                tbRenterName.Text = rrNew.RenterName;
                tbContract.Text = rrNew.Contract;
                dtpStart.Value = rrNew.StartDate;
                dtpEnd.Value = rrNew.EndDate;
                tbContacts.Text = rrNew.ContactPerson;
                tbPhones.Text = rrNew.ContactPhone;
                tbAnnotation.Text = rrNew.Annotation;
            }
        }
    }
}

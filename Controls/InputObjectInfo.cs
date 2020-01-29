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
using GMap.NET.WindowsForms;
using GMap.NET;

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
                tbLat.Text = orNew.Lat;
                tbLon.Text = orNew.Lon;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ObjectRect or = new ObjectRect() 
            { Name = this.tbName.Text, Address = this.tbAddress.Text,
              CNo = this.tbCdNumber.Text, Lat = this.tbLat.Text, Lon = this.tbLon.Text };
            orNew = or;
            DialogResult = DialogResult.OK;
        }

        private void btnGetGeolocation_Click(object sender, EventArgs e)
        {
            using (var gMapControl = new GMapControl())
            {

                var status = gMapControl.SetPositionByKeywords(tbAddress.Text);
                if (status != GeoCoderStatusCode.OK)
                {
                    MessageBox.Show("Geocoder can't find selected place!", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.tbLat.Text = gMapControl.Position.Lat.ToString();
                this.tbLon.Text = gMapControl.Position.Lng.ToString(); ;
            }
    }
    }
}

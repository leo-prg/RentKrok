using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentKrok.Controls;


namespace RentKrok
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Lazy<ViewForm> frmV = new Lazy<ViewForm>();
            frmV.Value.TopLevel = false;
            frmV.Value.Visible = true;
            frmV.Value.FormBorderStyle = FormBorderStyle.None;
            frmV.Value.Dock = DockStyle.Fill;
            tabControlView.TabPages[0].Controls.Add(frmV.Value);
            
            Lazy<RenterList> frmR = new Lazy<RenterList>();
            frmR.Value.TopLevel = false;
            frmR.Value.Visible = true;
            frmR.Value.FormBorderStyle = FormBorderStyle.None;
            frmR.Value.Dock = DockStyle.Fill;
            tabControlView.TabPages[1].Controls.Add(frmR.Value);
        }

        private void tabPageMap_Enter(object sender, EventArgs e)
        {
            // выберем все обхъекты на карте  
            MapControl map = MapControl.GetInstance();
            map.Dock = DockStyle.Fill;
            tabControlView.TabPages[2].Controls.Add(map);

        }
    }
}

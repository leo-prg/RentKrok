using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentKrok.Controls
{
    public partial class InputAreaInfo : Form
    {
        public AreaRect ar;
        public InputAreaInfo()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ar = new AreaRect() { AreaName = tbName.Text, Square = float.TryParse(tbSquare.Text, out float s) ? s : 0, 
                                  Price = float.TryParse(tbPrice.Text, out float p) ? p : 0, 
                                  Cost = float.TryParse(tbCost.Text, out float c) ? c : 0
            };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbSquare_TextChanged(object sender, EventArgs e)
        {
         
            float square = float.TryParse(tbSquare.Text, out float s) ? s : 0;
            float price = float.TryParse(tbPrice.Text, out float p) ? p : 0;

            tbCost.Text = Math.Round(square * price, 2).ToString() ;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            
            float square = float.TryParse(tbSquare.Text, out float s) ? s : 0;
            float price = float.TryParse(tbPrice.Text, out float p) ? p : 0;

            tbCost.Text = Math.Round(square * price, 2).ToString();
        }

       
    }
}

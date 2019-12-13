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
            ar = new AreaRect() { AreaName = tbName.Text, Square = Convert.ToInt32(tbSquare.Text), 
                                  Price = Convert.ToInt32(tbPrice.Text), 
                                  Cost = Convert.ToInt32(tbCost.Text) };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbSquare_TextChanged(object sender, EventArgs e)
        {
            float square = Convert.ToInt32(tbSquare.Text);
            float price = Convert.ToInt32(tbPrice.Text);

            tbCost.Text = Math.Round(square * price, 2).ToString() ;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            float square = Convert.ToInt32(tbSquare.Text);
            float price = Convert.ToInt32(tbPrice.Text);

            tbCost.Text = Math.Round(square * price, 2).ToString();
        }
    }
}

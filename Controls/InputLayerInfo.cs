using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCommon;
using RentLibrary;

namespace RentKrok.Controls
{
    public partial class InputLayerInfo : Form
    {

        public LayerRect lrNew;
      
        public InputLayerInfo()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lrNew = new LayerRect() { Name = tbName.Text,
                                      FileName = tbFileName.Text,
                                      LayerFile = Transform.ImageToByte(Image.FromFile(tbFileName.Text)),
                                      Width = Image.FromFile(tbFileName.Text).Width, 
                                      Height = Image.FromFile(tbFileName.Text).Height  };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fd = new OpenFileDialog
            {
                Filter = "Файлы сканов JPEG|*.jpg",
                Title = "Выберите схему слоя объекта"
            };

            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = fd.FileName;
            }
        }

        private void InputLayerInfo_Load(object sender, EventArgs e)
        {
            if (lrNew != null)
            {
                tbName.Text = lrNew.Name;
                tbFileName.Text = lrNew.FileName;
            }

        }
    }
}

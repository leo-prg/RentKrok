using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentDB;
using RentLibrary;

namespace RentKrok.Controls
{
    public partial class RenterList : Form
    {
        public RenterRect renterOut;

        //bool sortOrder = false;

        Lazy<DBRenter> dbr = new Lazy<DBRenter>(); // арендатор
        public RenterList()
        {
            InitializeComponent();
        }

        private void RenterList_Load(object sender, EventArgs e)
        {
            RefreshRentersList();
        }

        protected void RefreshRentersList()
        {
           
            dgRenters.DataSource = dbr.Value.GetAllRenters();
            dgRenters.Columns[0].Visible = false;
            dgRenters.Columns[1].HeaderText = "Арендатор";
            dgRenters.Columns[1].Width = 300;
            dgRenters.Columns[2].HeaderText = "Договор";
            dgRenters.Columns[2].Width = 100;
            dgRenters.Columns[3].HeaderText = "Начало";
            dgRenters.Columns[3].Width = 150;
            dgRenters.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgRenters.Columns[4].HeaderText = "Окончание";
            dgRenters.Columns[4].Width = 150;
            dgRenters.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgRenters.Columns[5].Visible = false;
            dgRenters.Columns[6].Visible = false; 
            dgRenters.Columns[7].Visible = false;
            dgRenters.CurrentCell = dgRenters.Rows[0].Cells[1];
            lCount.Text = string.Format(@"Количество арендаторов: {0}", dgRenters.Rows.Count.ToString());
            
        }

        private void dgRenters_DoubleClick(object sender, EventArgs e)
        {
            //var oldR = dgRenters.CurrentRow.DataBoundItem as RenterRect;
            //using (InputRenterInfo iri = new InputRenterInfo() { rrNew = oldR })
            //{
            //    iri.ShowDialog();
            //    if (iri.DialogResult == DialogResult.OK)
            //    {
            //        dbr.Value.UpdateRenter(oldR, iri.rrNew);
            //    }
            //}
            //RefreshRentersList();
        }

        private void RenterList_FormClosed(object sender, FormClosedEventArgs e)
        {
            renterOut = dgRenters.CurrentRow.DataBoundItem as RenterRect;

        }

        private void addNewRenter_Click(object sender, EventArgs e)
        {
            using InputRenterInfo iri = new InputRenterInfo();
            iri.ShowDialog();
            if (iri.DialogResult == DialogResult.OK)
            {
                // добавляем самого арендатора?? а если существует уже в базе запрос на создание нового 
                dbr.Value.AddRenter(iri.rrNew);
            }
            Point cAddress = dgRenters.CurrentCellAddress;
            RefreshRentersList();
            dgRenters.Rows[cAddress.Y].Cells[cAddress.X].Selected = true;
        }

        private void editRenter_Click(object sender, EventArgs e)
        {
            var oldR = dgRenters.CurrentRow.DataBoundItem as RenterRect;
            using (InputRenterInfo iri = new InputRenterInfo() { rrNew = oldR })
            {
                iri.ShowDialog();
                if (iri.DialogResult == DialogResult.OK)
                {
                    dbr.Value.UpdateRenter(oldR, iri.rrNew);
                }
            }
            Point cAddress = dgRenters.CurrentCellAddress;
            RefreshRentersList();
            dgRenters.Rows[cAddress.Y].Cells[cAddress.X].Selected = true;
        }

        private void delRenter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить арендатора?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dbr.Value.DropRenter(dgRenters.CurrentRow.DataBoundItem as RenterRect);
            }
            RefreshRentersList();
        }

        private void refresgRenter_Click(object sender, EventArgs e)
        {

            Point cAddress = dgRenters.CurrentCellAddress;
            RefreshRentersList();
            dgRenters.Rows[cAddress.Y].Cells[cAddress.X].Selected = true;

        }

        private void dgRenters_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //dgRenters.Sort(dgRenters.Columns[0], sortOrder ? ListSortDirection.Ascending : ListSortDirection.Descending);
            //sortOrder = !sortOrder;

            //DataGridViewColumn newColumn =  dgRenters.Columns.GetColumnCount(
            //DataGridViewElementStates.Selected) == 1 ?
            //dgRenters.SelectedColumns[0] : null;

            //if (sortOrder)
            //{
            //    dgRenters.Sort(newColumn, ListSortDirection.Ascending);
            //    sortOrder = !sortOrder;
            //}
            //else
            //{
            //    dgRenters.Sort(newColumn, ListSortDirection.Descending);
            //    sortOrder = !sortOrder;
            //}
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentKrok.DBWork;

namespace RentKrok.Controls
{
    public partial class RenterList : Form
    {
        public RenterRect renterOut;
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
            dgRenters.Columns[3].Width = 70;
            dgRenters.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgRenters.Columns[4].HeaderText = "Окончание";
            dgRenters.Columns[4].Width = 70;
            dgRenters.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgRenters.Columns[5].Visible = false;
            dgRenters.Columns[6].Visible = false; 
            dgRenters.Columns[7].Visible = false;
            dgRenters.CurrentCell = dgRenters.Rows[0].Cells[1];
        }

        private void dgRenters_DoubleClick(object sender, EventArgs e)
        {
            var oldR = dgRenters.CurrentRow.DataBoundItem as RenterRect;
            InputRenterInfo iri = new InputRenterInfo() { rrNew = oldR };
            
            iri.ShowDialog();
            if (iri.DialogResult == DialogResult.OK)
            {
                dbr.Value.UpdateRenter(oldR, iri.rrNew);
            }
            RefreshRentersList();
        }

        private void RenterList_FormClosed(object sender, FormClosedEventArgs e)
        {
            renterOut = dgRenters.CurrentRow.DataBoundItem as RenterRect;
        }
    }
}
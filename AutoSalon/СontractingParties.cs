﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaikovBSUIR
{
    public partial class СontractingParties : Form
    {

        private AutoEntities db;

        public СontractingParties()
        {
            InitializeComponent();
            db = new AutoEntities();
        }

        private void СontractingParties_Load(object sender, EventArgs e)
        {


            this.db.Контрагенты.Load();
            this.radGridView1.DataSource = this.db.Контрагенты.Local.ToBindingList();
            this.radGridView1.Columns[0].Width = 30;
            this.radGridView1.Columns[0].HeaderText = "№";
            this.radGridView1.Columns[1].Width = 200;
            this.radGridView1.Columns[2].Width = 150;
            this.radGridView1.Columns[3].Width = 150;
            this.radGridView1.Columns[4].Width = 150;
            this.radGridView1.Columns[5].Width = 150;
            this.radGridView1.Columns[6].Width = 150;
            this.radGridView1.Columns[7].Width = 150;
            this.radGridView1.Columns[8].Width = 150;
            this.radGridView1.Columns[9].IsVisible = false;
            this.radGridView1.Columns[10].IsVisible = false;

        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Запись не сохранена !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
        }

        private void radGridView1_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Запись не удалена !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
        }

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Значение не изменено !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace pnptv
{
    public partial class SetupListDatabase : Form
    {
        public SetupListDatabase()
        {
            InitializeComponent();
            
        }

        public string nameFileSets = "DatabaseList.xml";
        public DataConnectionConfiguration dcs;
        public Microsoft.Data.ConnectionUI.DataConnectionDialog dlg;

        private void SetupListDatabase_Load(object sender, EventArgs e)
        {
            listbase.Items.Clear();
            this.Icon = pnptv.Properties.Resources.movie;


            refreshlist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dcs.GetDataConnectionConfiguration(nameFileSets, listbase.Items.Count+1);
            EditDatabase FormNew = new EditDatabase();
            FormNew.StringConnect.Text = dcs.GetConnectionStringSource();
            FormNew.NameBase.Text = dcs.GetSelectedNameSource();
            FormNew.dcs = dcs;
            FormNew.dlg = dlg;
            dcs.LoadConfiguration(dlg);
            try { 
            dlg.ConnectionString = dcs.GetConnectionStringSource();
            }
            catch { }
            if (FormNew.ShowDialog() == DialogResult.OK)
            {
                dcs.SaveConnectionStringSource(FormNew.StringConnect.Text);
                dcs.SaveNameDAtabase(FormNew.NameBase.Text);
                dcs.SaveConfiguration(dlg);
            }
            FormNew.Dispose();
            refreshlist();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            
            dcs.GetDataConnectionConfiguration(nameFileSets, listbase.SelectedIndex+1);
            EditDatabase FormNew = new EditDatabase();
            FormNew.StringConnect.Text = dcs.GetConnectionStringSource();
            FormNew.NameBase.Text = dcs.GetSelectedNameSource();
            FormNew.dcs = dcs;
            FormNew.dlg = dlg;
            dcs.LoadConfiguration(dlg);
            try
            {
                if (dcs.GetConnectionStringSource() != null)
                    dlg.ConnectionString = dcs.GetConnectionStringSource();
            }
            catch { };
            if (FormNew.ShowDialog() == DialogResult.OK) {
                dcs.SaveConnectionStringSource(FormNew.StringConnect.Text);
                dcs.SaveNameDAtabase(FormNew.NameBase.Text);
                dcs.SaveConfiguration(dlg);
            }
            FormNew.Dispose();
            refreshlist();
        }

        private void refreshlist()
        {
            int cnt, selectIndex;
            cnt = 0;
            dcs = new DataConnectionConfiguration(nameFileSets);
            
            cnt = dcs.counts;

            selectIndex = listbase.SelectedIndex;
            listbase.Items.Clear();

            for (int i = 1; i <= cnt; i++)
            {
                dcs.GetDataConnectionConfiguration(nameFileSets, i);
                listbase.Items.Add(dcs.GetSelectedNameSource() + "  / " + dcs.GetSelectedProvider());
            }
            if (dlg==null) { 
            dlg = new Microsoft.Data.ConnectionUI.DataConnectionDialog();
            Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(dlg);
            }
            dcs.LoadConfiguration(dlg);
            if (selectIndex >= 0 & selectIndex< listbase.Items.Count) { listbase.SelectedIndex = selectIndex; }
            else {
                if (listbase.Items.Count>0) { listbase.SelectedIndex = 0; }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           if ( MessageBox.Show("Удалить базу из списка подключенных ?","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                dcs.GetDataConnectionConfiguration(nameFileSets, listbase.SelectedIndex + 1);
                dcs.Delete();
                refreshlist();
            }
        }
    } //SetupListDatabase
}

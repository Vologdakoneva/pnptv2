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
using System.Data.Common;



namespace pnptv
{

    public partial class LoginData : Form
    {
        public string nameFileSets = "DatabaseList.xml";
        public DataConnectionConfiguration dcs;
        public Microsoft.Data.ConnectionUI.DataConnectionDialog dlg;
        public ConnectionModule ConnectionModules;
        public string[] prm;

        public string[] Prm { get => prm; set => prm = value; }

        public LoginData()
        {
            InitializeComponent();
        }

        private void refreshDatabases()
        {
            username.Focus();
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
            if (dlg == null)
            {
                dlg = new Microsoft.Data.ConnectionUI.DataConnectionDialog();
                Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(dlg);
            }
            dcs.LoadConfiguration(dlg);
            if (selectIndex >= 0 & selectIndex< listbase.Items.Count) { listbase.SelectedIndex = selectIndex; }
            else
            {
                if (listbase.Items.Count > 0) { listbase.SelectedIndex = 0; }
            }
            listbase.Enabled = (listbase.Items.Count != 1);
            username.Text = dcs.GetLastlogin();
            if (listbase.Items.Count>0)
            listbase.SelectedIndex = dcs.GetLastIdBase();

        }
        public void Login_Load(object sender, EventArgs e)
        {
            refreshDatabases();
            ActiveControl = userpassword;
            if (Prm != null && Prm.Contains("/SHOW"))
            {
                btLogin_Click(null, null);
            }


        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try

            {
                ConnectionModules.TypeProvider = ConnectionModule.SQLTYPEPROVIDER.NONE;
                ConnectionModules.NameProvider = dcs.GetSelectedProvider();
                ConnectionModules.username = username.Text;
                ConnectionModules.password = userpassword.Text;
                ConnectionModules.connection(); // Create Connection
                ConnectionModules.connectionstring = dcs.GetConnectionStringSource();
              switch (ConnectionModules.TypeProvider)
                {
                    case ConnectionModule.SQLTYPEPROVIDER.OLEDB:
                        using (ConnectionModules._connectionOleDb) {
                            ConnectionModules._connectionOleDb.Open();
                        }
                        break;
                    case ConnectionModule.SQLTYPEPROVIDER.MSSQL:
                        ConnectionModules._connectionSQL.Open();
                        break;
                    default: throw new Exception("Провайдер данных или сервер не поддерживается.");
                }

                ConnectionModules.Logined = true;
                dcs.SaveLastlogin(username.Text);
                dcs.SaveLastIDbase(listbase.SelectedIndex);
                this.Close();
            }
            catch  (Exception exc ) {
                MessageBox.Show(exc.Message, "Ошибка регистрации", MessageBoxButtons.OK,MessageBoxIcon.Error);
                ConnectionModules.Logined = false;
                userpassword.SelectAll();            }
            
            }
    



        private void button3_Click(object sender, EventArgs e)
        {

            var setbase = new SetupListDatabase();
            setbase.ShowDialog();
            setbase.Dispose();
            refreshDatabases();
            dcs.GetDataConnectionConfiguration(nameFileSets, listbase.SelectedIndex + 1);
            if (listbase.Items.Count>0)
            listbase.Items[listbase.SelectedIndex] = dcs.GetSelectedNameSource() + "  / " + dcs.GetSelectedProvider();
            
        }

        private void listbase_SelectedIndexChanged(object sender, EventArgs e)
        {
            dcs.GetDataConnectionConfiguration(nameFileSets, listbase.SelectedIndex + 1);
            username.Text = dcs.GetLastlogin();
            ConnectionModules.TypeProvider = ConnectionModule.SQLTYPEPROVIDER.NONE;
            ConnectionModules.connectionstring = dcs.GetConnectionStringSource();
            SQLtrusted();
        }

        private void SQLtrusted()
        {
            ConnectionModules.NameProvider = dcs.GetSelectedProvider();
                var builder = new DbConnectionStringBuilder();
                ConnectionModules.NameProvider = dcs.GetSelectedProvider();
                builder.ConnectionString = ConnectionModules.connectionstring;
                username.Enabled = true;
                userpassword.Enabled = true;
                if (builder.ContainsKey("INTEGRATED SECURITY"))
                {
                    if ((builder["INTEGRATED SECURITY"] as string).ToUpper() == "TRUE")
                    {
                        username.Enabled = false;
                        username.Text = Environment.UserName;
                        userpassword.Enabled = false;
                }
                else
                {
                    username.Enabled = true;
                    userpassword.Enabled = true;
                }

            }
            

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ConnectionModules.Logined = false;
            Close();
        }
    }  
}

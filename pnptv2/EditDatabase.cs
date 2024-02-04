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
    public partial class EditDatabase : Form
    {
        public EditDatabase()
        {
            InitializeComponent();
            this.Icon = pnptv.Properties.Resources.movie;
        }

        public DataConnectionConfiguration dcs;
        public Microsoft.Data.ConnectionUI.DataConnectionDialog dlg;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EditDatabase_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(dlg) == DialogResult.OK) {
                StringConnect.Text = dlg.ConnectionString;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pnptv
{
    public partial class fBaseVidget : Form
    {
        public fBaseVidget()
        {
            InitializeComponent();
        }
        public virtual void Setup(int Idmonitor, string guidMonitor) {
            MessageBox.Show("Для данного виджета настройка не возможна","Информация", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}

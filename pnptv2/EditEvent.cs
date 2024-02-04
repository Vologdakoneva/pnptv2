using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
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
    public partial class EditEvent : DevExpress.XtraEditors.XtraForm
    {
        SchedulerControl control;
        Appointment apt;
        public EditEvent(SchedulerControl control, Appointment apt)
        {
            InitializeComponent();
        }
    }
}
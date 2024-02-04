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
    public partial class fCopyScheduler : Form
    {
        public DateTime? FromDate;
        public DateTime ToDate;
        public fCopyScheduler()
        {
            InitializeComponent();
        }

        private void fCopyScheduler_Shown(object sender, EventArgs e)
        {
            DateTime Nowfrom = (DateTime)(FromDate == null ? DateTime.Now.Date : FromDate);
            int diff = (7 + (Nowfrom.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startDate = FirstdayOfWeek(Nowfrom); //Nowfrom.AddDays(-1 * diff).Date;
            DateTime endDate = startDate.AddDays(6);
            dcopyFrom.DateTime = endDate.AddDays(1);
            if (ToDate > dcopyFrom.DateTime) {
                dcopyFrom.DateTime = FirstdayOfWeek(ToDate);
            }
            edtStartDate.DateTime = startDate;
            edtEndDate.DateTime = endDate;
            CalcTagetPeriod();

        }

        private void CalcTagetPeriod()
        {
            if (ToDate > dcopyFrom.DateTime)
            {
                dcopyFrom.DateTime = FirstdayOfWeek(ToDate);
            }
            dcopyTo.DateTime = dcopyFrom.DateTime.AddDays(-1).AddDays(7 * (copyWeeks.SelectedIndex+1));
        }
        public DateTime FirstdayOfWeek(DateTime Date)
        {
            int diff = (7 + (Date.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startDate = Date.AddDays(-1 * diff).Date;
            return startDate;
        }

        private void copyWeeks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcTagetPeriod();
        }

        private void edtStartDate_EditValueChanged(object sender, EventArgs e)
        {

        }
        //public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        //{
        //    int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        //    return dt.AddDays(-1 * diff).Date;
        //}
    }
}

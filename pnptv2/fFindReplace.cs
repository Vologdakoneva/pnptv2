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
    public partial class fFindReplace : Form
    {
        public string ConnectionString_ { get; set; }
        public DateTime? FromDate;
        public fFindReplace()
        {
            InitializeComponent();
        }

        private void fFindReplace_Load(object sender, EventArgs e)
        {
            this.dOCTORSTableAdapter.Connection.ConnectionString = ConnectionString_; // _connectionOleDb;
            this.dOCTORSTableAdapter.Fill(this.qDoctor.DOCTORS);
            DateTime Nowfrom = (DateTime)(FromDate == null ? DateTime.Now.Date : FromDate);
            int diff = (7 + (Nowfrom.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startDate = FirstdayOfWeek(Nowfrom); //Nowfrom.AddDays(-1 * diff).Date;
            DateTime endDate = startDate.AddDays(6);
            edtStartDate.DateTime = startDate;
            edtEndDate.DateTime = endDate;


        }
        public DateTime FirstdayOfWeek(DateTime Date)
        {
            int diff = (7 + (Date.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startDate = Date.AddDays(-1 * diff).Date;
            return startDate;
        }
    }
}

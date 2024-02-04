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
    public partial class fGetFreeResource : Form
    {
        public int IdWorkPlace { get; set; }
        public string ConnString { get; set; }
        public fGetFreeResource()
        {
            InitializeComponent();
            dStartDate.Value = DateTime.Now;
        }

        private void loadData()
        {
            int getWrkPlace = IdWorkPlace;
            int OnlyFree = 0;
            if (chAllWorkPlace.Checked)
                getWrkPlace = -1;
            if (onlyFree.Checked)
                OnlyFree = 1;
            if (ConnString == null) return;
            this.gETFREECABINETTableAdapter.Connection.ConnectionString = ConnString; // _connectionOleDb;
            this.gETFREECABINETTableAdapter.Fill(this.dmSchedule.GETFREECABINET, dStartDate.Value, getWrkPlace , OnlyFree);
            DateTime start = Convert.ToDateTime(this.dmSchedule.GETFREECABINET.Rows[0]["START"]);
            edtStartDate.DateTime = start.Date;
            edtStartTime.Time = Convert.ToDateTime( start.ToString("HH:mm") );
            start = edtStartDate.DateTime.AddHours(edtStartTime.Time.Hour).AddMinutes(edtStartTime.Time.Minute);
            DateTime ends = start.AddHours((int)TimeBusy.Value);

            edtEndDate.DateTime = ends.Date;
            edtEndTime.Time = Convert.ToDateTime(ends.ToString("HH:mm"));

        }

        private void fGetFreeResource_Load(object sender, EventArgs e)
        {
            this.dOCTORSTableAdapter.Connection.ConnectionString = ConnString; // _connectionOleDb;
            this.dOCTORSTableAdapter.Fill(this.qDoctor.DOCTORS);
            loadData();

        }

        private void onlyFree_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void chAllWorkPlace_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (Convert.ToInt32( gridView1.GetRowCellValue(e.RowHandle, "ISFREE") ) == 1)
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else 
            {
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle>=0 && Convert.ToDateTime(gridView1.GetRowCellValue(e.FocusedRowHandle, "START")) > edtStartDate.DateTime.AddHours(edtStartTime.Time.Hour).AddMinutes(edtStartTime.Time.Minute))
            {
                DateTime start = Convert.ToDateTime(gridView1.GetRowCellValue(e.FocusedRowHandle, "START"));
                edtStartDate.DateTime = start.Date;
                edtStartTime.Time = Convert.ToDateTime(start.ToString("HH:mm"));
            }
                
        }

        private void edtStartDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }

        private void edtStartDate_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                DateTime start;
                if (Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "START")) > edtStartDate.DateTime.AddHours(edtStartTime.Time.Hour).AddMinutes(edtStartTime.Time.Minute)) { 
                start = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "START"));
                
                edtStartDate.DateTime = start.Date;
                edtStartTime.Time = Convert.ToDateTime(start.ToString("HH:mm"));
                }
                start = edtStartDate.DateTime.AddHours(edtStartTime.Time.Hour).AddMinutes(edtStartTime.Time.Minute);
                DateTime ends = start.AddHours((int)TimeBusy.Value);

                edtEndDate.DateTime = ends.Date;
                edtEndTime.Time = Convert.ToDateTime(ends.ToString("HH:mm"));
            }

        }

        private void dStartDate_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}


namespace pnptv
{
    partial class XtraSchedulerReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.dmSchedule1 = new pnptv.dmSchedule();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
            this.reportTimelineView1 = new DevExpress.XtraScheduler.Reporting.ReportTimelineView();
            this.timelineCells1 = new DevExpress.XtraScheduler.Reporting.TimelineCells();
            ((System.ComponentModel.ISupportInitialize)(this.dmSchedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTimelineView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.timelineCells1,
            this.horizontalResourceHeaders1});
            this.Detail.HeightF = 263.5417F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dmSchedule1
            // 
            this.dmSchedule1.DataSetName = "dmSchedule";
            this.dmSchedule1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horizontalResourceHeaders1
            // 
            this.horizontalResourceHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 97.91666F);
            this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
            this.horizontalResourceHeaders1.SizeF = new System.Drawing.SizeF(121.4532F, 43.70837F);
            this.horizontalResourceHeaders1.View = this.reportDayView1;
            // 
            // timelineCells1
            // 
            this.timelineCells1.LocationFloat = new DevExpress.Utils.PointFloat(335.4167F, 102.0833F);
            this.timelineCells1.Name = "timelineCells1";
            this.timelineCells1.SizeF = new System.Drawing.SizeF(304.5833F, 150F);
            this.timelineCells1.View = this.reportTimelineView1;
            // 
            // XtraSchedulerReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dmSchedule1});
            this.Version = "19.1";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1,
            this.reportTimelineView1});
            ((System.ComponentModel.ISupportInitialize)(this.dmSchedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTimelineView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private dmSchedule dmSchedule1;
        private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
        private DevExpress.XtraScheduler.Reporting.TimelineCells timelineCells1;
        private DevExpress.XtraScheduler.Reporting.ReportTimelineView reportTimelineView1;
    }
}

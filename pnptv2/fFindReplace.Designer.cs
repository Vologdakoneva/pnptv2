
namespace pnptv
{
    partial class fFindReplace
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SourceVrach = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qDoctor = new pnptv.qDoctor();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALIZATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TagetVrach = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.prims = new DevExpress.XtraEditors.MemoEdit();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.dOCTORSTableAdapter = new pnptv.qDoctorTableAdapters.DOCTORSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceVrach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagetVrach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prims.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(232, 36);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtEndDate.Size = new System.Drawing.Size(100, 20);
            this.edtEndDate.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Найти в распсании и заменить";
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(126, 36);
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtStartDate.Size = new System.Drawing.Size(100, 20);
            this.edtStartDate.TabIndex = 20;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Appearance.Options.UseTextOptions = true;
            this.lblStartTime.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblStartTime.Location = new System.Drawing.Point(12, 39);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(86, 13);
            this.lblStartTime.TabIndex = 21;
            this.lblStartTime.Text = "Найти в периоде";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Найти врача";
            // 
            // SourceVrach
            // 
            this.SourceVrach.Location = new System.Drawing.Point(126, 62);
            this.SourceVrach.Name = "SourceVrach";
            this.SourceVrach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SourceVrach.Properties.DataSource = this.dOCTORSBindingSource;
            this.SourceVrach.Properties.DisplayMember = "FIO";
            this.SourceVrach.Properties.KeyMember = "IDALL";
            this.SourceVrach.Properties.NullText = "";
            this.SourceVrach.Properties.PopupView = this.gridLookUpEdit1View;
            this.SourceVrach.Properties.ValueMember = "IDALL";
            this.SourceVrach.Size = new System.Drawing.Size(385, 20);
            this.SourceVrach.TabIndex = 24;
            // 
            // dOCTORSBindingSource
            // 
            this.dOCTORSBindingSource.DataMember = "DOCTORS";
            this.dOCTORSBindingSource.DataSource = this.qDoctor;
            // 
            // qDoctor
            // 
            this.qDoctor.DataSetName = "qDoctor";
            this.qDoctor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL,
            this.colFIO,
            this.colSPECIALIZATION});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIDALL
            // 
            this.colIDALL.FieldName = "IDALL";
            this.colIDALL.Name = "colIDALL";
            this.colIDALL.Visible = true;
            this.colIDALL.VisibleIndex = 0;
            this.colIDALL.Width = 54;
            // 
            // colFIO
            // 
            this.colFIO.FieldName = "FIO";
            this.colFIO.Name = "colFIO";
            this.colFIO.Visible = true;
            this.colFIO.VisibleIndex = 1;
            this.colFIO.Width = 316;
            // 
            // colSPECIALIZATION
            // 
            this.colSPECIALIZATION.FieldName = "SPECIALIZATION";
            this.colSPECIALIZATION.Name = "colSPECIALIZATION";
            this.colSPECIALIZATION.Visible = true;
            this.colSPECIALIZATION.VisibleIndex = 2;
            this.colSPECIALIZATION.Width = 791;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Заменить на врача";
            // 
            // TagetVrach
            // 
            this.TagetVrach.Location = new System.Drawing.Point(126, 88);
            this.TagetVrach.Name = "TagetVrach";
            this.TagetVrach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TagetVrach.Properties.DataSource = this.dOCTORSBindingSource;
            this.TagetVrach.Properties.DisplayMember = "FIO";
            this.TagetVrach.Properties.KeyMember = "IDALL";
            this.TagetVrach.Properties.NullText = "";
            this.TagetVrach.Properties.PopupView = this.gridView1;
            this.TagetVrach.Properties.ValueMember = "IDALL";
            this.TagetVrach.Size = new System.Drawing.Size(385, 20);
            this.TagetVrach.TabIndex = 26;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IDALL";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 54;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "FIO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 316;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "SPECIALIZATION";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 791;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Заменить апимечаание на";
            // 
            // prims
            // 
            this.prims.Location = new System.Drawing.Point(12, 144);
            this.prims.Name = "prims";
            this.prims.Properties.NullText = "Примечание для замены";
            this.prims.Size = new System.Drawing.Size(499, 66);
            this.prims.TabIndex = 29;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(436, 227);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btCopy
            // 
            this.btCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCopy.Location = new System.Drawing.Point(310, 227);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(112, 23);
            this.btCopy.TabIndex = 30;
            this.btCopy.Text = "Найти и заменить";
            this.btCopy.UseVisualStyleBackColor = true;
            // 
            // dOCTORSTableAdapter
            // 
            this.dOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // fFindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 267);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.prims);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TagetVrach);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SourceVrach);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.lblStartTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fFindReplace";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти и заменить";
            this.Load += new System.EventHandler(this.fFindReplace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceVrach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagetVrach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prims.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.DateEdit edtEndDate;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL;
        private DevExpress.XtraGrid.Columns.GridColumn colFIO;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALIZATION;
        protected DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        protected DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCopy;
        private qDoctor qDoctor;
        private System.Windows.Forms.BindingSource dOCTORSBindingSource;
        private qDoctorTableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
        public DevExpress.XtraEditors.GridLookUpEdit SourceVrach;
        public DevExpress.XtraEditors.GridLookUpEdit TagetVrach;
        public DevExpress.XtraEditors.MemoEdit prims;
    }
}
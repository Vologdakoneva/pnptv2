
namespace pnptv
{
    partial class fGetFreeResource
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dStartDate = new System.Windows.Forms.DateTimePicker();
            this.vrachSelect = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qDoctor = new pnptv.qDoctor();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gETFREECABINETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmSchedule = new pnptv.dmSchedule();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDKABINET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDVRACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMEKABINET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colENDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDADRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDWORKPLACE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISFREE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gETFREECABINETTableAdapter = new pnptv.dmScheduleTableAdapters.GETFREECABINETTableAdapter();
            this.onlyFree = new DevExpress.XtraEditors.CheckEdit();
            this.chAllWorkPlace = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.dOCTORSTableAdapter = new pnptv.qDoctorTableAdapters.DOCTORSTableAdapter();
            this.TimeBusy = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vrachSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETFREECABINETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlyFree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAllWorkPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBusy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начная с:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Врач (Не обязательно)";
            // 
            // dStartDate
            // 
            this.dStartDate.CustomFormat = "dd.MMMM.yyy H:mm";
            this.dStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dStartDate.Location = new System.Drawing.Point(158, 9);
            this.dStartDate.Name = "dStartDate";
            this.dStartDate.Size = new System.Drawing.Size(164, 20);
            this.dStartDate.TabIndex = 3;
            this.dStartDate.ValueChanged += new System.EventHandler(this.dStartDate_ValueChanged);
            // 
            // vrachSelect
            // 
            this.vrachSelect.EditValue = "[]";
            this.vrachSelect.Location = new System.Drawing.Point(158, 46);
            this.vrachSelect.Name = "vrachSelect";
            this.vrachSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vrachSelect.Properties.DataSource = this.dOCTORSBindingSource;
            this.vrachSelect.Properties.DisplayMember = "FIO";
            this.vrachSelect.Properties.PopupView = this.gridLookUpEdit1View;
            this.vrachSelect.Properties.ValueMember = "IDALL";
            this.vrachSelect.Size = new System.Drawing.Size(254, 20);
            this.vrachSelect.TabIndex = 4;
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
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Укажите врача, чтобы занять кабинет";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(500, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Занять кабинет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(626, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.gETFREECABINETBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDate});
            this.gridControl1.Size = new System.Drawing.Size(689, 236);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gETFREECABINETBindingSource
            // 
            this.gETFREECABINETBindingSource.DataMember = "GETFREECABINET";
            this.gETFREECABINETBindingSource.DataSource = this.dmSchedule;
            // 
            // dmSchedule
            // 
            this.dmSchedule.DataSetName = "dmSchedule";
            this.dmSchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL,
            this.colIDKABINET,
            this.colIDVRACH,
            this.colNAMEKABINET,
            this.colSTART,
            this.colENDS,
            this.colNOMER,
            this.colIDADRESS,
            this.colIDWORKPLACE,
            this.colFIO,
            this.colISFREE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNAMEKABINET, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSTART, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIDALL
            // 
            this.colIDALL.FieldName = "IDALL";
            this.colIDALL.Name = "colIDALL";
            this.colIDALL.OptionsColumn.ReadOnly = true;
            // 
            // colIDKABINET
            // 
            this.colIDKABINET.FieldName = "IDKABINET";
            this.colIDKABINET.Name = "colIDKABINET";
            this.colIDKABINET.OptionsColumn.ReadOnly = true;
            // 
            // colIDVRACH
            // 
            this.colIDVRACH.FieldName = "IDVRACH";
            this.colIDVRACH.Name = "colIDVRACH";
            this.colIDVRACH.OptionsColumn.ReadOnly = true;
            // 
            // colNAMEKABINET
            // 
            this.colNAMEKABINET.Caption = "Кабинет";
            this.colNAMEKABINET.FieldName = "NAMEKABINET";
            this.colNAMEKABINET.Name = "colNAMEKABINET";
            this.colNAMEKABINET.OptionsColumn.ReadOnly = true;
            this.colNAMEKABINET.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colNAMEKABINET.Visible = true;
            this.colNAMEKABINET.VisibleIndex = 0;
            this.colNAMEKABINET.Width = 106;
            // 
            // colSTART
            // 
            this.colSTART.Caption = "С";
            this.colSTART.ColumnEdit = this.repDate;
            this.colSTART.FieldName = "START";
            this.colSTART.Name = "colSTART";
            this.colSTART.OptionsColumn.ReadOnly = true;
            this.colSTART.Visible = true;
            this.colSTART.VisibleIndex = 1;
            this.colSTART.Width = 136;
            // 
            // repDate
            // 
            this.repDate.AutoHeight = false;
            this.repDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate.DisplayFormat.FormatString = "dd.MMMM.yyy H:mm";
            this.repDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repDate.Name = "repDate";
            // 
            // colENDS
            // 
            this.colENDS.Caption = "По";
            this.colENDS.ColumnEdit = this.repDate;
            this.colENDS.FieldName = "ENDS";
            this.colENDS.Name = "colENDS";
            this.colENDS.OptionsColumn.ReadOnly = true;
            this.colENDS.Visible = true;
            this.colENDS.VisibleIndex = 2;
            this.colENDS.Width = 131;
            // 
            // colNOMER
            // 
            this.colNOMER.FieldName = "NOMER";
            this.colNOMER.Name = "colNOMER";
            this.colNOMER.OptionsColumn.ReadOnly = true;
            // 
            // colIDADRESS
            // 
            this.colIDADRESS.FieldName = "IDADRESS";
            this.colIDADRESS.Name = "colIDADRESS";
            this.colIDADRESS.OptionsColumn.ReadOnly = true;
            // 
            // colIDWORKPLACE
            // 
            this.colIDWORKPLACE.FieldName = "IDWORKPLACE";
            this.colIDWORKPLACE.Name = "colIDWORKPLACE";
            this.colIDWORKPLACE.OptionsColumn.ReadOnly = true;
            // 
            // colFIO
            // 
            this.colFIO.Caption = "Врач";
            this.colFIO.FieldName = "FIO";
            this.colFIO.Name = "colFIO";
            this.colFIO.OptionsColumn.ReadOnly = true;
            this.colFIO.Visible = true;
            this.colFIO.VisibleIndex = 3;
            this.colFIO.Width = 297;
            // 
            // colISFREE
            // 
            this.colISFREE.FieldName = "ISFREE";
            this.colISFREE.Name = "colISFREE";
            this.colISFREE.OptionsColumn.ReadOnly = true;
            // 
            // gETFREECABINETTableAdapter
            // 
            this.gETFREECABINETTableAdapter.ClearBeforeFill = true;
            // 
            // onlyFree
            // 
            this.onlyFree.Location = new System.Drawing.Point(157, 69);
            this.onlyFree.Name = "onlyFree";
            this.onlyFree.Properties.Caption = "Показывать только свободные";
            this.onlyFree.Size = new System.Drawing.Size(254, 19);
            this.onlyFree.TabIndex = 9;
            this.onlyFree.CheckedChanged += new System.EventHandler(this.onlyFree_CheckedChanged);
            // 
            // chAllWorkPlace
            // 
            this.chAllWorkPlace.Location = new System.Drawing.Point(158, 88);
            this.chAllWorkPlace.Name = "chAllWorkPlace";
            this.chAllWorkPlace.Properties.Caption = "По всем отделениям";
            this.chAllWorkPlace.Size = new System.Drawing.Size(254, 19);
            this.chAllWorkPlace.TabIndex = 10;
            this.chAllWorkPlace.CheckedChanged += new System.EventHandler(this.chAllWorkPlace_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Занять на";
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartTime.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(363, 357);
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Size = new System.Drawing.Size(100, 20);
            this.edtStartTime.TabIndex = 15;
            this.edtStartTime.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // edtStartDate
            // 
            this.edtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartDate.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(257, 357);
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtStartDate.Size = new System.Drawing.Size(100, 20);
            this.edtStartDate.TabIndex = 16;
            this.edtStartDate.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            this.edtStartDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.edtStartDate_EditValueChanging);
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStartTime.Location = new System.Drawing.Point(190, 358);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(43, 13);
            this.lblStartTime.TabIndex = 17;
            this.lblStartTime.Text = "Начиная";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEndTime.Location = new System.Drawing.Point(190, 384);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(56, 13);
            this.lblEndTime.TabIndex = 18;
            this.lblEndTime.Text = "Оканчивая";
            // 
            // edtEndDate
            // 
            this.edtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndDate.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtEndDate.Enabled = false;
            this.edtEndDate.Location = new System.Drawing.Point(257, 383);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtEndDate.Size = new System.Drawing.Size(100, 20);
            this.edtEndDate.TabIndex = 19;
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndTime.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtEndTime.Enabled = false;
            this.edtEndTime.Location = new System.Drawing.Point(363, 383);
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Size = new System.Drawing.Size(100, 20);
            this.edtEndTime.TabIndex = 20;
            // 
            // dOCTORSTableAdapter
            // 
            this.dOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // TimeBusy
            // 
            this.TimeBusy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeBusy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeBusy.Location = new System.Drawing.Point(76, 357);
            this.TimeBusy.Name = "TimeBusy";
            this.TimeBusy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeBusy.Properties.IsFloatValue = false;
            this.TimeBusy.Properties.Mask.EditMask = "N00";
            this.TimeBusy.Size = new System.Drawing.Size(58, 20);
            this.TimeBusy.TabIndex = 21;
            this.TimeBusy.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "час(ов)";
            // 
            // fGetFreeResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeBusy);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chAllWorkPlace);
            this.Controls.Add(this.onlyFree);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vrachSelect);
            this.Controls.Add(this.dStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fGetFreeResource";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти свободные кабинеты";
            this.Load += new System.EventHandler(this.fGetFreeResource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrachSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETFREECABINETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlyFree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAllWorkPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBusy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dStartDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource gETFREECABINETBindingSource;
        private dmSchedule dmSchedule;
        private dmScheduleTableAdapters.GETFREECABINETTableAdapter gETFREECABINETTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKABINET;
        private DevExpress.XtraGrid.Columns.GridColumn colIDVRACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMEKABINET;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART;
        private DevExpress.XtraGrid.Columns.GridColumn colENDS;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMER;
        private DevExpress.XtraGrid.Columns.GridColumn colIDADRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colIDWORKPLACE;
        private DevExpress.XtraGrid.Columns.GridColumn colFIO;
        private DevExpress.XtraEditors.CheckEdit onlyFree;
        private DevExpress.XtraEditors.CheckEdit chAllWorkPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colISFREE;
        private System.Windows.Forms.Label label4;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        private qDoctor qDoctor;
        private System.Windows.Forms.BindingSource dOCTORSBindingSource;
        private qDoctorTableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.DateEdit edtEndDate;
        public DevExpress.XtraEditors.TimeEdit edtEndTime;
        public DevExpress.XtraEditors.GridLookUpEdit vrachSelect;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraEditors.TimeEdit edtStartTime;
        public DevExpress.XtraEditors.DateEdit edtStartDate;
        public DevExpress.XtraEditors.SpinEdit TimeBusy;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
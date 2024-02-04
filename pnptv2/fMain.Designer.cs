namespace pnptv
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.dOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qDoctor = new pnptv.qDoctor();
            this.qWorkPlace = new pnptv.qWorkPlace();
            this.wORKPLACESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.удвлитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRaspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qVidgetInMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIDJETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONITORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sETUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wORKPLACESTableAdapter = new pnptv.qWorkPlaceTableAdapters.WORKPLACESTableAdapter();
            this.dOCTORSTableAdapter = new pnptv.qDoctorTableAdapters.DOCTORSTableAdapter();
            this.qRaspTableAdapter = new pnptv.qDoctorTableAdapters.qRaspTableAdapter();
            this.sETUPTableAdapter = new pnptv.qDoctorTableAdapters.SETUPTableAdapter();
            this.tableAdapterManager = new pnptv.qDoctorTableAdapters.TableAdapterManager();
            this.adaptVidgetInMon = new pnptv.qDoctorTableAdapters.AdaptVidgetInMon();
            this.vIDJETTableAdapter = new pnptv.qDoctorTableAdapters.VIDJETTableAdapter();
            this.mONITORSTableAdapter = new pnptv.qDoctorTableAdapters.MONITORSTableAdapter();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolbars = new System.Windows.Forms.ToolStrip();
            this.ShowInTv = new System.Windows.Forms.ToolStripButton();
            this.ClearAllShow = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new DevExpress.XtraBars.Navigation.TabPane();
            this.tbMain = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALIZATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.gWorkplace = new DevExpress.XtraGrid.GridControl();
            this.gvWorkPlace = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRasp = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridLookUpOrg = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDWORKPLACE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDPEPLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SelectDoctor = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALIZATION2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKAB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSRED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPATN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOSK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALIZATION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMons = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label9 = new System.Windows.Forms.Label();
            this.RefreshTime = new DevExpress.XtraEditors.SpinEdit();
            this.sETUPREFRESHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.gridmon = new DevExpress.XtraGrid.GridControl();
            this.menuVidgets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetupPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPage = new System.Windows.Forms.ToolStripMenuItem();
            this.btCpopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDVIDGET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResVidget = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARAMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spinMinitors = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.LabCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkedMonitors = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.tbschedule = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.schedulerControls = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerData = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.qScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmSchedule = new pnptv.dmSchedule();
            this.qResourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.ColOne = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.WorkPlaceSchedule = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStripSchedule = new System.Windows.Forms.ToolStrip();
            this.menuSchedule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsripFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbFindFreeCab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.tbCopuSpecials = new System.Windows.Forms.ToolStripButton();
            this.tbFind = new System.Windows.Forms.ToolStripButton();
            this.tbKabinets = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gCabinet = new DevExpress.XtraGrid.GridControl();
            this.contextMenuKabinet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kABINETSPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDADRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tPlaceAdressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNOMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETAG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlKabAdress = new DevExpress.XtraGrid.GridControl();
            this.adressKabinet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteadresCab = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewCabAdress = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDALL8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHORTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KabinetPlace = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.VidgetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sETUPREFRESHTableAdapter = new pnptv.qDoctorTableAdapters.SETUPREFRESHTableAdapter();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.qResourceAdapter = new pnptv.dmScheduleTableAdapters.qResourceAdapter();
            this.qScheduleAdapter = new pnptv.dmScheduleTableAdapters.qScheduleAdapter();
            this.kABINETSPRTableAdapter = new pnptv.dmScheduleTableAdapters.KABINETSPRTableAdapter();
            this.qPlaceAdress = new pnptv.dmScheduleTableAdapters.qPlaceAdress();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKPLACESBindingSource)).BeginInit();
            this.mnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRaspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qVidgetInMonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIDJETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONITORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.toolbars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gWorkplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkPlace)).BeginInit();
            this.tabRasp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpOrg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.tabMons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETUPREFRESHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmon)).BeginInit();
            this.menuVidgets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResVidget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinitors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedMonitors.Properties)).BeginInit();
            this.tbschedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qResourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPlaceSchedule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.toolStripSchedule.SuspendLayout();
            this.menuSchedule.SuspendLayout();
            this.tbKabinets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCabinet)).BeginInit();
            this.contextMenuKabinet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kABINETSPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPlaceAdressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKabAdress)).BeginInit();
            this.adressKabinet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCabAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KabinetPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.SuspendLayout();
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
            // qWorkPlace
            // 
            this.qWorkPlace.DataSetName = "qWorkPlace";
            this.qWorkPlace.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wORKPLACESBindingSource
            // 
            this.wORKPLACESBindingSource.DataMember = "WORKPLACES";
            this.wORKPLACESBindingSource.DataSource = this.qWorkPlace;
            // 
            // mnAdd
            // 
            this.mnAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.удвлитьToolStripMenuItem});
            this.mnAdd.Name = "contextMenuStrip1";
            this.mnAdd.Size = new System.Drawing.Size(170, 54);
            this.mnAdd.Opening += new System.ComponentModel.CancelEventHandler(this.mnAdd_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::pnptv.Properties.Resources.new24_h;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 6);
            // 
            // удвлитьToolStripMenuItem
            // 
            this.удвлитьToolStripMenuItem.Image = global::pnptv.Properties.Resources.delete24_h;
            this.удвлитьToolStripMenuItem.Name = "удвлитьToolStripMenuItem";
            this.удвлитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.удвлитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.удвлитьToolStripMenuItem.Text = "Удалить";
            this.удвлитьToolStripMenuItem.Click += new System.EventHandler(this.удвлитьToolStripMenuItem_Click);
            // 
            // qRaspBindingSource
            // 
            this.qRaspBindingSource.DataMember = "qRasp";
            this.qRaspBindingSource.DataSource = this.qDoctor;
            this.qRaspBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.qRaspBindingSource_AddingNew);
            // 
            // qVidgetInMonBindingSource
            // 
            this.qVidgetInMonBindingSource.DataMember = "qVidgetInMon";
            this.qVidgetInMonBindingSource.DataSource = this.qDoctor;
            // 
            // vIDJETBindingSource
            // 
            this.vIDJETBindingSource.DataMember = "VIDJET";
            this.vIDJETBindingSource.DataSource = this.qDoctor;
            // 
            // mONITORSBindingSource
            // 
            this.mONITORSBindingSource.DataMember = "MONITORS";
            this.mONITORSBindingSource.DataSource = this.qDoctor;
            // 
            // sETUPBindingSource
            // 
            this.sETUPBindingSource.DataMember = "SETUP";
            this.sETUPBindingSource.DataSource = this.qDoctor;
            // 
            // wORKPLACESTableAdapter
            // 
            this.wORKPLACESTableAdapter.ClearBeforeFill = true;
            // 
            // dOCTORSTableAdapter
            // 
            this.dOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // qRaspTableAdapter
            // 
            this.qRaspTableAdapter.ClearBeforeFill = true;
            // 
            // sETUPTableAdapter
            // 
            this.sETUPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdaptVidgetInMon = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORSTableAdapter = this.dOCTORSTableAdapter;
            this.tableAdapterManager.MONITORSTableAdapter = null;
            this.tableAdapterManager.SETUPREFRESHTableAdapter = null;
            this.tableAdapterManager.SETUPTableAdapter = this.sETUPTableAdapter;
            this.tableAdapterManager.UpdateOrder = pnptv.qDoctorTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VIDJETTableAdapter = null;
            // 
            // adaptVidgetInMon
            // 
            this.adaptVidgetInMon.ClearBeforeFill = true;
            // 
            // vIDJETTableAdapter
            // 
            this.vIDJETTableAdapter.ClearBeforeFill = true;
            // 
            // mONITORSTableAdapter
            // 
            this.mONITORSTableAdapter.ClearBeforeFill = true;
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // toolbars
            // 
            this.toolbars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInTv,
            this.ClearAllShow});
            this.toolbars.Location = new System.Drawing.Point(0, 0);
            this.toolbars.Name = "toolbars";
            this.toolbars.Size = new System.Drawing.Size(800, 25);
            this.toolbars.TabIndex = 1;
            this.toolbars.Text = "toolStrip1";
            // 
            // ShowInTv
            // 
            this.ShowInTv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowInTv.Image = global::pnptv.Properties.Resources.player_play_32x32;
            this.ShowInTv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowInTv.Name = "ShowInTv";
            this.ShowInTv.Size = new System.Drawing.Size(23, 22);
            this.ShowInTv.Text = "Запустить показ";
            this.ShowInTv.Click += new System.EventHandler(this.ShowInTv_Click);
            // 
            // ClearAllShow
            // 
            this.ClearAllShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearAllShow.Image = global::pnptv.Properties.Resources.player_stop_32x32;
            this.ClearAllShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearAllShow.Name = "ClearAllShow";
            this.ClearAllShow.Size = new System.Drawing.Size(23, 22);
            this.ClearAllShow.Text = "Выключить все";
            this.ClearAllShow.Click += new System.EventHandler(this.ClearAllShow_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbMain);
            this.tabControl.Controls.Add(this.tabRasp);
            this.tabControl.Controls.Add(this.tabMons);
            this.tabControl.Controls.Add(this.tbschedule);
            this.tabControl.Controls.Add(this.tbKabinets);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tbMain,
            this.tabRasp,
            this.tabMons,
            this.tbschedule,
            this.tbKabinets});
            this.tabControl.RegularSize = new System.Drawing.Size(800, 425);
            this.tabControl.SelectedPage = this.tbMain;
            this.tabControl.Size = new System.Drawing.Size(800, 425);
            this.tabControl.TabIndex = 2;
            this.tabControl.Text = "tabRasp";
            this.tabControl.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabControl_SelectedPageChanged);
            // 
            // tbMain
            // 
            this.tbMain.Caption = "Общие";
            this.tbMain.Controls.Add(this.panelControl1);
            this.tbMain.Controls.Add(this.panelControl);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(800, 398);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 149);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 249);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.dOCTORSBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 226);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL1,
            this.colFIO,
            this.colSPECIALIZATION});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridView1_RowDeleted);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colIDALL1
            // 
            this.colIDALL1.Caption = "ID";
            this.colIDALL1.FieldName = "IDALL";
            this.colIDALL1.Name = "colIDALL1";
            this.colIDALL1.Visible = true;
            this.colIDALL1.VisibleIndex = 0;
            this.colIDALL1.Width = 55;
            // 
            // colFIO
            // 
            this.colFIO.Caption = "Фамилия Имя Отчество";
            this.colFIO.FieldName = "FIO";
            this.colFIO.Name = "colFIO";
            this.colFIO.Visible = true;
            this.colFIO.VisibleIndex = 1;
            this.colFIO.Width = 402;
            // 
            // colSPECIALIZATION
            // 
            this.colSPECIALIZATION.Caption = "Специальность";
            this.colSPECIALIZATION.FieldName = "SPECIALIZATION";
            this.colSPECIALIZATION.Name = "colSPECIALIZATION";
            this.colSPECIALIZATION.Visible = true;
            this.colSPECIALIZATION.VisibleIndex = 2;
            this.colSPECIALIZATION.Width = 832;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Врачи";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.gWorkplace);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(800, 149);
            this.panelControl.TabIndex = 0;
            // 
            // gWorkplace
            // 
            this.gWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gWorkplace.DataMember = "WORKPLACES";
            this.gWorkplace.DataSource = this.qWorkPlace;
            this.gWorkplace.Location = new System.Drawing.Point(5, 18);
            this.gWorkplace.MainView = this.gvWorkPlace;
            this.gWorkplace.Name = "gWorkplace";
            this.gWorkplace.Size = new System.Drawing.Size(790, 128);
            this.gWorkplace.TabIndex = 2;
            this.gWorkplace.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkPlace});
            // 
            // gvWorkPlace
            // 
            this.gvWorkPlace.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL,
            this.colNAME,
            this.colADRESS,
            this.colPRIM});
            this.gvWorkPlace.GridControl = this.gWorkplace;
            this.gvWorkPlace.Name = "gvWorkPlace";
            this.gvWorkPlace.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvWorkPlace.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvWorkPlace.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvWorkPlace.OptionsView.ShowGroupPanel = false;
            this.gvWorkPlace.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvWorkPlace_RowDeleted);
            this.gvWorkPlace.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvWorkPlace_RowUpdated);
            // 
            // colIDALL
            // 
            this.colIDALL.Caption = "ID";
            this.colIDALL.FieldName = "IDALL";
            this.colIDALL.Name = "colIDALL";
            this.colIDALL.Visible = true;
            this.colIDALL.VisibleIndex = 0;
            this.colIDALL.Width = 57;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Наимнование";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            this.colNAME.Width = 410;
            // 
            // colADRESS
            // 
            this.colADRESS.Caption = "Адрес";
            this.colADRESS.FieldName = "ADRESS";
            this.colADRESS.Name = "colADRESS";
            this.colADRESS.Visible = true;
            this.colADRESS.VisibleIndex = 2;
            this.colADRESS.Width = 410;
            // 
            // colPRIM
            // 
            this.colPRIM.Caption = "Примечание (Текст или HTML)";
            this.colPRIM.FieldName = "PRIM";
            this.colPRIM.Name = "colPRIM";
            this.colPRIM.Visible = true;
            this.colPRIM.VisibleIndex = 3;
            this.colPRIM.Width = 412;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организации";
            // 
            // tabRasp
            // 
            this.tabRasp.Caption = "Расписание работы";
            this.tabRasp.Controls.Add(this.panelControl2);
            this.tabRasp.Name = "tabRasp";
            this.tabRasp.Size = new System.Drawing.Size(800, 398);
            this.tabRasp.Enter += new System.EventHandler(this.tabRasp_Enter_1);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridLookUpOrg);
            this.panelControl2.Controls.Add(this.gridControl2);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 398);
            this.panelControl2.TabIndex = 2;
            // 
            // gridLookUpOrg
            // 
            this.gridLookUpOrg.Location = new System.Drawing.Point(103, 5);
            this.gridLookUpOrg.Name = "gridLookUpOrg";
            this.gridLookUpOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpOrg.Properties.DataSource = this.wORKPLACESBindingSource;
            this.gridLookUpOrg.Properties.DisplayMember = "NAME";
            this.gridLookUpOrg.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpOrg.Properties.ValueMember = "IDALL";
            this.gridLookUpOrg.Size = new System.Drawing.Size(333, 20);
            this.gridLookUpOrg.TabIndex = 3;
            this.gridLookUpOrg.EditValueChanged += new System.EventHandler(this.gridLookUpOrg_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL2,
            this.colNAME1,
            this.colADRESS1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIDALL2
            // 
            this.colIDALL2.Caption = "ID";
            this.colIDALL2.FieldName = "IDALL";
            this.colIDALL2.Name = "colIDALL2";
            this.colIDALL2.Visible = true;
            this.colIDALL2.VisibleIndex = 0;
            this.colIDALL2.Width = 51;
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "Наименование";
            this.colNAME1.FieldName = "NAME";
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 1;
            this.colNAME1.Width = 546;
            // 
            // colADRESS1
            // 
            this.colADRESS1.Caption = "Адрес";
            this.colADRESS1.FieldName = "ADRESS";
            this.colADRESS1.Name = "colADRESS1";
            this.colADRESS1.Visible = true;
            this.colADRESS1.VisibleIndex = 2;
            this.colADRESS1.Width = 692;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.ContextMenuStrip = this.mnAdd;
            this.gridControl2.DataSource = this.qRaspBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(5, 31);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SelectDoctor});
            this.gridControl2.Size = new System.Drawing.Size(790, 362);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL3,
            this.colIDWORKPLACE,
            this.colIDPEPLE,
            this.colKAB,
            this.colETAG,
            this.colPON,
            this.colVTOR,
            this.colSRED,
            this.colCHET,
            this.colPATN,
            this.colSUB,
            this.colVOSK,
            this.colSPECIALIZATION1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "FIO", this.colIDALL3, "", "1")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView2.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colIDALL3
            // 
            this.colIDALL3.FieldName = "IDALL";
            this.colIDALL3.Name = "colIDALL3";
            this.colIDALL3.Width = 50;
            // 
            // colIDWORKPLACE
            // 
            this.colIDWORKPLACE.FieldName = "IDWORKPLACE";
            this.colIDWORKPLACE.Name = "colIDWORKPLACE";
            this.colIDWORKPLACE.Width = 69;
            // 
            // colIDPEPLE
            // 
            this.colIDPEPLE.Caption = "Врач";
            this.colIDPEPLE.ColumnEdit = this.SelectDoctor;
            this.colIDPEPLE.FieldName = "IDPEPLE";
            this.colIDPEPLE.Name = "colIDPEPLE";
            this.colIDPEPLE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IDPEPLE", "Строк {0}")});
            this.colIDPEPLE.Visible = true;
            this.colIDPEPLE.VisibleIndex = 0;
            this.colIDPEPLE.Width = 174;
            // 
            // SelectDoctor
            // 
            this.SelectDoctor.AutoHeight = false;
            this.SelectDoctor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectDoctor.DataSource = this.dOCTORSBindingSource;
            this.SelectDoctor.DisplayMember = "FIO";
            this.SelectDoctor.KeyMember = "IDALL";
            this.SelectDoctor.Name = "SelectDoctor";
            this.SelectDoctor.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.SelectDoctor.PopupFormSize = new System.Drawing.Size(360, 0);
            this.SelectDoctor.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.SelectDoctor.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.SelectDoctor.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            this.SelectDoctor.ValueMember = "IDALL";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL4,
            this.colFIO2,
            this.colSPECIALIZATION2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIDALL4
            // 
            this.colIDALL4.FieldName = "IDALL";
            this.colIDALL4.Name = "colIDALL4";
            this.colIDALL4.Visible = true;
            this.colIDALL4.VisibleIndex = 0;
            this.colIDALL4.Width = 51;
            // 
            // colFIO2
            // 
            this.colFIO2.FieldName = "FIO";
            this.colFIO2.Name = "colFIO2";
            this.colFIO2.Visible = true;
            this.colFIO2.VisibleIndex = 1;
            this.colFIO2.Width = 446;
            // 
            // colSPECIALIZATION2
            // 
            this.colSPECIALIZATION2.FieldName = "SPECIALIZATION";
            this.colSPECIALIZATION2.Name = "colSPECIALIZATION2";
            this.colSPECIALIZATION2.Visible = true;
            this.colSPECIALIZATION2.VisibleIndex = 2;
            this.colSPECIALIZATION2.Width = 664;
            // 
            // colKAB
            // 
            this.colKAB.Caption = "Кабинет";
            this.colKAB.FieldName = "KAB";
            this.colKAB.Name = "colKAB";
            this.colKAB.Visible = true;
            this.colKAB.VisibleIndex = 1;
            this.colKAB.Width = 47;
            // 
            // colETAG
            // 
            this.colETAG.Caption = "Этаж";
            this.colETAG.FieldName = "ETAG";
            this.colETAG.Name = "colETAG";
            this.colETAG.Visible = true;
            this.colETAG.VisibleIndex = 2;
            this.colETAG.Width = 38;
            // 
            // colPON
            // 
            this.colPON.Caption = "Пон.";
            this.colPON.FieldName = "PON";
            this.colPON.Name = "colPON";
            this.colPON.Visible = true;
            this.colPON.VisibleIndex = 3;
            this.colPON.Width = 89;
            // 
            // colVTOR
            // 
            this.colVTOR.Caption = "Вт.";
            this.colVTOR.FieldName = "VTOR";
            this.colVTOR.Name = "colVTOR";
            this.colVTOR.Visible = true;
            this.colVTOR.VisibleIndex = 4;
            this.colVTOR.Width = 89;
            // 
            // colSRED
            // 
            this.colSRED.Caption = "Среда";
            this.colSRED.FieldName = "SRED";
            this.colSRED.Name = "colSRED";
            this.colSRED.Visible = true;
            this.colSRED.VisibleIndex = 5;
            this.colSRED.Width = 89;
            // 
            // colCHET
            // 
            this.colCHET.Caption = "Чет.";
            this.colCHET.FieldName = "CHET";
            this.colCHET.Name = "colCHET";
            this.colCHET.Visible = true;
            this.colCHET.VisibleIndex = 6;
            this.colCHET.Width = 89;
            // 
            // colPATN
            // 
            this.colPATN.Caption = "Пт.";
            this.colPATN.FieldName = "PATN";
            this.colPATN.Name = "colPATN";
            this.colPATN.Visible = true;
            this.colPATN.VisibleIndex = 7;
            this.colPATN.Width = 89;
            // 
            // colSUB
            // 
            this.colSUB.Caption = "Суб.";
            this.colSUB.FieldName = "SUB";
            this.colSUB.Name = "colSUB";
            this.colSUB.Visible = true;
            this.colSUB.VisibleIndex = 8;
            this.colSUB.Width = 89;
            // 
            // colVOSK
            // 
            this.colVOSK.Caption = "Вс.";
            this.colVOSK.FieldName = "VOSK";
            this.colVOSK.Name = "colVOSK";
            this.colVOSK.Visible = true;
            this.colVOSK.VisibleIndex = 9;
            this.colVOSK.Width = 89;
            // 
            // colSPECIALIZATION1
            // 
            this.colSPECIALIZATION1.Caption = "Специальность";
            this.colSPECIALIZATION1.FieldName = "SPECIALIZATION";
            this.colSPECIALIZATION1.Name = "colSPECIALIZATION1";
            this.colSPECIALIZATION1.Visible = true;
            this.colSPECIALIZATION1.VisibleIndex = 10;
            this.colSPECIALIZATION1.Width = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Отделение:";
            // 
            // tabMons
            // 
            this.tabMons.Caption = "Мониторы";
            this.tabMons.Controls.Add(this.label9);
            this.tabMons.Controls.Add(this.RefreshTime);
            this.tabMons.Controls.Add(this.label8);
            this.tabMons.Controls.Add(this.gridmon);
            this.tabMons.Controls.Add(this.label7);
            this.tabMons.Controls.Add(this.label6);
            this.tabMons.Controls.Add(this.spinMinitors);
            this.tabMons.Controls.Add(this.label5);
            this.tabMons.Controls.Add(this.LabCnt);
            this.tabMons.Controls.Add(this.label4);
            this.tabMons.Controls.Add(this.WorkedMonitors);
            this.tabMons.Name = "tabMons";
            this.tabMons.Size = new System.Drawing.Size(800, 398);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "час (ов)";
            // 
            // RefreshTime
            // 
            this.RefreshTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sETUPREFRESHBindingSource, "VALUEINT", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0"));
            this.RefreshTime.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.RefreshTime.Location = new System.Drawing.Point(549, 6);
            this.RefreshTime.Name = "RefreshTime";
            this.RefreshTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RefreshTime.Properties.IsFloatValue = false;
            this.RefreshTime.Properties.Mask.EditMask = "N00";
            this.RefreshTime.Size = new System.Drawing.Size(53, 20);
            this.RefreshTime.TabIndex = 9;
            this.RefreshTime.ToolTip = "Установите 0, чтобы отключить автообновление";
            this.RefreshTime.Leave += new System.EventHandler(this.RefreshTime_Leave);
            // 
            // sETUPREFRESHBindingSource
            // 
            this.sETUPREFRESHBindingSource.DataMember = "SETUPREFRESH";
            this.sETUPREFRESHBindingSource.DataSource = this.qDoctor;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Обновлять каждые";
            // 
            // gridmon
            // 
            this.gridmon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridmon.ContextMenuStrip = this.menuVidgets;
            this.gridmon.DataSource = this.qVidgetInMonBindingSource;
            this.gridmon.Location = new System.Drawing.Point(15, 68);
            this.gridmon.MainView = this.gridViewMon;
            this.gridmon.Name = "gridmon";
            this.gridmon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ResVidget});
            this.gridmon.Size = new System.Drawing.Size(773, 316);
            this.gridmon.TabIndex = 7;
            this.gridmon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMon});
            // 
            // menuVidgets
            // 
            this.menuVidgets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetupPage,
            this.ViewPage,
            this.btCpopy,
            this.btPaste,
            this.toolStripMenuItem2,
            this.удалитьToolStripMenuItem});
            this.menuVidgets.Name = "menuVidgets";
            this.menuVidgets.Size = new System.Drawing.Size(209, 120);
            this.menuVidgets.Opening += new System.ComponentModel.CancelEventHandler(this.menuVidgets_Opening);
            // 
            // SetupPage
            // 
            this.SetupPage.Image = global::pnptv.Properties.Resources.edit;
            this.SetupPage.Name = "SetupPage";
            this.SetupPage.Size = new System.Drawing.Size(208, 22);
            this.SetupPage.Text = "Настроить внешний вид";
            this.SetupPage.ToolTipText = "Испльзуйте клавиши Alt+F4 для закрытия окна";
            this.SetupPage.Click += new System.EventHandler(this.SetupPage_Click);
            // 
            // ViewPage
            // 
            this.ViewPage.Image = global::pnptv.Properties.Resources.player_play_32x32;
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.Size = new System.Drawing.Size(208, 22);
            this.ViewPage.Text = "Посмотреть";
            this.ViewPage.ToolTipText = "Испльзуйте клавиши Alt+F4 для закрытия окна";
            this.ViewPage.Click += new System.EventHandler(this.ViewPage_Click);
            // 
            // btCpopy
            // 
            this.btCpopy.Image = global::pnptv.Properties.Resources.copy_clipboard24;
            this.btCpopy.Name = "btCpopy";
            this.btCpopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btCpopy.Size = new System.Drawing.Size(208, 22);
            this.btCpopy.Text = "Копировать";
            this.btCpopy.Click += new System.EventHandler(this.btCpopy_Click);
            // 
            // btPaste
            // 
            this.btPaste.Image = global::pnptv.Properties.Resources.paste_clipboard241;
            this.btPaste.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPaste.Name = "btPaste";
            this.btPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btPaste.Size = new System.Drawing.Size(208, 22);
            this.btPaste.Text = "Вставить";
            this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::pnptv.Properties.Resources.delete24_h;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // gridViewMon
            // 
            this.gridViewMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL5,
            this.colIDMON,
            this.colSORTS,
            this.colCNTMON,
            this.colGUID,
            this.colIDVIDGET,
            this.colPARAMS,
            this.colNAME2,
            this.colPRIMS});
            this.gridViewMon.GridControl = this.gridmon;
            this.gridViewMon.Name = "gridViewMon";
            this.gridViewMon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewMon.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridViewMon.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewMon.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewMon.OptionsView.ShowGroupPanel = false;
            this.gridViewMon.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewMon_RowUpdated);
            // 
            // colIDALL5
            // 
            this.colIDALL5.FieldName = "IDALL";
            this.colIDALL5.Name = "colIDALL5";
            // 
            // colIDMON
            // 
            this.colIDMON.Caption = "Монитор";
            this.colIDMON.FieldName = "IDMON";
            this.colIDMON.Name = "colIDMON";
            this.colIDMON.Visible = true;
            this.colIDMON.VisibleIndex = 0;
            this.colIDMON.Width = 103;
            // 
            // colSORTS
            // 
            this.colSORTS.Caption = "№ п.п.";
            this.colSORTS.FieldName = "SORTS";
            this.colSORTS.Name = "colSORTS";
            this.colSORTS.ToolTip = "Виджет с бОльшим номером будет закрыт виджетом с меньшим номером";
            this.colSORTS.Visible = true;
            this.colSORTS.VisibleIndex = 1;
            this.colSORTS.Width = 65;
            // 
            // colCNTMON
            // 
            this.colCNTMON.FieldName = "CNTMON";
            this.colCNTMON.Name = "colCNTMON";
            // 
            // colGUID
            // 
            this.colGUID.FieldName = "GUID";
            this.colGUID.Name = "colGUID";
            // 
            // colIDVIDGET
            // 
            this.colIDVIDGET.Caption = "Виджет";
            this.colIDVIDGET.ColumnEdit = this.ResVidget;
            this.colIDVIDGET.FieldName = "IDVIDGET";
            this.colIDVIDGET.Name = "colIDVIDGET";
            this.colIDVIDGET.Visible = true;
            this.colIDVIDGET.VisibleIndex = 2;
            this.colIDVIDGET.Width = 311;
            // 
            // ResVidget
            // 
            this.ResVidget.AutoHeight = false;
            this.ResVidget.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ResVidget.DataSource = this.vIDJETBindingSource;
            this.ResVidget.DisplayMember = "NAME";
            this.ResVidget.KeyMember = "IDALL";
            this.ResVidget.Name = "ResVidget";
            this.ResVidget.PopupView = this.gridView3;
            this.ResVidget.ValueMember = "IDALL";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL6,
            this.colNAME3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIDALL6
            // 
            this.colIDALL6.Caption = "ID";
            this.colIDALL6.FieldName = "IDALL";
            this.colIDALL6.Name = "colIDALL6";
            this.colIDALL6.Visible = true;
            this.colIDALL6.VisibleIndex = 0;
            this.colIDALL6.Width = 76;
            // 
            // colNAME3
            // 
            this.colNAME3.Caption = "Наименование";
            this.colNAME3.FieldName = "NAME";
            this.colNAME3.Name = "colNAME3";
            this.colNAME3.Visible = true;
            this.colNAME3.VisibleIndex = 1;
            this.colNAME3.Width = 1085;
            // 
            // colPARAMS
            // 
            this.colPARAMS.Caption = "Параметры";
            this.colPARAMS.FieldName = "PARAMS";
            this.colPARAMS.Name = "colPARAMS";
            this.colPARAMS.Visible = true;
            this.colPARAMS.VisibleIndex = 4;
            this.colPARAMS.Width = 506;
            // 
            // colNAME2
            // 
            this.colNAME2.Caption = "Виджет";
            this.colNAME2.FieldName = "NAME";
            this.colNAME2.Name = "colNAME2";
            this.colNAME2.Width = 542;
            // 
            // colPRIMS
            // 
            this.colPRIMS.Caption = "Примечание";
            this.colPRIMS.FieldName = "PRIMS";
            this.colPRIMS.Name = "colPRIMS";
            this.colPRIMS.Visible = true;
            this.colPRIMS.VisibleIndex = 3;
            this.colPRIMS.Width = 176;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Настройка для";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "мониторов";
            // 
            // spinMinitors
            // 
            this.spinMinitors.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qDoctor, "SETUP.VALUEINT", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.spinMinitors.EditValue = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.spinMinitors.Location = new System.Drawing.Point(284, 6);
            this.spinMinitors.Name = "spinMinitors";
            this.spinMinitors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMinitors.Properties.IsFloatValue = false;
            this.spinMinitors.Properties.Mask.EditMask = "N00";
            this.spinMinitors.Size = new System.Drawing.Size(68, 20);
            this.spinMinitors.TabIndex = 3;
            this.spinMinitors.Leave += new System.EventHandler(this.spinMinitors_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "У меня установлено";
            // 
            // LabCnt
            // 
            this.LabCnt.AutoSize = true;
            this.LabCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabCnt.Location = new System.Drawing.Point(127, 9);
            this.LabCnt.Name = "LabCnt";
            this.LabCnt.Size = new System.Drawing.Size(14, 13);
            this.LabCnt.TabIndex = 1;
            this.LabCnt.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Доступо мониторов";
            // 
            // WorkedMonitors
            // 
            this.WorkedMonitors.EditValue = "5 работающих мониторов";
            this.WorkedMonitors.Location = new System.Drawing.Point(111, 33);
            this.WorkedMonitors.Name = "WorkedMonitors";
            this.WorkedMonitors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkedMonitors.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1)});
            this.WorkedMonitors.Size = new System.Drawing.Size(241, 20);
            this.WorkedMonitors.TabIndex = 6;
            this.WorkedMonitors.SelectedIndexChanged += new System.EventHandler(this.WorkedMonitors_SelectedIndexChanged);
            // 
            // tbschedule
            // 
            this.tbschedule.Caption = "Занятость кабинетов";
            this.tbschedule.Controls.Add(this.panelControl3);
            this.tbschedule.Controls.Add(this.toolStripSchedule);
            this.tbschedule.Name = "tbschedule";
            this.tbschedule.Size = new System.Drawing.Size(800, 398);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 31);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(800, 367);
            this.panelControl3.TabIndex = 6;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.schedulerControls);
            this.panelControl4.Controls.Add(this.resourcesTree1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 36);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(796, 329);
            this.panelControl4.TabIndex = 10;
            // 
            // schedulerControls
            // 
            this.schedulerControls.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControls.DataStorage = this.schedulerData;
            this.schedulerControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControls.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControls.Location = new System.Drawing.Point(175, 2);
            this.schedulerControls.Name = "schedulerControls";
            this.schedulerControls.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden;
            this.schedulerControls.Size = new System.Drawing.Size(619, 325);
            this.schedulerControls.Start = new System.DateTime(2023, 8, 10, 0, 0, 0, 0);
            this.schedulerControls.TabIndex = 11;
            this.schedulerControls.Text = "schedulerControls";
            this.schedulerControls.Views.AgendaView.Enabled = false;
            this.schedulerControls.Views.DayView.Enabled = false;
            this.schedulerControls.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControls.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControls.Views.FullWeekView.ShowWorkTimeOnly = true;
            this.schedulerControls.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControls.Views.GanttView.Enabled = false;
            this.schedulerControls.Views.MonthView.Enabled = false;
            this.schedulerControls.Views.TimelineView.AppointmentDisplayOptions.AppointmentHeight = 35;
            this.schedulerControls.Views.TimelineView.CellsAutoHeightOptions.Enabled = true;
            this.schedulerControls.Views.TimelineView.CellsAutoHeightOptions.MinHeight = 30;
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            timeScaleWeek1.Enabled = false;
            timeScaleHour1.Width = 80;
            timeScale15Minutes1.Enabled = false;
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScaleYear1);
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScaleQuarter1);
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScaleMonth1);
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScaleWeek1);
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScaleDay1);
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScaleHour1);
            this.schedulerControls.Views.TimelineView.Scales.Add(timeScale15Minutes1);
            this.schedulerControls.Views.TimelineView.WorkTime = new DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("19:00:00"));
            this.schedulerControls.Views.WeekView.Enabled = false;
            this.schedulerControls.Views.WorkWeekView.Enabled = false;
            this.schedulerControls.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControls.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControls.SelectionChanged += new System.EventHandler(this.schedulerControls_SelectionChanged);
            this.schedulerControls.VisibleIntervalChanged += new System.EventHandler(this.schedulerControls_VisibleIntervalChanged);
            this.schedulerControls.InitAppointmentDisplayText += new DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(this.schedulerControl1_InitAppointmentDisplayText);
            this.schedulerControls.InitNewAppointment += new DevExpress.XtraScheduler.AppointmentEventHandler(this.schedulerControls_InitNewAppointment);
            this.schedulerControls.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControls_EditAppointmentFormShowing);
            this.schedulerControls.Resize += new System.EventHandler(this.schedulerControls_Resize);
            // 
            // schedulerData
            // 
            // 
            // 
            // 
            this.schedulerData.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerData.Appointments.DataSource = this.qScheduleBindingSource;
            this.schedulerData.Appointments.Mappings.Description = "DESCRIPTION";
            this.schedulerData.Appointments.Mappings.End = "ENDS";
            this.schedulerData.Appointments.Mappings.Label = "FIO";
            this.schedulerData.Appointments.Mappings.Location = "IDVRACH";
            this.schedulerData.Appointments.Mappings.ResourceId = "IDKABINET";
            this.schedulerData.Appointments.Mappings.Start = "START";
            this.schedulerData.Appointments.Mappings.Status = "IDVRACH";
            this.schedulerData.Appointments.Mappings.Subject = "FIO";
            // 
            // 
            // 
            this.schedulerData.Resources.DataSource = this.qResourceBindingSource;
            this.schedulerData.Resources.Mappings.Caption = "NAME";
            this.schedulerData.Resources.Mappings.Id = "IDALL";
            this.schedulerData.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerData_AppointmentsInserted);
            this.schedulerData.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerData_AppointmentsChanged);
            this.schedulerData.AppointmentDeleting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerData_AppointmentDeleting);
            this.schedulerData.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerData_AppointmentsDeleted);
            // 
            // qScheduleBindingSource
            // 
            this.qScheduleBindingSource.DataMember = "qSchedule";
            this.qScheduleBindingSource.DataSource = this.dmSchedule;
            // 
            // dmSchedule
            // 
            this.dmSchedule.DataSetName = "dmSchedule";
            this.dmSchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qResourceBindingSource
            // 
            this.qResourceBindingSource.DataMember = "qResource";
            this.qResourceBindingSource.DataSource = this.dmSchedule;
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ColOne});
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Left;
            this.resourcesTree1.Location = new System.Drawing.Point(2, 2);
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.resourcesTree1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick;
            this.resourcesTree1.OptionsFind.AllowIncrementalSearch = true;
            this.resourcesTree1.OptionsFind.AlwaysVisible = true;
            this.resourcesTree1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.resourcesTree1.OptionsFind.ShowFindButton = false;
            this.resourcesTree1.OptionsFind.ShowSearchNavButtons = false;
            this.resourcesTree1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.resourcesTree1.SchedulerControl = this.schedulerControls;
            this.resourcesTree1.Size = new System.Drawing.Size(173, 325);
            this.resourcesTree1.TabIndex = 10;
            // 
            // ColOne
            // 
            this.ColOne.Caption = "  Кабинет / Этаж ";
            this.ColOne.ColumnEdit = this.repositoryItemTextEdit1;
            this.ColOne.FieldName = "NAME";
            this.ColOne.Name = "ColOne";
            this.ColOne.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.ColOne.Visible = true;
            this.ColOne.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.WorkPlaceSchedule);
            this.panelControl5.Controls.Add(this.label10);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(796, 34);
            this.panelControl5.TabIndex = 9;
            // 
            // WorkPlaceSchedule
            // 
            this.WorkPlaceSchedule.Location = new System.Drawing.Point(101, 5);
            this.WorkPlaceSchedule.Name = "WorkPlaceSchedule";
            this.WorkPlaceSchedule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkPlaceSchedule.Properties.DataSource = this.wORKPLACESBindingSource;
            this.WorkPlaceSchedule.Properties.DisplayMember = "NAME";
            this.WorkPlaceSchedule.Properties.PopupView = this.gridView5;
            this.WorkPlaceSchedule.Properties.ValueMember = "IDALL";
            this.WorkPlaceSchedule.Size = new System.Drawing.Size(333, 20);
            this.WorkPlaceSchedule.TabIndex = 5;
            this.WorkPlaceSchedule.EditValueChanged += new System.EventHandler(this.WorkPlaceSchedule_EditValueChanged);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IDALL";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 51;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Наименование";
            this.gridColumn2.FieldName = "NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 546;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Адрес";
            this.gridColumn3.FieldName = "ADRESS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 692;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Отделение:";
            // 
            // toolStripSchedule
            // 
            this.toolStripSchedule.ContextMenuStrip = this.menuSchedule;
            this.toolStripSchedule.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRefresh,
            this.tbFindFreeCab,
            this.toolStripSeparator1,
            this.tbCopy,
            this.tbPaste,
            this.tbCopuSpecials,
            this.tbFind});
            this.toolStripSchedule.Location = new System.Drawing.Point(0, 0);
            this.toolStripSchedule.Name = "toolStripSchedule";
            this.toolStripSchedule.Size = new System.Drawing.Size(800, 31);
            this.toolStripSchedule.TabIndex = 0;
            this.toolStripSchedule.Text = "Занятость кабинетов";
            // 
            // menuSchedule
            // 
            this.menuSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsripFind});
            this.menuSchedule.Name = "menuSchedule";
            this.menuSchedule.Size = new System.Drawing.Size(216, 26);
            // 
            // tsripFind
            // 
            this.tsripFind.Image = global::pnptv.Properties.Resources.Find_32x32;
            this.tsripFind.Name = "tsripFind";
            this.tsripFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsripFind.Size = new System.Drawing.Size(215, 22);
            this.tsripFind.Text = "Найти и заменить";
            this.tsripFind.Click += new System.EventHandler(this.tsripFind_Click);
            // 
            // tbRefresh
            // 
            this.tbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbRefresh.Image")));
            this.tbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(28, 28);
            this.tbRefresh.Text = "Обновить";
            this.tbRefresh.ToolTipText = "Обновить";
            this.tbRefresh.Click += new System.EventHandler(this.tbRefresh_Click);
            // 
            // tbFindFreeCab
            // 
            this.tbFindFreeCab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFindFreeCab.Image = global::pnptv.Properties.Resources.Calendar_32x32;
            this.tbFindFreeCab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFindFreeCab.Name = "tbFindFreeCab";
            this.tbFindFreeCab.Size = new System.Drawing.Size(28, 28);
            this.tbFindFreeCab.ToolTipText = "Найти свободные кабинеты";
            this.tbFindFreeCab.Click += new System.EventHandler(this.tbFindFreeCab_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = global::pnptv.Properties.Resources.Copy_32x32;
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(28, 28);
            this.tbCopy.ToolTipText = "Скопировать";
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Image = global::pnptv.Properties.Resources.Paste_32x32;
            this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(28, 28);
            this.tbPaste.ToolTipText = "Вставить";
            this.tbPaste.Click += new System.EventHandler(this.tbPaste_Click);
            // 
            // tbCopuSpecials
            // 
            this.tbCopuSpecials.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopuSpecials.Image = ((System.Drawing.Image)(resources.GetObject("tbCopuSpecials.Image")));
            this.tbCopuSpecials.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopuSpecials.Name = "tbCopuSpecials";
            this.tbCopuSpecials.Size = new System.Drawing.Size(28, 28);
            this.tbCopuSpecials.Text = "Вставить период";
            this.tbCopuSpecials.ToolTipText = "Вставить период\r\n(копирование неделями)";
            this.tbCopuSpecials.Click += new System.EventHandler(this.tbCopuSpecials_Click);
            // 
            // tbFind
            // 
            this.tbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFind.Image = global::pnptv.Properties.Resources.Find_32x32;
            this.tbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(28, 28);
            this.tbFind.Text = "Найти и заменить";
            this.tbFind.Click += new System.EventHandler(this.tbFind_Click);
            // 
            // tbKabinets
            // 
            this.tbKabinets.Caption = "Кабинеты ";
            this.tbKabinets.Controls.Add(this.splitterControl1);
            this.tbKabinets.Controls.Add(this.gCabinet);
            this.tbKabinets.Controls.Add(this.panelControl6);
            this.tbKabinets.Controls.Add(this.panel1);
            this.tbKabinets.Name = "tbKabinets";
            this.tbKabinets.Size = new System.Drawing.Size(800, 398);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(540, 27);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 371);
            this.splitterControl1.TabIndex = 12;
            this.splitterControl1.TabStop = false;
            // 
            // gCabinet
            // 
            this.gCabinet.ContextMenuStrip = this.contextMenuKabinet;
            this.gCabinet.DataSource = this.kABINETSPRBindingSource;
            this.gCabinet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCabinet.Location = new System.Drawing.Point(0, 27);
            this.gCabinet.MainView = this.gridView6;
            this.gCabinet.Name = "gCabinet";
            this.gCabinet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gCabinet.Size = new System.Drawing.Size(545, 371);
            this.gCabinet.TabIndex = 11;
            this.gCabinet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // contextMenuKabinet
            // 
            this.contextMenuKabinet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1});
            this.contextMenuKabinet.Name = "contextMenuKabinet";
            this.contextMenuKabinet.Size = new System.Drawing.Size(170, 26);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = global::pnptv.Properties.Resources.delete24_h;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // kABINETSPRBindingSource
            // 
            this.kABINETSPRBindingSource.DataMember = "KABINETSPR";
            this.kABINETSPRBindingSource.DataSource = this.dmSchedule;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL7,
            this.colIDADRESS,
            this.colNOMER,
            this.colETAG1,
            this.colNAME4});
            this.gridView6.GridControl = this.gCabinet;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView6.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridView6_RowDelete);
            this.gridView6.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView6_RowUpdated);
            // 
            // colIDALL7
            // 
            this.colIDALL7.FieldName = "IDALL";
            this.colIDALL7.Name = "colIDALL7";
            // 
            // colIDADRESS
            // 
            this.colIDADRESS.Caption = "Адрес";
            this.colIDADRESS.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colIDADRESS.FieldName = "IDADRESS";
            this.colIDADRESS.Name = "colIDADRESS";
            this.colIDADRESS.Visible = true;
            this.colIDADRESS.VisibleIndex = 0;
            this.colIDADRESS.Width = 65;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tPlaceAdressBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "SHORTNAME";
            this.repositoryItemGridLookUpEdit1.KeyMember = "IDALL";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView8;
            this.repositoryItemGridLookUpEdit1.ValueMember = "IDALL";
            // 
            // tPlaceAdressBindingSource
            // 
            this.tPlaceAdressBindingSource.DataMember = "tPlaceAdress";
            this.tPlaceAdressBindingSource.DataSource = this.dmSchedule;
            // 
            // gridView8
            // 
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // colNOMER
            // 
            this.colNOMER.Caption = "Номер";
            this.colNOMER.FieldName = "NOMER";
            this.colNOMER.Name = "colNOMER";
            this.colNOMER.Visible = true;
            this.colNOMER.VisibleIndex = 1;
            this.colNOMER.Width = 60;
            // 
            // colETAG1
            // 
            this.colETAG1.Caption = "Этаж";
            this.colETAG1.FieldName = "ETAG";
            this.colETAG1.Name = "colETAG1";
            this.colETAG1.Visible = true;
            this.colETAG1.VisibleIndex = 2;
            this.colETAG1.Width = 49;
            // 
            // colNAME4
            // 
            this.colNAME4.Caption = "Наименование полное";
            this.colNAME4.FieldName = "NAME";
            this.colNAME4.Name = "colNAME4";
            this.colNAME4.Visible = true;
            this.colNAME4.VisibleIndex = 3;
            this.colNAME4.Width = 353;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.gridControlKabAdress);
            this.panelControl6.Controls.Add(this.panelControl7);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(545, 27);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(255, 371);
            this.panelControl6.TabIndex = 9;
            // 
            // gridControlKabAdress
            // 
            this.gridControlKabAdress.ContextMenuStrip = this.adressKabinet;
            this.gridControlKabAdress.DataSource = this.tPlaceAdressBindingSource;
            this.gridControlKabAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKabAdress.Location = new System.Drawing.Point(2, 32);
            this.gridControlKabAdress.MainView = this.gridViewCabAdress;
            this.gridControlKabAdress.Name = "gridControlKabAdress";
            this.gridControlKabAdress.Size = new System.Drawing.Size(251, 337);
            this.gridControlKabAdress.TabIndex = 7;
            this.gridControlKabAdress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCabAdress});
            // 
            // adressKabinet
            // 
            this.adressKabinet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteadresCab});
            this.adressKabinet.Name = "adressKabinet";
            this.adressKabinet.Size = new System.Drawing.Size(119, 26);
            // 
            // DeleteadresCab
            // 
            this.DeleteadresCab.Image = global::pnptv.Properties.Resources.delete24_h;
            this.DeleteadresCab.Name = "DeleteadresCab";
            this.DeleteadresCab.Size = new System.Drawing.Size(118, 22);
            this.DeleteadresCab.Text = "Удалить";
            this.DeleteadresCab.Click += new System.EventHandler(this.DeleteadresCab_Click);
            // 
            // gridViewCabAdress
            // 
            this.gridViewCabAdress.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDALL8,
            this.colSHORTNAME,
            this.colNAME5});
            this.gridViewCabAdress.GridControl = this.gridControlKabAdress;
            this.gridViewCabAdress.Name = "gridViewCabAdress";
            this.gridViewCabAdress.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewCabAdress.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewCabAdress.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewCabAdress.OptionsView.ShowGroupPanel = false;
            this.gridViewCabAdress.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewCabAdress_RowDeleted);
            this.gridViewCabAdress.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewCabAdress_RowUpdated);
            // 
            // colIDALL8
            // 
            this.colIDALL8.FieldName = "IDALL";
            this.colIDALL8.Name = "colIDALL8";
            // 
            // colSHORTNAME
            // 
            this.colSHORTNAME.Caption = "Коротко";
            this.colSHORTNAME.FieldName = "SHORTNAME";
            this.colSHORTNAME.Name = "colSHORTNAME";
            this.colSHORTNAME.Visible = true;
            this.colSHORTNAME.VisibleIndex = 0;
            this.colSHORTNAME.Width = 53;
            // 
            // colNAME5
            // 
            this.colNAME5.Caption = "Полный адрес";
            this.colNAME5.FieldName = "NAME";
            this.colNAME5.Name = "colNAME5";
            this.colNAME5.Visible = true;
            this.colNAME5.VisibleIndex = 1;
            this.colNAME5.Width = 168;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.labelControl1);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl7.Location = new System.Drawing.Point(2, 2);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(251, 30);
            this.panelControl7.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(206, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Место расположения кабинетов (Адрес)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KabinetPlace);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 2;
            // 
            // KabinetPlace
            // 
            this.KabinetPlace.Location = new System.Drawing.Point(98, 4);
            this.KabinetPlace.Name = "KabinetPlace";
            this.KabinetPlace.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.KabinetPlace.Properties.DataSource = this.wORKPLACESBindingSource;
            this.KabinetPlace.Properties.DisplayMember = "NAME";
            this.KabinetPlace.Properties.PopupView = this.gridView7;
            this.KabinetPlace.Properties.ValueMember = "IDALL";
            this.KabinetPlace.Size = new System.Drawing.Size(333, 20);
            this.KabinetPlace.TabIndex = 7;
            this.KabinetPlace.EditValueChanged += new System.EventHandler(this.KabinetPlace_EditValueChanged);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "IDALL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 51;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Наименование";
            this.gridColumn5.FieldName = "NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 546;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Адрес";
            this.gridColumn6.FieldName = "ADRESS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 692;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Отделение:";
            // 
            // VidgetMenu
            // 
            this.VidgetMenu.Name = "VidgetMenu";
            this.VidgetMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // sETUPREFRESHTableAdapter
            // 
            this.sETUPREFRESHTableAdapter.ClearBeforeFill = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // qResourceAdapter
            // 
            this.qResourceAdapter.ClearBeforeFill = true;
            // 
            // qScheduleAdapter
            // 
            this.qScheduleAdapter.ClearBeforeFill = true;
            // 
            // kABINETSPRTableAdapter
            // 
            this.kABINETSPRTableAdapter.ClearBeforeFill = true;
            // 
            // qPlaceAdress
            // 
            this.qPlaceAdress.ClearBeforeFill = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolbars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Настройка мониторов";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKPLACESBindingSource)).EndInit();
            this.mnAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qRaspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qVidgetInMonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIDJETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONITORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.toolbars.ResumeLayout(false);
            this.toolbars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gWorkplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkPlace)).EndInit();
            this.tabRasp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpOrg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.tabMons.ResumeLayout(false);
            this.tabMons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETUPREFRESHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmon)).EndInit();
            this.menuVidgets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResVidget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinitors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedMonitors.Properties)).EndInit();
            this.tbschedule.ResumeLayout(false);
            this.tbschedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qResourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPlaceSchedule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.toolStripSchedule.ResumeLayout(false);
            this.toolStripSchedule.PerformLayout();
            this.menuSchedule.ResumeLayout(false);
            this.tbKabinets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCabinet)).EndInit();
            this.contextMenuKabinet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kABINETSPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPlaceAdressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKabAdress)).EndInit();
            this.adressKabinet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCabAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KabinetPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private qWorkPlace qWorkPlace;
        private System.Windows.Forms.BindingSource wORKPLACESBindingSource;
        private qWorkPlaceTableAdapters.WORKPLACESTableAdapter wORKPLACESTableAdapter;
        private qDoctor qDoctor;
        private System.Windows.Forms.BindingSource dOCTORSBindingSource;
        private qDoctorTableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
        private System.Windows.Forms.BindingSource qRaspBindingSource;
        private qDoctorTableAdapters.qRaspTableAdapter qRaspTableAdapter;
        private System.Windows.Forms.ContextMenuStrip mnAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.BindingSource sETUPBindingSource;
        private qDoctorTableAdapters.SETUPTableAdapter sETUPTableAdapter;
        private qDoctorTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource qVidgetInMonBindingSource;
        private qDoctorTableAdapters.AdaptVidgetInMon adaptVidgetInMon;
        private System.Windows.Forms.BindingSource vIDJETBindingSource;
        private qDoctorTableAdapters.VIDJETTableAdapter vIDJETTableAdapter;
        private System.Windows.Forms.BindingSource mONITORSBindingSource;
        private qDoctorTableAdapters.MONITORSTableAdapter mONITORSTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.ToolStrip toolbars;
        private System.Windows.Forms.ToolStripButton ShowInTv;
        private DevExpress.XtraBars.Navigation.TabPane tabControl;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tbMain;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL1;
        private DevExpress.XtraGrid.Columns.GridColumn colFIO;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALIZATION;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraGrid.GridControl gWorkplace;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIM;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabRasp;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpOrg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL2;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESS1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL3;
        private DevExpress.XtraGrid.Columns.GridColumn colIDWORKPLACE;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPEPLE;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit SelectDoctor;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL4;
        private DevExpress.XtraGrid.Columns.GridColumn colFIO2;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALIZATION2;
        private DevExpress.XtraGrid.Columns.GridColumn colKAB;
        private DevExpress.XtraGrid.Columns.GridColumn colETAG;
        private DevExpress.XtraGrid.Columns.GridColumn colPON;
        private DevExpress.XtraGrid.Columns.GridColumn colVTOR;
        private DevExpress.XtraGrid.Columns.GridColumn colSRED;
        private DevExpress.XtraGrid.Columns.GridColumn colCHET;
        private DevExpress.XtraGrid.Columns.GridColumn colPATN;
        private DevExpress.XtraGrid.Columns.GridColumn colSUB;
        private DevExpress.XtraGrid.Columns.GridColumn colVOSK;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALIZATION1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabMons;
        private DevExpress.XtraGrid.GridControl gridmon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMon;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL5;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMON;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTMON;
        private DevExpress.XtraGrid.Columns.GridColumn colGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDVIDGET;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit ResVidget;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL6;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME3;
        private DevExpress.XtraGrid.Columns.GridColumn colPARAMS;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spinMinitors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabCnt;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ImageComboBoxEdit WorkedMonitors;
        private System.Windows.Forms.ToolStripButton ClearAllShow;
        private System.Windows.Forms.ContextMenuStrip VidgetMenu;
        private System.Windows.Forms.ContextMenuStrip menuVidgets;
        private System.Windows.Forms.ToolStripMenuItem SetupPage;
        private System.Windows.Forms.ToolStripMenuItem ViewPage;
        private System.Windows.Forms.ToolStripMenuItem btCpopy;
        private DevExpress.XtraGrid.Columns.GridColumn colSORTS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem удвлитьToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIMS;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SpinEdit RefreshTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource sETUPREFRESHBindingSource;
        private qDoctorTableAdapters.SETUPREFRESHTableAdapter sETUPREFRESHTableAdapter;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ToolStripMenuItem btPaste;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tbschedule;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerData;
        private System.Windows.Forms.ToolStrip toolStripSchedule;
        private dmSchedule dmSchedule;
        private System.Windows.Forms.BindingSource qResourceBindingSource;
        private dmScheduleTableAdapters.qResourceAdapter qResourceAdapter;
        private System.Windows.Forms.BindingSource qScheduleBindingSource;
        private dmScheduleTableAdapters.qScheduleAdapter qScheduleAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControls;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn ColOne;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit WorkPlaceSchedule;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tbKabinets;
        private System.Windows.Forms.BindingSource kABINETSPRBindingSource;
        private dmScheduleTableAdapters.KABINETSPRTableAdapter kABINETSPRTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GridLookUpEdit KabinetPlace;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuKabinet;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.BindingSource tPlaceAdressBindingSource;
        private dmScheduleTableAdapters.qPlaceAdress qPlaceAdress;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraGrid.GridControl gridControlKabAdress;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCabAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL8;
        private DevExpress.XtraGrid.Columns.GridColumn colSHORTNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME5;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip adressKabinet;
        private System.Windows.Forms.ToolStripMenuItem DeleteadresCab;
        private DevExpress.XtraGrid.GridControl gCabinet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colIDALL7;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMER;
        private DevExpress.XtraGrid.Columns.GridColumn colETAG1;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME4;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDADRESS;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private System.Windows.Forms.ToolStripButton tbFindFreeCab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.ToolStripButton tbCopuSpecials;
        private System.Windows.Forms.ToolStripButton tbFind;
        private System.Windows.Forms.ContextMenuStrip menuSchedule;
        private System.Windows.Forms.ToolStripMenuItem tsripFind;
    }
}


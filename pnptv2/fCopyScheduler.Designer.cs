
namespace pnptv
{
    partial class fCopyScheduler
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
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.dcopyFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dcopyTo = new DevExpress.XtraEditors.DateEdit();
            this.btCopy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.copyWeeks = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyWeeks.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtStartDate.Enabled = false;
            this.edtStartDate.Location = new System.Drawing.Point(127, 36);
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtStartDate.Size = new System.Drawing.Size(100, 20);
            this.edtStartDate.TabIndex = 14;
            this.edtStartDate.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.Appearance.Options.UseTextOptions = true;
            this.lblStartTime.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblStartTime.Location = new System.Drawing.Point(13, 39);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(103, 13);
            this.lblStartTime.TabIndex = 15;
            this.lblStartTime.Text = "Копируемый период";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(13, 65);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(100, 13);
            this.lblEndTime.TabIndex = 16;
            this.lblEndTime.Text = "Период назначения";
            // 
            // dcopyFrom
            // 
            this.dcopyFrom.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.dcopyFrom.Enabled = false;
            this.dcopyFrom.Location = new System.Drawing.Point(127, 62);
            this.dcopyFrom.Name = "dcopyFrom";
            this.dcopyFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.dcopyFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dcopyFrom.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.dcopyFrom.Size = new System.Drawing.Size(100, 20);
            this.dcopyFrom.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Скопировать расписание";
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.edtEndDate.Enabled = false;
            this.edtEndDate.Location = new System.Drawing.Point(233, 36);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtEndDate.Size = new System.Drawing.Size(100, 20);
            this.edtEndDate.TabIndex = 19;
            // 
            // dcopyTo
            // 
            this.dcopyTo.EditValue = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.dcopyTo.Enabled = false;
            this.dcopyTo.Location = new System.Drawing.Point(233, 62);
            this.dcopyTo.Name = "dcopyTo";
            this.dcopyTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.dcopyTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dcopyTo.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.dcopyTo.Size = new System.Drawing.Size(100, 20);
            this.dcopyTo.TabIndex = 20;
            // 
            // btCopy
            // 
            this.btCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCopy.Location = new System.Drawing.Point(161, 136);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(83, 23);
            this.btCopy.TabIndex = 21;
            this.btCopy.Text = "Скопировать";
            this.btCopy.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 8);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(258, 136);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // copyWeeks
            // 
            this.copyWeeks.EditValue = "1 неделю";
            this.copyWeeks.Location = new System.Drawing.Point(127, 88);
            this.copyWeeks.Name = "copyWeeks";
            this.copyWeeks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.copyWeeks.Properties.Items.AddRange(new object[] {
            "1 неделю",
            "2 недели",
            "3 недели",
            "4 недели",
            "5 недель",
            "6 недель",
            "7 недель"});
            this.copyWeeks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.copyWeeks.Size = new System.Drawing.Size(100, 20);
            this.copyWeeks.TabIndex = 24;
            this.copyWeeks.SelectedIndexChanged += new System.EventHandler(this.copyWeeks_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Скопировать на";
            // 
            // fCopyScheduler
            // 
            this.AcceptButton = this.btCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(343, 170);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.copyWeeks);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.dcopyTo);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dcopyFrom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fCopyScheduler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Копирование расписания по неделям";
            this.Shown += new System.EventHandler(this.fCopyScheduler_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcopyTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyWeeks.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btCancel;
        private DevExpress.XtraEditors.ComboBoxEdit copyWeeks;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.DateEdit edtStartDate;
        public DevExpress.XtraEditors.DateEdit dcopyFrom;
        public DevExpress.XtraEditors.DateEdit edtEndDate;
        public DevExpress.XtraEditors.DateEdit dcopyTo;
    }
}
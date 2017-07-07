namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.reports
{
    partial class DisplayBReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayBReport));
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
            this.b_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_ReportTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.B_ReportTableAdapter();
            this.tableAdapterManager = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager();
            this.b_ReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.b_ReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BreportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_ReportBindingNavigator)).BeginInit();
            this.b_ReportBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_ReportBindingSource
            // 
            this.b_ReportBindingSource.DataMember = "B_Report";
            this.b_ReportBindingSource.DataSource = this.entryDBDataSet;
            // 
            // b_ReportTableAdapter
            // 
            this.b_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Court_CaseTableAdapter = null;
            this.tableAdapterManager.Entry_DescriptionTableAdapter = null;
            this.tableAdapterManager.Entry_SuspectTableAdapter = null;
            this.tableAdapterManager.EntryTableAdapter = null;
            this.tableAdapterManager.EvidenceTableAdapter = null;
            this.tableAdapterManager.SuspectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_ImageTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VictimTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // b_ReportBindingNavigator
            // 
            this.b_ReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.b_ReportBindingNavigator.BindingSource = this.b_ReportBindingSource;
            this.b_ReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.b_ReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.b_ReportBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.b_ReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.b_ReportBindingNavigatorSaveItem});
            this.b_ReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.b_ReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.b_ReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.b_ReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.b_ReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.b_ReportBindingNavigator.Name = "b_ReportBindingNavigator";
            this.b_ReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.b_ReportBindingNavigator.Size = new System.Drawing.Size(728, 27);
            this.b_ReportBindingNavigator.TabIndex = 0;
            this.b_ReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // b_ReportBindingNavigatorSaveItem
            // 
            this.b_ReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_ReportBindingNavigatorSaveItem.Enabled = false;
            this.b_ReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("b_ReportBindingNavigatorSaveItem.Image")));
            this.b_ReportBindingNavigatorSaveItem.Name = "b_ReportBindingNavigatorSaveItem";
            this.b_ReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.b_ReportBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // BreportViewer
            // 
            this.BreportViewer.ActiveViewIndex = -1;
            this.BreportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BreportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BreportViewer.Location = new System.Drawing.Point(0, 27);
            this.BreportViewer.Name = "BreportViewer";
            this.BreportViewer.Size = new System.Drawing.Size(728, 457);
            this.BreportViewer.TabIndex = 1;
            this.BreportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DisplayBReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 484);
            this.Controls.Add(this.BreportViewer);
            this.Controls.Add(this.b_ReportBindingNavigator);
            this.Name = "DisplayBReport";
            this.Text = "DisplayBReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayBReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_ReportBindingNavigator)).EndInit();
            this.b_ReportBindingNavigator.ResumeLayout(false);
            this.b_ReportBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource b_ReportBindingSource;
        private EntryDBDataSetTableAdapters.B_ReportTableAdapter b_ReportTableAdapter;
        private EntryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator b_ReportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton b_ReportBindingNavigatorSaveItem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer BreportViewer;
    }
}
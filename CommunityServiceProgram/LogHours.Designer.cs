namespace CommunityServiceProgram
{
    partial class LogHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogHours));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hoursTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.hoursTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communityServiceDataSet = new CommunityServiceProgram.CommunityServiceDataSet();
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
            this.hoursTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hoursTblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.currentDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.enrolledTblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsListTblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programsListTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursTblTableAdapter = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.hoursTblTableAdapter();
            this.tableAdapterManager = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.TableAdapterManager();
            this.enrolledTblTableAdapter = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.enrolledTblTableAdapter();
            this.programsListTblTableAdapter = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.programsListTblTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.progNameTB = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTblBindingNavigator)).BeginInit();
            this.hoursTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledTblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 24);
            this.toolStripLabel1.Text = "Log hours";
            // 
            // hoursTblBindingNavigator
            // 
            this.hoursTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoursTblBindingNavigator.BindingSource = this.hoursTblBindingSource;
            this.hoursTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoursTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hoursTblBindingNavigator.Enabled = false;
            this.hoursTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hoursTblBindingNavigatorSaveItem});
            this.hoursTblBindingNavigator.Location = new System.Drawing.Point(0, 33);
            this.hoursTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoursTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoursTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoursTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoursTblBindingNavigator.Name = "hoursTblBindingNavigator";
            this.hoursTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoursTblBindingNavigator.Size = new System.Drawing.Size(1081, 31);
            this.hoursTblBindingNavigator.TabIndex = 5;
            this.hoursTblBindingNavigator.Text = "bindingNavigator1";
            this.hoursTblBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // hoursTblBindingSource
            // 
            this.hoursTblBindingSource.DataMember = "hoursTbl";
            this.hoursTblBindingSource.DataSource = this.communityServiceDataSet;
            // 
            // communityServiceDataSet
            // 
            this.communityServiceDataSet.DataSetName = "CommunityServiceDataSet";
            this.communityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // hoursTblBindingNavigatorSaveItem
            // 
            this.hoursTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hoursTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoursTblBindingNavigatorSaveItem.Image")));
            this.hoursTblBindingNavigatorSaveItem.Name = "hoursTblBindingNavigatorSaveItem";
            this.hoursTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 28);
            this.hoursTblBindingNavigatorSaveItem.Text = "Save Data";
            this.hoursTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.hoursTblBindingNavigatorSaveItem_Click);
            // 
            // hoursTblDataGridView
            // 
            this.hoursTblDataGridView.AutoGenerateColumns = false;
            this.hoursTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoursTblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hoursTblDataGridView.DataSource = this.hoursTblBindingSource;
            this.hoursTblDataGridView.Location = new System.Drawing.Point(823, 278);
            this.hoursTblDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursTblDataGridView.Name = "hoursTblDataGridView";
            this.hoursTblDataGridView.Size = new System.Drawing.Size(413, 271);
            this.hoursTblDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentId";
            this.dataGridViewTextBoxColumn2.HeaderText = "studentId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sessionDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "sessionDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hours";
            this.dataGridViewTextBoxColumn4.HeaderText = "hours";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "programId";
            this.dataGridViewTextBoxColumn5.HeaderText = "programId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // hoursTB
            // 
            this.hoursTB.Location = new System.Drawing.Point(176, 102);
            this.hoursTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(132, 22);
            this.hoursTB.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // currentDate
            // 
            this.currentDate.Location = new System.Drawing.Point(176, 140);
            this.currentDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.currentDate.MaxSelectionCount = 1;
            this.currentDate.Name = "currentDate";
            this.currentDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select the program ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date completed:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enrolledTblDataGridView
            // 
            this.enrolledTblDataGridView.AutoGenerateColumns = false;
            this.enrolledTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledTblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.enrolledTblDataGridView.DataSource = this.enrolledTblBindingSource;
            this.enrolledTblDataGridView.Location = new System.Drawing.Point(867, 57);
            this.enrolledTblDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enrolledTblDataGridView.Name = "enrolledTblDataGridView";
            this.enrolledTblDataGridView.Size = new System.Drawing.Size(172, 127);
            this.enrolledTblDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "studentId";
            this.dataGridViewTextBoxColumn7.HeaderText = "studentId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "programId";
            this.dataGridViewTextBoxColumn8.HeaderText = "programId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // enrolledTblBindingSource
            // 
            this.enrolledTblBindingSource.DataMember = "enrolledTbl";
            this.enrolledTblBindingSource.DataSource = this.communityServiceDataSet;
            // 
            // programsListTblDataGridView
            // 
            this.programsListTblDataGridView.AutoGenerateColumns = false;
            this.programsListTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsListTblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.programsListTblDataGridView.DataSource = this.programsListTblBindingSource;
            this.programsListTblDataGridView.Location = new System.Drawing.Point(1085, 57);
            this.programsListTblDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.programsListTblDataGridView.Name = "programsListTblDataGridView";
            this.programsListTblDataGridView.Size = new System.Drawing.Size(151, 127);
            this.programsListTblDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "programId";
            this.dataGridViewTextBoxColumn10.HeaderText = "programId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "programName";
            this.dataGridViewTextBoxColumn11.HeaderText = "programName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "programDesc";
            this.dataGridViewTextBoxColumn12.HeaderText = "programDesc";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // programsListTblBindingSource
            // 
            this.programsListTblBindingSource.DataMember = "programsListTbl";
            this.programsListTblBindingSource.DataSource = this.communityServiceDataSet;
            // 
            // hoursTblTableAdapter
            // 
            this.hoursTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enrolledTblTableAdapter = this.enrolledTblTableAdapter;
            this.tableAdapterManager.hoursTblTableAdapter = this.hoursTblTableAdapter;
            this.tableAdapterManager.programsListTblTableAdapter = this.programsListTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = CommunityServiceProgram.CommunityServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enrolledTblTableAdapter
            // 
            this.enrolledTblTableAdapter.ClearBeforeFill = true;
            // 
            // programsListTblTableAdapter
            // 
            this.programsListTblTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Program Name:";
            // 
            // progNameTB
            // 
            this.progNameTB.Location = new System.Drawing.Point(460, 69);
            this.progNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progNameTB.Name = "progNameTB";
            this.progNameTB.ReadOnly = true;
            this.progNameTB.Size = new System.Drawing.Size(220, 22);
            this.progNameTB.TabIndex = 14;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton1.Text = "Back";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // LogHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 421);
            this.Controls.Add(this.progNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.programsListTblDataGridView);
            this.Controls.Add(this.enrolledTblDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hoursTB);
            this.Controls.Add(this.hoursTblDataGridView);
            this.Controls.Add(this.hoursTblBindingNavigator);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogHours";
            this.Text = "LogHours";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogHours_FormClosing);
            this.Load += new System.EventHandler(this.LogHours_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTblBindingNavigator)).EndInit();
            this.hoursTblBindingNavigator.ResumeLayout(false);
            this.hoursTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledTblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private CommunityServiceDataSet communityServiceDataSet;
        private System.Windows.Forms.BindingSource hoursTblBindingSource;
        private CommunityServiceDataSetTableAdapters.hoursTblTableAdapter hoursTblTableAdapter;
        private CommunityServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hoursTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hoursTblBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hoursTblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox hoursTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar currentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private CommunityServiceDataSetTableAdapters.enrolledTblTableAdapter enrolledTblTableAdapter;
        private System.Windows.Forms.BindingSource enrolledTblBindingSource;
        private CommunityServiceDataSetTableAdapters.programsListTblTableAdapter programsListTblTableAdapter;
        private System.Windows.Forms.DataGridView enrolledTblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource programsListTblBindingSource;
        private System.Windows.Forms.DataGridView programsListTblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox progNameTB;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
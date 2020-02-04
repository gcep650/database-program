namespace CommunityServiceProgram
{
    partial class EditPrograms
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
            System.Windows.Forms.Label programIdLabel;
            System.Windows.Forms.Label programNameLabel;
            System.Windows.Forms.Label programDescLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPrograms));
            this.communityServiceDataSet = new CommunityServiceProgram.CommunityServiceDataSet();
            this.programsListTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsListTblTableAdapter = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.programsListTblTableAdapter();
            this.tableAdapterManager = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.TableAdapterManager();
            this.programsListTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.programsListTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.programIdTextBox = new System.Windows.Forms.TextBox();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.programDescTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            programIdLabel = new System.Windows.Forms.Label();
            programNameLabel = new System.Windows.Forms.Label();
            programDescLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.communityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblBindingNavigator)).BeginInit();
            this.programsListTblBindingNavigator.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programIdLabel
            // 
            programIdLabel.AutoSize = true;
            programIdLabel.Location = new System.Drawing.Point(9, 116);
            programIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            programIdLabel.Name = "programIdLabel";
            programIdLabel.Size = new System.Drawing.Size(93, 21);
            programIdLabel.TabIndex = 1;
            programIdLabel.Text = "Program ID:";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.Location = new System.Drawing.Point(9, 164);
            programNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(120, 21);
            programNameLabel.TabIndex = 3;
            programNameLabel.Text = "Program Name:";
            // 
            // programDescLabel
            // 
            programDescLabel.AutoSize = true;
            programDescLabel.Location = new System.Drawing.Point(9, 213);
            programDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            programDescLabel.Name = "programDescLabel";
            programDescLabel.Size = new System.Drawing.Size(157, 21);
            programDescLabel.TabIndex = 5;
            programDescLabel.Text = "Program Description:";
            // 
            // communityServiceDataSet
            // 
            this.communityServiceDataSet.DataSetName = "CommunityServiceDataSet";
            this.communityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programsListTblBindingSource
            // 
            this.programsListTblBindingSource.DataMember = "programsListTbl";
            this.programsListTblBindingSource.DataSource = this.communityServiceDataSet;
            // 
            // programsListTblTableAdapter
            // 
            this.programsListTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enrolledTblTableAdapter = null;
            this.tableAdapterManager.hoursTblTableAdapter = null;
            this.tableAdapterManager.programsListTblTableAdapter = this.programsListTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = CommunityServiceProgram.CommunityServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // programsListTblBindingNavigator
            // 
            this.programsListTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.programsListTblBindingNavigator.BindingSource = this.programsListTblBindingSource;
            this.programsListTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.programsListTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.programsListTblBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.programsListTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.programsListTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.programsListTblBindingNavigatorSaveItem});
            this.programsListTblBindingNavigator.Location = new System.Drawing.Point(0, 412);
            this.programsListTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.programsListTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.programsListTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.programsListTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.programsListTblBindingNavigator.Name = "programsListTblBindingNavigator";
            this.programsListTblBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.programsListTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.programsListTblBindingNavigator.Size = new System.Drawing.Size(554, 27);
            this.programsListTblBindingNavigator.TabIndex = 0;
            this.programsListTblBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // programsListTblBindingNavigatorSaveItem
            // 
            this.programsListTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.programsListTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("programsListTblBindingNavigatorSaveItem.Image")));
            this.programsListTblBindingNavigatorSaveItem.Name = "programsListTblBindingNavigatorSaveItem";
            this.programsListTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.programsListTblBindingNavigatorSaveItem.Text = "Save Data";
            this.programsListTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProgramsListTblBindingNavigatorSaveItem_Click_1);
            // 
            // programIdTextBox
            // 
            this.programIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsListTblBindingSource, "programId", true));
            this.programIdTextBox.Location = new System.Drawing.Point(225, 110);
            this.programIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programIdTextBox.Name = "programIdTextBox";
            this.programIdTextBox.Size = new System.Drawing.Size(67, 29);
            this.programIdTextBox.TabIndex = 2;
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsListTblBindingSource, "programName", true));
            this.programNameTextBox.Location = new System.Drawing.Point(225, 159);
            this.programNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(286, 29);
            this.programNameTextBox.TabIndex = 4;
            // 
            // programDescTextBox
            // 
            this.programDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsListTblBindingSource, "programDesc", true));
            this.programDescTextBox.Location = new System.Drawing.Point(225, 209);
            this.programDescTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programDescTextBox.Multiline = true;
            this.programDescTextBox.Name = "programDescTextBox";
            this.programDescTextBox.Size = new System.Drawing.Size(286, 140);
            this.programDescTextBox.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 24);
            this.toolStripLabel1.Text = "Edit Programs";
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
            // EditPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 439);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(programDescLabel);
            this.Controls.Add(this.programDescTextBox);
            this.Controls.Add(programNameLabel);
            this.Controls.Add(this.programNameTextBox);
            this.Controls.Add(programIdLabel);
            this.Controls.Add(this.programIdTextBox);
            this.Controls.Add(this.programsListTblBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditPrograms";
            this.Text = "EditPrograms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPrograms_FormClosing);
            this.Load += new System.EventHandler(this.EditPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.communityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsListTblBindingNavigator)).EndInit();
            this.programsListTblBindingNavigator.ResumeLayout(false);
            this.programsListTblBindingNavigator.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommunityServiceDataSet communityServiceDataSet;
        private System.Windows.Forms.BindingSource programsListTblBindingSource;
        private CommunityServiceDataSetTableAdapters.programsListTblTableAdapter programsListTblTableAdapter;
        private CommunityServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator programsListTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton programsListTblBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox programIdTextBox;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.TextBox programDescTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
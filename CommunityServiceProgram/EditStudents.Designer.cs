namespace CommunityServiceProgram
{
    partial class EditStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudents));
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label accountTypeLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.communityServiceDataSet = new CommunityServiceProgram.CommunityServiceDataSet();
            this.accountsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTblTableAdapter = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.accountsTblTableAdapter();
            this.tableAdapterManager = new CommunityServiceProgram.CommunityServiceDataSetTableAdapters.TableAdapterManager();
            this.accountsTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.accountsTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            studentIdLabel = new System.Windows.Forms.Label();
            accountTypeLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.communityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTblBindingNavigator)).BeginInit();
            this.accountsTblBindingNavigator.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // communityServiceDataSet
            // 
            this.communityServiceDataSet.DataSetName = "CommunityServiceDataSet";
            this.communityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTblBindingSource
            // 
            this.accountsTblBindingSource.DataMember = "accountsTbl";
            this.accountsTblBindingSource.DataSource = this.communityServiceDataSet;
            // 
            // accountsTblTableAdapter
            // 
            this.accountsTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTblTableAdapter = this.accountsTblTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.enrolledTblTableAdapter = null;
            this.tableAdapterManager.hoursTblTableAdapter = null;
            this.tableAdapterManager.programsListTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CommunityServiceProgram.CommunityServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountsTblBindingNavigator
            // 
            this.accountsTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountsTblBindingNavigator.BindingSource = this.accountsTblBindingSource;
            this.accountsTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountsTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountsTblBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accountsTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accountsTblBindingNavigatorSaveItem});
            this.accountsTblBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.accountsTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountsTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountsTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountsTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountsTblBindingNavigator.Name = "accountsTblBindingNavigator";
            this.accountsTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountsTblBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.accountsTblBindingNavigator.TabIndex = 0;
            this.accountsTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // accountsTblBindingNavigatorSaveItem
            // 
            this.accountsTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountsTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountsTblBindingNavigatorSaveItem.Image")));
            this.accountsTblBindingNavigatorSaveItem.Name = "accountsTblBindingNavigatorSaveItem";
            this.accountsTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.accountsTblBindingNavigatorSaveItem.Text = "Save Data";
            this.accountsTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.AccountsTblBindingNavigatorSaveItem_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(9, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(57, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "first Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(91, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(9, 69);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(57, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(91, 66);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(9, 95);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(37, 13);
            gradeLabel.TabIndex = 7;
            gradeLabel.Text = "grade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(91, 92);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 8;
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Location = new System.Drawing.Point(9, 121);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(57, 13);
            studentIdLabel.TabIndex = 9;
            studentIdLabel.Text = "student Id:";
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "studentId", true));
            this.studentIdTextBox.Location = new System.Drawing.Point(91, 118);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIdTextBox.TabIndex = 10;
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Location = new System.Drawing.Point(9, 147);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new System.Drawing.Size(76, 13);
            accountTypeLabel.TabIndex = 11;
            accountTypeLabel.Text = "account Type:";
            // 
            // accountTypeTextBox
            // 
            this.accountTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "accountType", true));
            this.accountTypeTextBox.Location = new System.Drawing.Point(91, 144);
            this.accountTypeTextBox.Name = "accountTypeTextBox";
            this.accountTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountTypeTextBox.TabIndex = 12;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(9, 173);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(56, 13);
            usernameLabel.TabIndex = 13;
            usernameLabel.Text = "username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(91, 170);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(9, 199);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTblBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(91, 196);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 16;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 17;
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
            // EditStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(studentIdLabel);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(accountTypeLabel);
            this.Controls.Add(this.accountTypeTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.accountsTblBindingNavigator);
            this.Name = "EditStudents";
            this.Text = "EditStudents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStudents_FormClosing);
            this.Load += new System.EventHandler(this.EditStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.communityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTblBindingNavigator)).EndInit();
            this.accountsTblBindingNavigator.ResumeLayout(false);
            this.accountsTblBindingNavigator.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommunityServiceDataSet communityServiceDataSet;
        private System.Windows.Forms.BindingSource accountsTblBindingSource;
        private CommunityServiceDataSetTableAdapters.accountsTblTableAdapter accountsTblTableAdapter;
        private CommunityServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountsTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton accountsTblBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox accountTypeTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
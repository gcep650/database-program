using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityServiceProgram
{
    public partial class Enroll : Form
    {
        private long m_id;
        public Enroll(long id)
        {
            InitializeComponent();
            m_id = id;
        }

        private void ProgramsListTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programsListTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void Enroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communityServiceDataSet.enrolledTbl' table. You can move, or remove it, as needed.
            this.enrolledTblTableAdapter.Fill(this.communityServiceDataSet.enrolledTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.programsListTbl' table. You can move, or remove it, as needed.
            this.programsListTblTableAdapter.Fill(this.communityServiceDataSet.programsListTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.programsListTbl' table. You can move, or remove it, as needed.
            this.programsListTblTableAdapter.Fill(this.communityServiceDataSet.programsListTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.enrolledTbl' table. You can move, or remove it, as needed.
            this.enrolledTblTableAdapter.Fill(this.communityServiceDataSet.enrolledTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.programsListTbl' table. You can move, or remove it, as needed.
            this.programsListTblTableAdapter.Fill(this.communityServiceDataSet.programsListTbl);

            var enrolled = from en in communityServiceDataSet.enrolledTbl
                           where en.studentId == m_id
                           select en;
            enrolledTblBindingSource.DataSource = enrolled.AsDataView();
            enrolledTblDataGridView.DataSource = enrolled.AsDataView();
            if (enrolled.Count() < 1)
            {
                MessageBox.Show("You are not enrolled in any programs. Form will now close.");
                this.Close();
            }
            updateTbl();
        }

        private void programsListTblBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.programsListTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void programsListTblBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.programsListTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void updateTbl()
        {
            int num;
            int.TryParse(progIdTB.Text, out num);
            var program = from p in communityServiceDataSet.programsListTbl
                          where p.programId == num
                          select p;
            programsListTblBindingSource.DataSource = program.AsDataView();
            programsListTblDataGridView.DataSource = program.AsDataView();
        }

        private void progIdTB_TextChanged(object sender, EventArgs e)
        {
            updateTbl();
        }
    }
}

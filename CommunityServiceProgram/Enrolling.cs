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
    public partial class Enrolling : Form
    {
        private long m_id;
        private Center m_main;
        public Enrolling(long id, Center main)
        {
            InitializeComponent();
            m_id = id;
            m_main = main;
        }

        private void EnrolledTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enrolledTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void Enrolling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communityServiceDataSet.programsListTbl' table. You can move, or remove it, as needed.
            this.programsListTblTableAdapter.Fill(this.communityServiceDataSet.programsListTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.enrolledTbl' table. You can move, or remove it, as needed.
            this.enrolledTblTableAdapter.Fill(this.communityServiceDataSet.enrolledTbl);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(idTB.Text, out num);

            var prog = from p in communityServiceDataSet.programsListTbl
                       where p.programId == num
                       select p;
            programsListTblDataGridView.DataSource = prog.AsDataView();
            if (prog.Count() > 0)
            {
                nameTB.Text = prog.First().programName;
                descTB.Text = prog.First().programDesc;
            }
            else
            {
                MessageBox.Show("Invalid ID. Make sure you typed in the ID correctly.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(idTB.Text, out num);
            var check = from enr in communityServiceDataSet.enrolledTbl
                        where enr.programId == num &&
                        enr.studentId == m_id
                        select enr;
            if (check.Count() > 0)
            {
                MessageBox.Show("You are already enrolled in this program.");
            }
            else
            {
                CommunityServiceDataSet.enrolledTblRow row;
                row = communityServiceDataSet.enrolledTbl.NewenrolledTblRow();
                row.studentId = (int)m_id;
                row.programId = num;
                communityServiceDataSet.enrolledTbl.AddenrolledTblRow(row);
                this.Validate();
                this.enrolledTblBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);
                MessageBox.Show("Enrolled in new program successfully.");
                this.Close();
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enrolling_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_main.Show();
        }
    }
}

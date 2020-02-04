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
    public partial class LogHours : Form
    {
        private int m_id;
        private Center m_main;
        public LogHours(int id, Center main)
        {
            InitializeComponent();
            m_id = id;
            m_main = main;
        }

        private void hoursTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoursTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void LogHours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communityServiceDataSet.programsListTbl' table. You can move, or remove it, as needed.
            this.programsListTblTableAdapter.Fill(this.communityServiceDataSet.programsListTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.enrolledTbl' table. You can move, or remove it, as needed.
            this.enrolledTblTableAdapter.Fill(this.communityServiceDataSet.enrolledTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.hoursTbl' table. You can move, or remove it, as needed.
            this.hoursTblTableAdapter.Fill(this.communityServiceDataSet.hoursTbl);

            var enrolled = from enr in communityServiceDataSet.enrolledTbl
                           where enr.studentId == m_id
                           select enr;
            if (enrolled.Count() < 1)
            {
                MessageBox.Show("You are not enrolled in any programs. Enroll in a program in order to log hours.");
                this.Close();
            }
            for (int i = 0; i < enrolled.Count(); i++)
            {
                comboBox1.Items.Add(enrolled.ElementAt(i).programId);
               
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prog = from p in communityServiceDataSet.programsListTbl
                       where p.programId == (int)comboBox1.Items[comboBox1.SelectedIndex]
                       select p;
            if (prog.Count() > 0)
            {
                progNameTB.Text = prog.First().programName;
            }
            else 
            {
                progNameTB.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommunityServiceDataSet.hoursTblRow row;
            row = communityServiceDataSet.hoursTbl.NewhoursTblRow();
            row.studentId = m_id;
            row.programId = (int)comboBox1.Items[comboBox1.SelectedIndex];
            row.hours = int.Parse(hoursTB.Text);
            row.sessionDate = currentDate.SelectionRange.Start;
            communityServiceDataSet.hoursTbl.AddhoursTblRow(row);

            this.Validate();
            this.hoursTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);
            MessageBox.Show("Hours logged successfully.");
            this.Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogHours_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_main.Show();
        }
    }
}

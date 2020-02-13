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
    public partial class Reports : Form
    {
        private Center m_main;
        private string[] fields = { "First Name", "Last Name", "Program", "Hours", "Date" };
        private DataTable m_reports = new DataTable();
        public Reports(Center main, string accountType)
        {
            InitializeComponent();
            m_main = main;
            
            foreach (string s in fields)
            {
                m_reports.Columns.Add(s);
            }
        }

        private void AddRow(string[] args)
        {
            DataRow r = m_reports.NewRow();
            for (int i = 0; i < args.Length; i++)
            {
                r[fields[i]] = args[i];
            }
            m_reports.Rows.Add(r);
            reportsTable.DataSource = m_reports;
        }

        private void GenReportEntry(int studentID, int programID, DateTime date, int hours)
        {
            string[] input = new string[5];
            CommunityServiceDataSet.accountsTblRow student = getStudent(studentID);
            CommunityServiceDataSet.programsListTblRow program = getProgram(programID);
            input[0] = student.firstName;
            input[1] = student.lastName;
            input[2] = program.programName;
            input[3] = hours.ToString();
            input[4] = date.ToShortDateString();
            AddRow(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] t = { "bob", "smith", "bgb", "5", "program", "5", "yesterday" };
            //Generate(t);
        }

        private void accountsTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communityServiceDataSet.programsListTbl' table. You can move, or remove it, as needed.
            this.programsListTblTableAdapter.Fill(this.communityServiceDataSet.programsListTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.hoursTbl' table. You can move, or remove it, as needed.
            this.hoursTblTableAdapter.Fill(this.communityServiceDataSet.hoursTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.enrolledTbl' table. You can move, or remove it, as needed.
            this.enrolledTblTableAdapter.Fill(this.communityServiceDataSet.enrolledTbl);
            // TODO: This line of code loads data into the 'communityServiceDataSet.accountsTbl' table. You can move, or remove it, as needed.
            this.accountsTblTableAdapter.Fill(this.communityServiceDataSet.accountsTbl);

            var students = from student in communityServiceDataSet.accountsTbl
                           where student.accountType.Equals("Student")
                           select student;
            for (int i = 0; i < students.Count(); i++)
            {
                studentCombo.Items.Add(students.ElementAt(i).studentId);
            }

            var programs = from prog in communityServiceDataSet.programsListTbl
                           select prog;
            for (int i = 0; i < programs.Count(); i++)
            {
                programCombo.Items.Add(programs.ElementAt(i).programId);
            }

            Button2_Click(sender, e);

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            studentCombo.Enabled = studentCB.Checked;
        }

        private void ProgramCB_CheckedChanged(object sender, EventArgs e)
        {
            programCombo.Enabled = programCB.Checked;
        }

        private void StudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommunityServiceDataSet.accountsTblRow student = getStudent((int)studentCombo.Items[studentCombo.SelectedIndex]);
            stuSelected.Text = "Selected: " + student.firstName + " " + student.lastName;
            generateFiltered();
        }

        private void ProgramCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommunityServiceDataSet.programsListTblRow program = getProgram((int)programCombo.Items[programCombo.SelectedIndex]);
            proSelected.Text = "Selected: " + program.programName;
            generateFiltered();
        }

        private void generateReports(EnumerableRowCollection<CommunityServiceDataSet.hoursTblRow> data)
        {
            reportBox.ResetText();
            m_reports.Clear();
            for (int i = 0; i < data.Count(); i++)
            {
                CommunityServiceDataSet.hoursTblRow row = data.ElementAt(i);
                reportBox.AppendText(reportLine(row.studentId, row.programId, row.sessionDate, row.hours));
                reportBox.AppendText(Environment.NewLine);
                GenReportEntry(row.studentId, row.programId, row.sessionDate, row.hours);
            }
        }

        private void generateFiltered()
        {
            var hours = from h in communityServiceDataSet.hoursTbl
                        where checkStudent(h.studentId) && checkProg(h.programId)
                        select h;
            generateReports(hours);
        }

        private string reportLine(int studentID, int progID, DateTime date, int hours)
        {
            string retval = "";
            CommunityServiceDataSet.accountsTblRow student = getStudent(studentID);
            CommunityServiceDataSet.programsListTblRow prog = getProgram(progID);

            retval += ("Student: " + student.firstName + " " + student.lastName).PadRight(30, '.');
            retval += ("Program: " + prog.programName).PadRight(30, '.');
            retval += string.Format("Hours: {0}", hours).PadRight(20, '.');
            retval += "Date: " + date.ToShortDateString();
            return retval;
        }

        private CommunityServiceDataSet.accountsTblRow getStudent(int studentID)
        {
            var student = from st in communityServiceDataSet.accountsTbl
                          where st.studentId == studentID
                          select st;
            return student.First();
        }

        private CommunityServiceDataSet.programsListTblRow getProgram(int programID)
        {
            var prog = from p in communityServiceDataSet.programsListTbl
                       where p.programId == programID
                       select p;
            return prog.First();
        }

        private bool checkStudent(int fromDB)
        {
            if (!studentCB.Checked) { return true; }
            return (int)studentCombo.Items[studentCombo.SelectedIndex] == fromDB;
        }

        private bool checkProg(int fromDB)
        {
            if (!programCB.Checked) { return true; }
            return (int)programCombo.Items[programCombo.SelectedIndex] == fromDB;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var data = from all in communityServiceDataSet.hoursTbl
                       select all;
            generateReports(data);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            reportBox.SelectAll();
            reportBox.Copy();
            reportBox.DeselectAll();
            MessageBox.Show("Reports copied to clipboard.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_main.Show();
        }
    }
}

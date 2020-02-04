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
    public partial class Center : Form
    {
        private Login m_login;
        private string m_acc;
        private string m_usr;
        private EnumerableRowCollection<CommunityServiceDataSet.accountsTblRow> m_fullacc;
        private bool isQuitting = false;

        public Center(Login l, string accountType, string username, EnumerableRowCollection<CommunityServiceDataSet.accountsTblRow> row)
        {
            InitializeComponent();
            m_acc = accountType;
            m_usr = username;
            m_fullacc = row;
            m_login = l;

            switch (accType(accountType))
            {
                case 2:
                    adminBox.Enabled = false;
                    adminBox.Hide();
                    studentBox.Enabled = true;
                    studentBox.Dock = DockStyle.Fill;
                    studentBox.Show();
                    break;
                case 1:
                    studentBox.Hide();
                    studentBox.Enabled = false;
                    adminBox.Enabled = true;
                    adminBox.Dock = DockStyle.Fill;
                    adminBox.Show();
                    break;
                default:
                    MessageBox.Show("Invalid account type.");
                    this.Close();
                    break;
            }
            //MessageBox.Show(accountType);
        }

        private int accType(string acc)
        {
            if (acc.Equals("Admin")) { return 1; }
            if (acc.Equals("Student")) { return 2; }
            return 0;
        }

        private void Center_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isQuitting)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to log off?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (res)
                {
                    case DialogResult.Yes:
                        //this.Close();
                        m_login.Show();

                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to quit this application?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) { isQuitting = true; Application.Exit(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports r = new Reports(this, "Admin");
            this.Hide();
            r.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EditPrograms ep = new EditPrograms(this);
            this.Hide();
            ep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enroll r = new Enroll(m_fullacc.First().studentId, this);
            this.Hide();
            r.Show();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Enrolling enr = new Enrolling(m_fullacc.First().studentId, this);
            this.Hide();
            enr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogHours l = new LogHours(m_fullacc.First().studentId, this);
            this.Hide();
            l.Show();
        }
    }
}

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
        public Reports(Center main, string accountType)
        {
            InitializeComponent();
        }

        private void Generate(string[] args)
        {
            DataTable tb = new DataTable();
            string[] fields = { "FirstName", "LastName", "Username", "ID", "Program", "Hours", "Date" };
            foreach (string s in fields)
            {
                tb.Columns.Add(s);
            }
            DataRow r = tb.NewRow();
            for (int i = 0; i < fields.Length; i++)
            {
                r[fields[i]] = args[i];
            }
            tb.Rows.Add(r);
            dataGridView1.DataSource = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] t = { "bob", "smith", "bgb", "5", "program", "5", "yesterday" };
            Generate(t);
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

        }
    }
}

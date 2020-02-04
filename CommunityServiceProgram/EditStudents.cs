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
    public partial class EditStudents : Form
    {
        private Center m_main;
        public EditStudents(Center main)
        {
            InitializeComponent();
            m_main = main;
        }

        private void AccountsTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void EditStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communityServiceDataSet.accountsTbl' table. You can move, or remove it, as needed.
            this.accountsTblTableAdapter.Fill(this.communityServiceDataSet.accountsTbl);

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_main.Show();
        }
    }
}

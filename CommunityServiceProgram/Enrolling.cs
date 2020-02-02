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
        public Enrolling()
        {
            InitializeComponent();
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
    }
}

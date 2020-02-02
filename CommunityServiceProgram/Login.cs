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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            splitContainer1.TabStop = false;
        }

        private void accountsTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.communityServiceDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'communityServiceDataSet.accountsTbl' table. You can move, or remove it, as needed.
            this.accountsTblTableAdapter.Fill(this.communityServiceDataSet.accountsTbl);

        }

        private void ResizeForm(object sender, EventArgs e)
        {
            /*
            centerCtl(usernameTB);
            centerCtl(passwordTB);
            centerCtl(label2);
            centerCtl(label3);
            centerCtl(button1);
            */
        }

        private void centerCtl(Control ctl)
        {
            ctl.Left = (ctl.Parent.Width - ctl.Width) / 2;
            ctl.Top = (ctl.Parent.Height - ctl.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            var accounts = from acc in communityServiceDataSet.accountsTbl
                           where acc.username.Equals(username) && acc.password.Equals(password)
                           select acc;
            if (accounts.Count() > 0)
            {
                //MessageBox.Show(String.Format("Logged in as: {0} {1}", accounts.First().firstName, accounts.First().lastName));
                this.usernameTB.Focus();
                this.Hide();
                this.usernameTB.ResetText();
                this.passwordTB.ResetText();
                Center c = new Center(this, accounts.First().accountType, accounts.First().username, accounts);
                c.Show();
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
                           
        }
    }
}

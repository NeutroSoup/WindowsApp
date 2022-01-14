using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Management;
using System.Security.AccessControl;
namespace WindowsApp
{
    public partial class Form1 : Form
    {
        bool onNextLogon = false;
        bool canchangePass = false;
        bool passNeverExpires = false;
        bool accDisabled = false;
        bool selectedUser = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            try
            {
                lstUsers.Items.Clear();
                //Creating a query to retrieve users
                SelectQuery query = new SelectQuery("Win32_UserAccount", "Domain='" + Environment.MachineName + "'");
                ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(query);
                foreach (var item in objectSearcher.Get())
                {
                    lstUsers.Items.Add(item["name"]);

                }
                btnDeleteUsers.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            onNextLogon = CbChangePass.Checked;
        }
        private void CbUserCannotCh_CheckedChanged(object sender, EventArgs e)
        {
            canchangePass = CbUserCannotCh.Checked;
        }

        private void CbPassNeverEx_CheckedChanged(object sender, EventArgs e)
        {
            accDisabled = CbPassNeverEx.Checked;
        }

        private void CbAccIsDis_CheckedChanged(object sender, EventArgs e)
        {
            passNeverExpires = CbAccIsDis.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Machine, Environment.MachineName);
                UserPrincipal user = new UserPrincipal(context);

                user.Name = txtUsername.Text;
                user.SetPassword(txtPassword.Text);
                if (onNextLogon)
                {
                    user.ExpirePasswordNow();
                }
                user.PasswordNeverExpires = passNeverExpires;
                user.Enabled = !accDisabled; //enabled by default
                user.UserCannotChangePassword = canchangePass;
                user.Save();
                GroupPrincipal group = GroupPrincipal.FindByIdentity(context, "Users");
                group.Members.Add(user);//adding the user to the groop
                MessageBox.Show("User created");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryEntry host = new DirectoryEntry("WinNT://" + Environment.MachineName);
                DirectoryEntries entries = host.Children;
                DirectoryEntry user = entries.Find(lstUsers.SelectedItem.ToString());

                entries.Remove(user);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != 1)
            {
                selectedUser = true;
            }
        }
    }
}

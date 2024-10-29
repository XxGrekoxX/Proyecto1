using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class UserControlRegister : UserControl
    {
        private string ID = "";
        private string user = "";
        private string password = "";
        private string name = "";
        private string lastName = "";
        private string Mail = "";
        private string Telef = "";
        
        public UserControlRegister()
        {
            InitializeComponent();
            btnAdd.BackColor = Color.FromArgb(61, 111, 124);
            lblAddUser.ForeColor = Color.FromArgb(61, 111, 124);
            lblSearchUser.ForeColor = Color.FromArgb(61, 111, 124);
            lblUpdateUser.ForeColor = Color.FromArgb(61, 111, 124);
            btnUpdate.BackColor = Color.FromArgb(61, 111, 124);
            btnDelete.BackColor = Color.FromArgb(234, 73, 73);
        }
        public void ConfigurarTabs(bool tab1Visible, bool tab2Visible, bool tab3Visible)
        {
            tabControlRegister.TabPages[0].Visible = tab1Visible;
            tabControlRegister.TabPages[1].Visible = tab2Visible;
            tabControlRegister.TabPages[2].Visible = tab3Visible;

            tab1Visible = false;

            
        }
        public void Clear()
        {
            txtId.Clear();
            txtUser.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtMail.Clear();
            txtTelef.Clear();
            tabControlRegister.SelectedTab = tabPageAddUser;
        }
        private void Clear1()
        {
            txtUser1.Clear();
            txtPassword1.Clear();
            txtName1.Clear();
            txtLastName1.Clear();
            txtMail1.Clear();
            txtTelef1.Clear();
            ID = "";
            user = "";
            password = "";
            name = "";
            lastName = "";
            Mail = "";
            Telef = "";

    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            //txtUserSearch.Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            txtUserSearch.Clear();
        }

        private void tabPageUpdate_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}

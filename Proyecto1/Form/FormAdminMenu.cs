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
    public partial class FormAdminMenu : Form
    {
        public string Username;
        public FormAdminMenu()
        {
            InitializeComponent();
            panelLeft.BackColor = Color.FromArgb(61, 111, 124);
            panelLeftUp.BackColor = Color.FromArgb(61, 111, 124);
            panelTop2.BackColor = Color.FromArgb(61, 111, 124);
        }
        private void MovePanel(Control btn)
        {
            panelSlideAdmin.Top = btn.Top;
            panelSlideAdmin.Height = btn.Height;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            MovePanel(btnCatalog);
            userControlRegister1.Hide();
        }

        private void btnCatalogUser_Click(object sender, EventArgs e)
        {
            MovePanel(btnCatalogUser);
            userControlRegister1.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            MovePanel(btnBookings);
            userControlRegister1.Hide();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDateAdmin.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt ");
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FormAdminMenu_Load(object sender, EventArgs e)
        {
            timer2.Start();
            lblUserAdmin.Text = Username;
            
        }
    }
}

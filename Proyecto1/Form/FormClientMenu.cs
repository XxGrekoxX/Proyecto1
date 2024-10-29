using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1
{
    public partial class FormPrincipal : Form
    {
        public string Username;
        public FormPrincipal()
        {
            InitializeComponent();
            panelLeft.BackColor = Color.FromArgb(67, 144, 165);
            panelLeftUp.BackColor = Color.FromArgb(67, 144, 165);
            panelUpFondo.BackColor = Color.FromArgb(67, 144, 165);
            linkLblLogOut.ActiveLinkColor = Color.FromArgb(67, 144, 165);
            linkLblLogOut.DisabledLinkColor = Color.FromArgb(67, 144, 165);
            linkLblLogOut.LinkColor = Color.FromArgb(67, 144, 165);

        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxFondo_Click(object sender, EventArgs e)
        {

        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            userControlUpDate1.Hide();
            userControlAbout1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt ");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblNameUser.Text = Username;
            

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            MovePanel(btnAboutUs);
            userControlUpDate1.Hide();
            userControlAbout1.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MovePanel(btnService);
            userControlUpDate1.Hide();
            userControlAbout1.Hide();
        }

        private void btnInfoUser_Click(object sender, EventArgs e)
        {
            MovePanel(btnInfoUser);
            //userControlUpDate1.Clear();
            userControlAbout1.Hide();
            userControlUpDate1.Show();
            
            
        }

        private void linkLblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Quieres cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
            
            
        }

        private void panelDataTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUp2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUpFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeftUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlRegister1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

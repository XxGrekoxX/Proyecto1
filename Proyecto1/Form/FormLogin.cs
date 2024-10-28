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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnLogin.BackColor = Color.FromArgb(67, 144, 165);
            groupBoxLogin.BackColor = Color.White;
            btnRegistrer.BackColor = groupBoxLogin.BackColor;
            btnRegistrer.ForeColor = Color.FromArgb(67, 144, 165);
            lblTexto.ForeColor = Color.FromArgb(67, 144, 165);
            lblWelcome.ForeColor = Color.FromArgb(67, 144, 165);
        }

        private void picBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxClose, "Cerrar ventana");
            //Esto es para que cuando pasen el cursor sobre el icono muestre un mensaje de texto de la funcion que realiza el mismo
        }

        private void picBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxMinimize, "Minimizar ventana");
            //Esto es para que cuando pasen el cursor sobre el icono muestre un mensaje de texto de la funcion que realiza el mismo
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picBoxShowPassword.Hide();
            txtPassword.UseSystemPasswordChar = false;
            picBoxHidePassword.Show();
        }

        private void picBoxShowPassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxShowPassword, "Mostrar contraseña");
        }

        private void picBoxHidePassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxHidePassword, "Esconder contraseña");
        }

        private void picBoxHidePassword_Click(object sender, EventArgs e)
        {
            picBoxHidePassword.Hide();
            txtPassword.UseSystemPasswordChar = true;
            picBoxShowPassword.Show();
        }
    }
}

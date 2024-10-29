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
    public partial class UserControlUpDate : UserControl
    {
        public UserControlUpDate()
        {
            InitializeComponent();
            btnUpdateAdd.BackColor = Color.FromArgb(61, 111, 124);
            lblUpdateUser.ForeColor = Color.FromArgb(61, 111, 124);
        }
    }
}

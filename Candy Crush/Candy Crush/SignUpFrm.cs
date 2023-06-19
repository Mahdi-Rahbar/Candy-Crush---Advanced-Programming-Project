using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candy_Crush
{
    public partial class SignUpFrm : Form
    {
        public SignUpFrm()
        {
            InitializeComponent();
        }

        private void SignUpFrm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
        }
        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        private void signUpBtn_MouseEnter(object sender, EventArgs e)
        {
            signUpBtn.BackColor = Color.FromArgb(233, 233, 84);
        }

        private void signUpBtn_MouseLeave(object sender, EventArgs e)
        {
            signUpBtn.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            Player playerSignUp = new Player(username, password);
        }
    }
}

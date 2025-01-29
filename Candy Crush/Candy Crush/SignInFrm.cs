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
    public partial class SignInFrm : Form
    {
        public SignInFrm()
        {
            InitializeComponent();
        }

        private void SignInFrm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
        }
        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        private void signInBtn_MouseEnter(object sender, EventArgs e)
        {
            signInBtn.BackColor = Color.FromArgb(233, 233, 84);
        }

        private void signInBtn_MouseLeave(object sender, EventArgs e)
        {
            signInBtn.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignInPlayer();


            //var q = db.players.Where(w => w.Username == "trf");
            //foreach (var item in q.ToList())
            //{
            //    db.players.Remove(item);
            //    db.SaveChanges();
            //}

        }
        private void SignInPlayer()
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Please fill in the blank fields !");
                return;
            }
            if (Player.PlayerFinder(usernameTxt.Text, passwordTxt.Text) == false)
            {
                MessageBox.Show("Player not found !");
                return;
            }
            PlayerMenuFrm playerMenu = new PlayerMenuFrm();
            playerMenu.playerName = usernameTxt.Text;
            this.Hide();
            playerMenu.ShowDialog();
            this.Close();
        }
    }
}

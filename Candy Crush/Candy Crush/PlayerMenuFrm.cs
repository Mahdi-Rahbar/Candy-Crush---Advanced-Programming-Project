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
    public partial class PlayerMenuFrm : Form
    {
        public string playerName;
        public PlayerMenuFrm()
        {
            InitializeComponent();
        }

        private void PlayerMenuFrm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
            playerNameLbl.Text = $"Hi {playerName} !";
        }
        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        private void playBtn_MouseEnter(object sender, EventArgs e)
        {
            playBtn.Scale(1.02f);
        }

        private void playBtn_MouseLeave(object sender, EventArgs e)
        {
            playBtn.Scale(1 / 1.02f);
        }

        private void matchBtn_MouseEnter(object sender, EventArgs e)
        {
            matchBtn.Scale(1.02f);
        }

        private void matchBtn_MouseLeave(object sender, EventArgs e)
        {
            matchBtn.Scale(1 / 1.02f);
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.Scale(1.02f);
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Scale(1 / 1.02f);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            GameFrm gameForm = new GameFrm();
            gameForm.ShowDialog();
            this.Close();


        }
    }
}

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
    public partial class WinFrm : Form
    {
        public int score;
        public string playerUsername;
        public WinFrm()
        {
            InitializeComponent();
        }

        private void WinFrm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
            Player.SetPlayerWin(playerUsername, score);
            scoreLbl.Text = $"Score : {score.ToString()}";
        }
        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(233, 233, 84);
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            GameFrm obj = (GameFrm)Application.OpenForms["Gamefrm"];
            obj.Close();
            this.Close();
        }
    }
}

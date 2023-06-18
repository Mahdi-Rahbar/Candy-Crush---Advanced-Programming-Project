using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Candy_Crush
{
    public partial class SignUPOrInFrm : Form
    {
        public SignUPOrInFrm()
        {
            InitializeComponent();
        }

        private void SignUPOrInFrm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
            SetSignUpBtnLocation();
            SetSignInBtnLocation();
            PlayMusicOfBackground();
        }
        private void PlayMusicOfBackground()
        {
            string path = @"E:\Daneshgah\Advanced Programming\4\Candy Crush\final-project-candy-crush-Mahdi-Rahbar\Assets\Candy Crush Background Music.wav";
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = path;
            musicPlayer.PlayLooping();
        }
        private void SetSignUpBtnLocation()
        {
            signUPBtn.Parent = signUpOrInFrame;
            signUPBtn.BackColor = Color.Transparent;
            signUPBtn.Location = new Point(85, 100);
        }
        private void SetSignInBtnLocation()
        {
            signInBtn.Parent = signUpOrInFrame;
            signInBtn.BackColor = Color.Transparent;
            signInBtn.Location = new Point(85, 185);
        }
        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        private void signUPBtn_Click(object sender, EventArgs e)
        {
            SignUpFrm signUpForm = new SignUpFrm();
            signUpForm.ShowDialog();
        }

        private void signUPBtn_MouseEnter(object sender, EventArgs e)
        {
            signUPBtn.Scale(1.02f);

        }

        private void signUPBtn_MouseLeave(object sender, EventArgs e)
        {
            signUPBtn.Scale(1 / 1.02f);
        }

        private void signInBtn_MouseEnter(object sender, EventArgs e)
        {
            signInBtn.Scale(1.02f);
        }

        private void signInBtn_MouseLeave(object sender, EventArgs e)
        {
            signInBtn.Scale(1 / 1.02f);
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignInFrm signInForm = new SignInFrm();
            signInForm.ShowDialog();
        }
    }
}

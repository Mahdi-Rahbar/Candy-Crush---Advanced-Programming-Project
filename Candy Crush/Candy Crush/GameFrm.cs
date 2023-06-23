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
    public partial class GameFrm : Form
    {
        PictureBox beforeCandySelected;
        bool oneTime = false;
        PictureBox selectedCandy;
        public GameFrm()
        {
            InitializeComponent();
        }

        //private void GameFrm_Load(object sender, EventArgs e)
        //{
        //}
        private void CandySelect(object sender, EventArgs e)
        {
            CandySelect((PictureBox)sender);
            beforeCandySelected = (PictureBox)sender;
            selectedCandy = (PictureBox)sender;
        }

        private void changingPicKey(object sender, KeyEventArgs e)
        {
            var candyList = this.Controls.OfType<PictureBox>().Where(w => w.Name.StartsWith("candy")).ToList();
            if (e.KeyCode == Keys.Left)
            {
                SwapBackgroundImage(candyList, "left");
            }
            else if (e.KeyCode == Keys.Up)
            {

            }
            else if (e.KeyCode == Keys.Right)
            {
                SwapBackgroundImage(candyList, "right");
            }
            else if (e.KeyCode == Keys.Down)
            {

            }
        }

        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        private void CandySelect(PictureBox candy)
        {
            if (oneTime == true)
            {
                beforeCandySelected.BackColor = Color.Transparent;
            }
            candy.BackColor = Color.White;
            oneTime = true;
        }

        private void SwapBackgroundImage(List<PictureBox> candyList, string key)
        {

            foreach (PictureBox candy in candyList)
            {
                if (selectedCandy == null)
                {
                    MessageBox.Show("Please select a candy");
                    return;
                }
                if (key == "left" && selectedCandy.Location.Y == candy.Location.Y && selectedCandy.Location.X - candy.Location.X > 50 && selectedCandy.Location.X - candy.Location.X < 100)
                {
                    ChangePicTag(candy);
                    return;
                }
                else if (key == "right" && selectedCandy.Location.Y == candy.Location.Y && selectedCandy.Location.X - candy.Location.X < -50 && selectedCandy.Location.X - candy.Location.X > -100)
                {
                    ChangePicTag(candy);
                    return;
                }
            }

        }

        private void ChangePicTag(PictureBox candy)
        {
            PictureBox temp = new PictureBox();
            temp.BackgroundImage = selectedCandy.BackgroundImage;
            temp.Tag = selectedCandy.Tag;
            selectedCandy.BackgroundImage = candy.BackgroundImage;
            selectedCandy.Tag = candy.Tag;
            candy.BackgroundImage = temp.BackgroundImage;
            candy.Tag = temp.Tag;
        }

        private void HorizontalCheck(List<PictureBox> candyList)
        {
            int y = 177;
            foreach (PictureBox candy in candyList)
            {
                for (int i = 0; i < 6; i++)
                {
                    while (candy.Location.Y == y)
                    {
                        
                    }
                    y += 85;
                }
            }
        }

        private void GameFrm_Load_1(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stop();
            SetFormLocation();
            var candyList = this.Controls.OfType<PictureBox>().Where(w => w.Name.StartsWith("candy")).ToList();
        }
    }
}

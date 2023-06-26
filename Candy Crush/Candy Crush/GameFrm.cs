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
        int seconds = 60;
        int score = 0;
        bool oneTimeWin = true;
        public string playerUsername;
        PictureBox beforeCandySelected;
        bool oneTime = false;
        PictureBox selectedCandy;
        bool undoL = false;
        bool undoU = false;
        bool undoR = false;
        bool undoD = false;
        bool enableKey = true;
        bool enableSelect = true;
        private System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();

        public GameFrm()
        {
            InitializeComponent();
        }

        public void initTimer()
        {
            time.Interval = (500);
            time.Tick += new EventHandler(timeMethod);
            time.Start();
        }

        private void timeMethod(object sender, EventArgs e)
        {
            var candyList = this.Controls.OfType<PictureBox>().Where(w => w.Name.StartsWith("candy")).ToList();
            candyList.Sort((x, y) => x.Name.CompareTo(y.Name));
            VerticalCheck(candyList);
            HorizontalCheck(candyList);
            scoreLbl.Text = $"Score : {score}";
            SetWin();
        }

        //private void GameFrm_Load(object sender, EventArgs e)
        //{
        //}

        private void CandySelect(object sender, EventArgs e)
        {
            if(enableSelect == true)
            {
                CandySelect((PictureBox)sender);
                beforeCandySelected = (PictureBox)sender;
                selectedCandy = (PictureBox)sender;
            }
        }

        private void changingPicKey(object sender, KeyEventArgs e)
        {
            var candyList = this.Controls.OfType<PictureBox>().Where(w => w.Name.StartsWith("candy")).ToList();
            candyList.Sort((x, y) => x.Name.CompareTo(y.Name));
            if (selectedCandy == null)
            {
                MessageBox.Show("Please select a candy");
                return;
            }
            if (e.KeyCode == Keys.Left && enableKey == true && selectedCandy != null)
            {
                SwapBackgroundImage(candyList, "left");
                enableKey = false;
                enableSelect = false;
                undoL = true;
            }
            else if (e.KeyCode == Keys.Up && enableKey == true && selectedCandy != null)
            {
                SwapBackgroundImage(candyList, "up");
                enableKey = false;
                enableSelect = false;
                undoU = true;
            }
            else if (e.KeyCode == Keys.Right && enableKey == true && selectedCandy != null)
            {
                SwapBackgroundImage(candyList, "right");
                enableKey = false;
                enableSelect = false;
                undoR = true;
            }
            else if (e.KeyCode == Keys.Down && enableKey == true && selectedCandy != null)
            {
                SwapBackgroundImage(candyList, "down");
                enableKey = false;
                enableSelect = false;
                undoD = true;
            }
            else if(e.KeyCode == Keys.R)
            {
                if(undoL == true)
                {
                    SwapBackgroundImage(candyList, "left");
                    enableKey = true;
                    enableSelect = true;
                    undoL = false;
                }
                else if (undoU == true)
                {
                    SwapBackgroundImage(candyList, "up");
                    enableKey = true;
                    enableSelect = true;
                    undoU = false;
                }
                else if (undoR == true)
                {
                    SwapBackgroundImage(candyList, "right");
                    enableKey = true;
                    enableSelect = true;
                    undoR = false;
                }
                else if (undoD == true)
                {
                    SwapBackgroundImage(candyList, "down");
                    enableKey = true;
                    enableSelect = true;
                    undoD = false;
                }
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
                else if (key == "up" && selectedCandy.Location.X == candy.Location.X && selectedCandy.Location.Y - candy.Location.Y > 50 && selectedCandy.Location.Y - candy.Location.Y < 100)
                {
                    ChangePicTag(candy);
                    return;
                }
                else if (key == "down" && selectedCandy.Location.X == candy.Location.X && selectedCandy.Location.Y - candy.Location.Y < -50 && selectedCandy.Location.Y - candy.Location.Y > -100)
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
            List<PictureBox> candySameList = new List<PictureBox>();
            PictureBox firstCandy = new PictureBox();
            int nHorizontalCandy = 0;
            int y1 = 100;
            int y2 = 200;
            int i = 0;
            foreach (PictureBox candy in candyList)
            {
                i++;
                if (nHorizontalCandy == 6 && candySameList.Count < 3)
                {
                    y1 = y2;
                    y2 += 70;
                    nHorizontalCandy = 0;
                    candySameList.Clear();
                }
                else if (nHorizontalCandy == 6 && candySameList.Count >= 3)
                {
                    y1 = y2;
                    y2 += 70;
                    SetCandies(candySameList);
                    playSound();
                    SetScore(candySameList);
                    enableKey = true;
                    enableSelect = true;
                    undoL = false;
                    undoU = false;
                    undoR = false;
                    undoD = false;
                    nHorizontalCandy = 0;
                    candySameList.Clear();
                }
                if (candy.Location.Y > y1 && candy.Location.Y < y2)
                {
                    nHorizontalCandy += 1;
                    if (nHorizontalCandy == 1)
                    {
                        firstCandy.Tag = candy.Tag;
                    }
                    if (firstCandy.Tag == candy.Tag)
                    {
                        candySameList.Add(candy);
                    }
                    else if (candy.Tag != firstCandy.Tag && candySameList.Count < 3)
                    {
                        candySameList.Clear();
                        candySameList.Add(candy);
                        firstCandy.Tag = candy.Tag;
                    }
                    else if (candy.Tag != firstCandy.Tag && candySameList.Count >= 3)
                    {
                        SetCandies(candySameList);
                        playSound();
                        SetScore(candySameList);
                        enableKey = true;
                        enableSelect = true;
                        undoL = false;
                        undoU = false;
                        undoR = false;
                        undoD = false;
                        candySameList.Clear();
                        firstCandy.Tag = candy.Tag;
                    }
                    if (i == 36 && candySameList.Count >= 3)
                    {
                        SetCandies(candySameList);
                        playSound();
                        SetScore(candySameList);
                        enableKey = true;
                        enableSelect = true;
                        undoL = false;
                        undoU = false;
                        undoR = false;
                        undoD = false;
                    }
                }
            }
        }




        private void VerticalCheck(List<PictureBox> candyList)
        {
            List<PictureBox> candySameList = new List<PictureBox>();
            PictureBox firstCandy = new PictureBox();
            int nHorizontalCandy = 0;
            int x1 = 100;
            int x2 = 200;
            int i = 0;
            for (int j = 0; j < 6; j++)
            {
                foreach (PictureBox candy in candyList)
                {
                    i++;
                    if (nHorizontalCandy == 6 && candySameList.Count < 3)
                    {
                        x1 = x2;
                        x2 += 70;
                        nHorizontalCandy = 0;
                        candySameList.Clear();
                    }
                    else if (nHorizontalCandy == 6 && candySameList.Count >= 3)
                    {
                        x1 = x2;
                        x2 += 70;
                        SetCandies(candySameList);
                        playSound();
                        SetScore(candySameList);
                        enableKey = true;
                        enableSelect = true;
                        undoL = false;
                        undoU = false;
                        undoR = false;
                        undoD = false;
                        nHorizontalCandy = 0;
                        candySameList.Clear();
                    }
                    if (candy.Location.X > x1 && candy.Location.X < x2)
                    {
                        nHorizontalCandy += 1;
                        if (nHorizontalCandy == 1)
                        {
                            firstCandy.Tag = candy.Tag;
                        }
                        if (firstCandy.Tag == candy.Tag)
                        {
                            candySameList.Add(candy);
                        }
                        else if (candy.Tag != firstCandy.Tag && candySameList.Count < 3)
                        {
                            candySameList.Clear();
                            candySameList.Add(candy);
                            firstCandy.Tag = candy.Tag;
                        }
                        else if (candy.Tag != firstCandy.Tag && candySameList.Count >= 3)
                        {

                            SetCandies(candySameList);
                            playSound();
                            SetScore(candySameList);
                            enableKey = true;
                            enableSelect = true;
                            undoL = false;
                            undoU = false;
                            undoR = false;
                            undoD = false;
                            candySameList.Clear();
                            firstCandy.Tag = candy.Tag;
                        }
                        if (i == 36 && candySameList.Count >= 3)
                        {
                            SetCandies(candySameList);
                            playSound();
                            SetScore(candySameList);
                            enableKey = true;
                            enableSelect = true;
                            undoL = false;
                            undoU = false;
                            undoR = false;
                            undoD = false;
                        }
                    }
                }
            }
            
        }







        private void SetCandies(List<PictureBox> candyList)
        {
            Random randomCandy = new Random();
            string redCandyPath = @"E:\Daneshgah\Advanced Programming\4\Candy Crush\final-project-candy-crush-Mahdi-Rahbar\Assets\Red.png";
            string greenCandyPath = @"E:\Daneshgah\Advanced Programming\4\Candy Crush\final-project-candy-crush-Mahdi-Rahbar\Assets\Green.png";
            string blueCandyPath = @"E:\Daneshgah\Advanced Programming\4\Candy Crush\final-project-candy-crush-Mahdi-Rahbar\Assets\Blue.png";
            string yellowCandyPath = @"E:\Daneshgah\Advanced Programming\4\Candy Crush\final-project-candy-crush-Mahdi-Rahbar\Assets\Yellow.png";
            int num;
            foreach (PictureBox candy in candyList)
            {
                num = randomCandy.Next(1, 5);
                if (num == 1)
                {
                    candy.BackgroundImage = Image.FromFile(redCandyPath);
                    candy.Tag = "red";
                }
                else if (num == 2)
                {
                    candy.BackgroundImage = Image.FromFile(greenCandyPath);
                    candy.Tag = "green";
                }
                else if (num == 3)
                {
                    candy.BackgroundImage = Image.FromFile(blueCandyPath);
                    candy.Tag = "blue";
                }
                else if (num == 4)
                {
                    candy.BackgroundImage = Image.FromFile(yellowCandyPath);
                    candy.Tag = "yellow";
                }
            }
        }

        private void GameFrm_Load_1(object sender, EventArgs e)
        {
            initTimer();
            timerTmr.Start();
            Player.SetPlayerGame(playerUsername);
            SoundPlayer sound = new SoundPlayer();
            sound.Stop();
            SetFormLocation();
            scoreLbl.Text = $"Score : {score}";
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
            
        //}

        private void playSound()
        {
            string path = @"E:\Daneshgah\Advanced Programming\4\Candy Crush\final-project-candy-crush-Mahdi-Rahbar\Assets\GetScore.wav";
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = path;
            musicPlayer.Play();
        }


        private void SetScore(List<PictureBox> sameCandyList)
        {
            if(sameCandyList[0].Tag == "red")
            {
                score += 2;
            }
            else if (sameCandyList[0].Tag == "green")
            {
                score += 4;
            }
            else if (sameCandyList[0].Tag == "blue")
            {
                score += 6;
            }
            else if (sameCandyList[0].Tag == "yellow")
            {
                score += 8;
            }
        }

        private void rearrengeBtn_Click(object sender, EventArgs e)
        {
            var candyList = this.Controls.OfType<PictureBox>().Where(w => w.Name.StartsWith("candy")).ToList();
            SetCandies(candyList);
        }

        private void rearrengeBtn_MouseEnter(object sender, EventArgs e)
        {
            rearrengeBtn.Scale(1.02f);
        }

        private void rearrengeBtn_MouseLeave(object sender, EventArgs e)
        {
            rearrengeBtn.Scale(1 / 1.02f);
        }

        private void timerTmr_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            timerLbl.Text = $"Time : {seconds.ToString()}";
            if(seconds == 0 || oneTimeWin == false)
            {
                timerTmr.Stop();
                if(oneTimeWin == true)
                {
                    SetLose();
                }
            }
        }

        private void SetWin()
        {
            if(score >= 100 && oneTimeWin == true)
            {
                oneTimeWin = false;
                WinFrm winForm = new WinFrm();
                winForm.playerUsername = playerUsername;
                winForm.score = score;
                winForm.ShowDialog();
            }
        }
        private void SetLose()
        {
            LoseFrm loseForm = new LoseFrm();
            loseForm.playerUsername = playerUsername;
            loseForm.score = score;
            loseForm.ShowDialog();
        }
    }
}

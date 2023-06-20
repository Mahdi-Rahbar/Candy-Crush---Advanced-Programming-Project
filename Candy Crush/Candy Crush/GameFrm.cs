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
    public partial class GameFrm : Form
    {
        public GameFrm()
        {
            InitializeComponent();
        }

        private void GameFrm_Load(object sender, EventArgs e)
        {
            SetFormLocation();
        }
        private void SetFormLocation() => this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void loadGame(object sender, EventArgs e)
        {
            FlappyBirdGame gameWindow = new FlappyBirdGame();
            gameWindow.Show();
        }
    }
}

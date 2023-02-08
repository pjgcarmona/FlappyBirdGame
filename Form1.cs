using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class FlappyBirdGame : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        public FlappyBirdGame()
        {
            InitializeComponent();
            gameOver.Visible = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score : " + score;

            if(pipeBottom.Right < 0)
            {
                pipeBottom.Left = 650;
                score++;
            }
            if (pipeTop.Right < 0)
            {
                pipeTop.Left = 800;
                score++;
            }
             
            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < 2)
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 10;
            }
            if (score > 10)
            {
                pipeSpeed = 12;
            }
            if (score > 15)
            {
                pipeSpeed = 15;
            }
            if (score > 20)
            {
                pipeSpeed = 17;
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                InitializeComponent();
            }

            if(e.KeyCode == Keys.Space)
            {
                gravity= -10;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOver.Visible = true;     
        }
    }
}

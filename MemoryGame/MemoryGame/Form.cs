using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        int score = 0;
        int timerSeconds = 0;
        int blackSquares = 0;

        private void RandomiseButtonClick(object sender, EventArgs e)
        {
            blackSquares = 0;
            Random rand = new Random();
            Color[] buttonColors = { Color.White, Color.Black };
            foreach (var button in Controls.OfType<Button>())
            {
                if (button != Start)
                {
                    button.Enabled = false;
                    button.BackgroundImage = base.BackgroundImage;
                    button.Visible = true;
                    button.BackColor = buttonColors[rand.Next(0, buttonColors.Length)];
                    
                    if(button.BackColor == Color.Black)
                    {
                        blackSquares ++;
                    }
                }
            }

            score = 0;
            scoreLabel.Text = score.ToString();
            gameResultLabel.Text = String.Empty;
        }

        private async void StartButtonClick(object sender, EventArgs e)
        {
            timerSeconds = 30;
            RandomiseButtonClick(sender, e);
            await Task.Delay(2000);
            foreach (var button in Controls.OfType<Button>())
            {
                if (button != Start)
                {
                    button.Enabled = true;
                    button.BackgroundImage = MemoryGame.Properties.Resources._41367451;
                }
            }
            coundownTimer.Start();
        }

        private void GameButtonCheckerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
           
            if (gameResultLabel.Text == String.Empty && button.BackColor == Color.Black)
            {
                button.Visible = false;
                score ++;
                scoreLabel.Text = score.ToString();

                if (blackSquares.ToString() == scoreLabel.Text)
                {
                    gameResultLabel.Text = "You won!";
                    coundownTimer.Stop();
                }
            }
            else
            {
                if (gameResultLabel.Text == String.Empty)
                {
                    gameResultLabel.Text = "You lose!";
                    coundownTimer.Stop();
                }
            }
        }

        private void CoundownTimerTick(object sender, EventArgs e)
        {
            if (timerSeconds > -1)
            {
                coundownTimerDisplay.Text = timerSeconds--.ToString();
            }
            else
            {
                if (gameResultLabel.Text == String.Empty)
                {
                    gameResultLabel.Text = "You lose!";
                    coundownTimer.Stop();
                }
            }
        }
    }
}

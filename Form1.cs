namespace flappyComputer
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 9;
        int gravity = 12;
        int score = 0;
        bool gameover = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            virus.Left -= pipeSpeed;
            scoreText.Text = score.ToString();  
            Random r = new Random();
            int rInt = r.Next(100, 800);
            Random rnd= new Random();
            int rndInt = rnd.Next(720, 850);
            Random a = new Random();
            int aInt = a.Next(720, 850);

            if (pipeUp.Left <= -180)
            {
                pipeUp.Left = rndInt;
                
            }

            if (virus.Left <= -180)
            {
                virus.Left = rndInt;
            }
            if (flappyBird.Bounds.IntersectsWith(virus.Bounds))
            {
                score++;
            }
        

            if (pipeDown.Left <= -180)
            {
                pipeDown.Left = aInt;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground3.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground4.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground5.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground6.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground7.Bounds)|| flappyBird.Top < -30)
            {
                endgame();
            }

            if(score == 75)
            {
                gameTimer.Stop();
                scoreText.Text = "Zaviroval sis komp";
            }

            if(score > 30)
            {
                pipeSpeed = 13;
            }

        }

            
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -12;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 12;
            }
        }

        private void endgame() 
        {
            gameTimer.Stop();
            scoreText.Text = "smùla";
        }
    }
}
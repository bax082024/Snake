using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WMPLib;


namespace Snake
{




    public partial class Form1 : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food = Point.Empty;
        private int score = 0;
        private int level = 1;

        private Direction direction = Direction.Right;

        private enum Direction { Up, Down, Left, Right }

        private WindowsMediaPlayer gameMusicPlayer;
        private WindowsMediaPlayer appleSoundPlayer;
        private WindowsMediaPlayer gameOverSoundPlayer;
        private WindowsMediaPlayer startButtonSoundPlayer;




        public Form1()
        {
            InitializeComponent();

            gameMusicPlayer = new WindowsMediaPlayer();
            appleSoundPlayer = new WindowsMediaPlayer();
            gameOverSoundPlayer = new WindowsMediaPlayer();
            startButtonSoundPlayer = new WindowsMediaPlayer();

            gameMusicPlayer.URL = @"Sounds\gamemusic.mp3";
            appleSoundPlayer.URL = @"Sounds\apple.mp3";
            gameOverSoundPlayer.URL = @"Sounds\gameover.mp3";
            startButtonSoundPlayer.URL = @"Sounds\startbutton.mp3";

            gameMusicPlayer.settings.setMode("loop", true);

            // Initialize Timer
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 150; // Slower starting speed
            gameTimer.Tick += gameTimer_Tick;

            // Attach KeyDown
            this.KeyDown += Form1_KeyDown;

            // Enable KeyPreview
            this.KeyPreview = true;

            InitializeGame();
        }

        private void InitializeGame()
        {
            snake.Clear();
            snake.Add(new Point(5, 5));
            snake.Add(new Point(4, 5));
            snake.Add(new Point(3, 5));

            GenerateFood();
            score = 0;
            level = 1;

            gameTimer.Interval = 150;

            direction = Direction.Right; // Initialize direction

            lblScore.Text = $"Score: {score}";
            lblLevel.Text = $"Level: {level}";
            playBox.Invalidate(); // Refresh the playBox
        }

        private void GenerateFood()
        {
            Random random = new Random();
            int gridWidth = playBox.Width / 20; // Number of columns
            int gridHeight = playBox.Height / 20; // Number of rows

            food = new Point(random.Next(0, gridWidth), random.Next(0, gridHeight));
        }

        private void playBox_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellSize = 20;

            // Draw the snake
            foreach (Point segment in snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * cellSize, segment.Y * cellSize, cellSize, cellSize);
            }

            // Draw the food
            g.FillRectangle(Brushes.Red, food.X * cellSize, food.Y * cellSize, cellSize, cellSize);

            lblScore.Text = $"Score: {score}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Point head = snake[0];
            Point newHead = head;

            // Move the snake based on the current direction
            switch (direction)
            {
                case Direction.Up: newHead.Y--; break;
                case Direction.Down: newHead.Y++; break;
                case Direction.Left: newHead.X--; break;
                case Direction.Right: newHead.X++; break;
            }

            // Collision detection
            if (newHead.X < 0 || newHead.Y < 0 ||
                newHead.X >= playBox.Width / 20 || newHead.Y >= playBox.Height / 20 ||
                snake.Contains(newHead))
            {
                GameOver();
                return;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score++;
                lblScore.Text = $"Score: {score}";
                appleSoundPlayer.controls.play();
                GenerateFood();

                // Increase level every 10 apples
                if (score % 10 == 0)
                {
                    level++;
                    lblLevel.Text = $"Level: {level}";

                    // Increase speed by reducing interval (minimum of 50 ms)
                    if (gameTimer.Interval > 50)
                    {
                        gameTimer.Interval -= 10;
                        Console.WriteLine($"Level Up! New Speed: {gameTimer.Interval} ms");
                    }
                }
            }
            else
            {
                snake.RemoveAt(snake.Count - 1); // Remove the tail
            }

            playBox.Invalidate(); // Refresh playBox
        }

        private void GameOver()
        {
            gameTimer.Stop();
            gameMusicPlayer.controls.stop(); // Stop background music
            gameOverSoundPlayer.controls.play();

            MessageBox.Show($"Game Over! Your score: {score} Level: {level}", "Snake Game");
            InitializeGame(); // Restart the game
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            Console.WriteLine($"Key Pressed: {e.KeyCode}"); // Debug message

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (direction != Direction.Right) direction = Direction.Left;
                    break;
                case Keys.Right:
                    if (direction != Direction.Left) direction = Direction.Right;
                    break;
                case Keys.Up:
                    if (direction != Direction.Down) direction = Direction.Up;
                    break;
                case Keys.Down:
                    if (direction != Direction.Up) direction = Direction.Down;
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (direction != Direction.Right) direction = Direction.Left;
                    break;
                case Keys.Right:
                    if (direction != Direction.Left) direction = Direction.Right;
                    break;
                case Keys.Up:
                    if (direction != Direction.Down) direction = Direction.Up;
                    break;
                case Keys.Down:
                    if (direction != Direction.Up) direction = Direction.Down;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }




        private void btnStart_Click(object sender, EventArgs e)
        {
            startButtonSoundPlayer.controls.play();

            this.Focus(); // Ensure the form has focus
            if (!gameTimer.Enabled)
            {
                gameMusicPlayer.controls.play();
                gameTimer.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                gameTimer.Stop();
                btnPause.Text = "Resume";
            }
            else
            {
                gameTimer.Start();
                btnPause.Text = "Pause";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.SeaGreen,  // Top color
                Color.LimeGreen,        // Bottom color
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }
        }




    }
}

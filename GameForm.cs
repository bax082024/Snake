using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food = Point.Empty;
        private int score = 0;
        private Direction direction = Direction.Right;

        private bool moveLeft = false;
        private bool moveRight = false;
        private bool moveUp = false;
        private bool moveDown = false;

        private enum Direction { Up, Down, Left, Right }


        public Form1()
        {
            


            InitializeComponent();

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 100;
            gameTimer.Tick += gameTimer_Tick;

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

            direction = Direction.Right; // Initialize direction

            lblScore.Text = $"Score: {score}";
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
            int cellSize = 20; // Size of each grid cell

            // Draw the snake
            foreach (Point segment in snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * cellSize, segment.Y * cellSize, cellSize, cellSize);
            }

            // Draw the food
            g.FillRectangle(Brushes.Red, food.X * cellSize, food.Y * cellSize, cellSize, cellSize);

            // Draw the score on the form label
            lblScore.Text = $"Score: {score}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Point head = snake[0];
            Point newHead = head;

            switch (direction)
            {
                case Direction.Up: newHead.Y--; break;
                case Direction.Down: newHead.Y++; break;
                case Direction.Left: newHead.X--; break;
                case Direction.Right: newHead.X++; break;
            }

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
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            playBox.Invalidate(); // Refresh playBox
        }



        private void GameOver()
        {
            gameTimer.Stop();
            MessageBox.Show($"Game Over! Your score: {score}", "Snake Game");
            InitializeGame(); // Restart the game
        }


        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction != Direction.Down) direction = Direction.Up;
                    break;
                case Keys.Down:
                    if (direction != Direction.Up) direction = Direction.Down;
                    break;
                case Keys.Left:
                    if (direction != Direction.Right) direction = Direction.Left;
                    break;
                case Keys.Right:
                    if (direction != Direction.Left) direction = Direction.Right;
                    break;
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!gameTimer.Enabled) // Only start if the game is not running
            {
                gameTimer.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                gameTimer.Stop(); // Pause the game
                btnPause.Text = "Resume";
            }
            else
            {
                gameTimer.Start(); // Resume the game
                btnPause.Text = "Pause";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

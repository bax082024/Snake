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

        private enum Direction { Up, Down, Left, Right }


        public Form1()
        {
            InitializeComponent();
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

            gameTimer.Start();
            this.Paint += GameForm_Paint;
            this.KeyDown += GameForm_KeyDown;


        }

        private void GenerateFood()
        {
            Random random = new Random();
            food = new Point(random.Next(0, 30), random.Next(0, 20));
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
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

            // Draw the score
            g.DrawString($"Score: {score}", new Font("Arial", 14), Brushes.Black, 10, 10);
        }

    }
}

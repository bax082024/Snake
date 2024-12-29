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
    }
}

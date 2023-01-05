using Graphic_Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Snake
{
    public partial class Gra_Form : Form
    {

        int level = Menu_Form.poziomTrudnosci;

        private List<Coordinate> Snake = new List<Coordinate>();
        private Coordinate pointForSnake = new Coordinate();

        int maxWidth;
        int maxHeight;

        static int score;
        int highScore;

        public Gra_Form()
        {
            InitializeComponent();

            RestartGame();
        }

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;


        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if (Snake[i].X == pointForSnake.X && Snake[i].Y == pointForSnake.Y)
                    {
                        EatPoint();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();

                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            playingField.Invalidate();

        }
        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics playField = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i != 0)
                {
                    if (Menu_Form.snakeColor == 0)
                    {
                        snakeColor = Brushes.Green;
                    }
                    else if (Menu_Form.snakeColor == 1)
                    {
                        snakeColor = Brushes.Red;
                    }
                    else if (Menu_Form.snakeColor == 2)
                    {
                        snakeColor = Brushes.Purple;
                    }
                    else
                    {
                        snakeColor = Brushes.White;
                    }

                }

                else
                {
                    snakeColor = Brushes.Black;
                }

                playField.FillEllipse(snakeColor, new Rectangle
                        (
                        Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));
            }

            playField.FillEllipse(Brushes.DarkRed, new Rectangle
                (
                pointForSnake.X * Settings.Width,
                pointForSnake.Y * Settings.Height,
                Settings.Width, Settings.Height
                ));
        }

        private void RestartGame()
        {

            if (level == 0)
            {
                timer.Interval = 100;
            }
            else if (level == 2)
            {
                timer.Interval = 50;
            }
            else
            {
                timer.Interval = 75;
            }

            maxWidth = playingField.Width / Settings.Width - 1;
            maxHeight = playingField.Height / Settings.Height - 1;

            Snake.Clear();

            score = 0;
            wynikGracza.Text = "Score: " + score;


            Coordinate head = new Coordinate { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Coordinate body = new Coordinate();
                Snake.Add(body);
            }

            pointForSnake = new Coordinate { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            timer.Start();

        }

        private void EatPoint()
        {
            score += 1;
            wynikGracza.Text = "Score: " + score;


            Coordinate body = new Coordinate
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            pointForSnake = new Coordinate { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }

        private void GameOver()
        {
            timer.Stop();

            if (score > highScore)
            {
                highScore = score;
                najlepszyWynik.Text = "High Score: " + highScore;
                Menu_Form.scores.Add(score);
                Menu_Form.players.Add(NazwaGracza_Form.nazwaGracza);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int SIZE = 4;
        private const int BUTTON_SIZE = 75;
        private Button[,] buttons;
        private Point emptyPoint;

        public Form1()
        {
            InitializeComponent();
            CreateButtons();
            StartNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CreateButtons()
        {
            buttons = new Button[SIZE, SIZE];

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (i == SIZE - 1 && j == SIZE - 1)
                    {
                        emptyPoint = new Point(j, i);
                        continue;
                    }

                    Button button = new Button();
                    button.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                    button.Location = new Point(j * BUTTON_SIZE, i * BUTTON_SIZE);
                    button.Font = new Font("Arial", 16, FontStyle.Bold);
                    button.Click += Button_Click;

                    buttons[i, j] = button;
                    Controls.Add(button);
                }
            }
        }

        private void StartNewGame()
        {
            int number = 1;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (i == SIZE - 1 && j == SIZE - 1)
                        continue;

                    buttons[i, j].Text = number.ToString();
                    number++;
                }
            }

            Random random = new Random();
            for (int i = 0; i < 100; i++) 
            {
                List<Button> possibleMoves = GetPossibleMoves();
                if (possibleMoves.Count > 0)
                {
                    int index = random.Next(possibleMoves.Count);
                    SwapWithEmpty(possibleMoves[index]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (IsAdjacent(clickedButton))
            {
                SwapWithEmpty(clickedButton);
                CheckForWin();
            }
        }

        private bool IsAdjacent(Button button)
        {
            Point buttonPos = GetButtonPosition(button);

            return (Math.Abs(buttonPos.X - emptyPoint.X) == 1 && buttonPos.Y == emptyPoint.Y) ||
                   (Math.Abs(buttonPos.Y - emptyPoint.Y) == 1 && buttonPos.X == emptyPoint.X);
        }

        private Point GetButtonPosition(Button button)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (buttons[i, j] == button)
                        return new Point(j, i);
                }
            }
            return new Point(-1, -1);
        }

        private void SwapWithEmpty(Button button)
        {
            Point buttonPos = GetButtonPosition(button);

            button.Location = new Point(emptyPoint.X * BUTTON_SIZE, emptyPoint.Y * BUTTON_SIZE);

            buttons[emptyPoint.Y, emptyPoint.X] = button;
            buttons[buttonPos.Y, buttonPos.X] = null;
            emptyPoint = buttonPos;
        }

        private List<Button> GetPossibleMoves()
        {
            List<Button> possibleMoves = new List<Button>();

            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { -1, 0, 1, 0 };

            for (int i = 0; i < 4; i++)
            {
                int newX = emptyPoint.X + dx[i];
                int newY = emptyPoint.Y + dy[i];

                if (newX >= 0 && newX < SIZE && newY >= 0 && newY < SIZE)
                {
                    possibleMoves.Add(buttons[newY, newX]);
                }
            }

            return possibleMoves;
        }

        private void CheckForWin()
        {
            int expectedNumber = 1;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (i == SIZE - 1 && j == SIZE - 1)
                        continue;

                    if (buttons[i, j] == null || buttons[i, j].Text != expectedNumber.ToString())
                        return; 

                    expectedNumber++;
                }
            }

            MessageBox.Show("Поздравляем! Вы решили головоломку!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAutoWin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (buttons[i, j] != null)
                    {
                        Controls.Remove(buttons[i, j]);
                    }
                    buttons[i, j] = null;
                }
            }

            int number = 1;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (i == SIZE - 1 && j == SIZE - 1)
                    {
                        emptyPoint = new Point(j, i);
                        continue;
                    }

                    Button button = new Button();
                    button.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                    button.Location = new Point(j * BUTTON_SIZE, i * BUTTON_SIZE);
                    button.Font = new Font("Arial", 16, FontStyle.Bold);
                    button.Text = number.ToString();
                    button.Click += Button_Click;

                    buttons[i, j] = button;
                    Controls.Add(button);

                    number++;
                }
            }

            MessageBox.Show("Головоломка решена автоматически!", "Автопобеда", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
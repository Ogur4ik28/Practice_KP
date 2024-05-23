using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;
        private bool[,] mines;
        private int[,] counts;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[3, 3] {
                { button1, button2, button3 },
                { button4, button5, button6 },
                { button7, button8, button9 }
            };

            mines = new bool[3, 3];
            counts = new int[3, 3];

            Random rand = new Random();
            int mineCount = 0;

            while (mineCount < 2) // Расположим 2 мины случайным образом
            {
                int x = rand.Next(3);
                int y = rand.Next(3);
                if (!mines[x, y])
                {
                    mines[x, y] = true;
                    mineCount++;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    counts[x, y] = CountAdjacentMines(x, y);
                    buttons[x, y].Click += Button_Click;
                }
            }
        }

        private int CountAdjacentMines(int x, int y)
        {
            int count = 0;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;
                    if (nx >= 0 && nx < 3 && ny >= 0 && ny < 3 && mines[nx, ny])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int x = 0, y = 0;
            bool found = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j] == button)
                    {
                        x = i;
                        y = j;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (mines[x, y])
            {
                button.Text = "Мина!";
                this.BackColor = Color.Red;
            }
            else
            {
                button.Text = counts[x, y].ToString();
            }
        }
    }
}

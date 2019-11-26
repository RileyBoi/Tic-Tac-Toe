using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int[,] ttt =
        {
            {-1, -1, -1},
            {-1, -1, -1},
            {-1, -1, -1}
        };
        int user = 0;
        bool buttonsUsable = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckWin()
        {
            if ((ttt[0,0] == ttt[0,1]) && (ttt[0,0] == ttt[0,2]) && (ttt[0,0] !=-1))
            {
                if (ttt[0, 0] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[0, 0] == ttt[1, 1]) && (ttt[0, 0] == ttt[2, 2]) && (ttt[0, 0] != -1))
            {
                if (ttt[0, 0] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[0, 0] == ttt[1, 0]) && (ttt[0, 0] == ttt[2, 0]) && (ttt[0, 0] != -1))
            {
                if (ttt[0, 0] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[0, 1] == ttt[1, 1]) && (ttt[0, 1] == ttt[2, 1]) && (ttt[0, 1] != -1))
            {
                if (ttt[0, 1] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[0, 2] == ttt[1, 2]) && (ttt[0, 2] == ttt[2, 2]) && (ttt[0, 2] != -1))
            {
                if (ttt[0, 2] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[0, 2] == ttt[1, 1]) && (ttt[0, 2] == ttt[2, 0]) && (ttt[0, 2] != -1))
            {
                if (ttt[0, 2] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[1, 0] == ttt[1, 1]) && (ttt[1, 0] == ttt[1, 2]) && (ttt[1, 0] != -1))
            {
                if (ttt[1, 0] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }
            if ((ttt[2, 0] == ttt[2, 1]) && (ttt[2, 0] == ttt[2, 2]) && (ttt[2, 0] != -1))
            {
                if (ttt[2, 0] == 0)
                {
                    MessageBox.Show(@"O wins!!");
                    buttonsUsable = false;
                }
                else
                {
                    MessageBox.Show(@"X Wins!!");
                    buttonsUsable = false;
                }
            }

            if (buttonsUsable == false)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ttt[0, 0] == -1)
            {
                if (user == 0)
                {
                    ttt[0, 0] = 0;
                    user = 1;
                    button1.Text = (@"O");
                }
                else
                {
                    ttt[0, 0] = 1;
                    user = 0;
                    button1.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ttt[0, 1] == -1)
            {
                if (user == 0)
                {
                    ttt[0, 1] = 0;
                    user = 1;
                    button2.Text = (@"O");
                }
                else
                {
                    ttt[0, 1] = 1;
                    user = 0;
                    button2.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ttt[0, 2] == -1)
            {
                if (user == 0)
                {
                    ttt[0, 2] = 0;
                    user = 1;
                    button3.Text = (@"O");
                }
                else
                {
                    ttt[0, 2] = 1;
                    user = 0;
                    button3.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ttt[1, 0] == -1)
            {
                if (user == 0)
                {
                    ttt[1, 0] = 0;
                    user = 1;
                    button4.Text = (@"O");
                }
                else
                {
                    ttt[1, 0] = 1;
                    user = 0;
                    button4.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ttt[1, 1] == -1)
            {
                if (user == 0)
                {
                    ttt[1, 1] = 0;
                    user = 1;
                    button5.Text = (@"O");
                }
                else
                {
                    ttt[1, 1] = 1;
                    user = 0;
                    button5.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ttt[1, 2] == -1)
            {
                if (user == 0)
                {
                    ttt[1, 2] = 0;
                    user = 1;
                    button7.Text = (@"O");
                }
                else
                {
                    ttt[1, 2] = 1;
                    user = 0;
                    button7.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ttt[2, 0] == -1)
            {
                if (user == 0)
                {
                    ttt[2, 0] = 0;
                    user = 1;
                    button6.Text = (@"O");
                }
                else
                {
                    ttt[2, 0] = 1;
                    user = 0;
                    button6.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ttt[2, 1] == -1)
            {
                if (user == 0)
                {
                    ttt[2, 1] = 0;
                    user = 1;
                    button8.Text = (@"O");
                }
                else
                {
                    ttt[2, 1] = 1;
                    user = 0;
                    button8.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ttt[2, 2] == -1)
            {
                if (user == 0)
                {
                    ttt[2, 2] = 0;
                    user = 1;
                    button9.Text = (@"O");
                }
                else
                {
                    ttt[2, 2] = 1;
                    user = 0;
                    button9.Text = (@"X");
                }
                CheckWin();
            }
            else
            {
                MessageBox.Show(@"This tile is already in use.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonsUsable = true;
            button1.Text = (@"");
            button2.Text = (@"");
            button3.Text = (@"");
            button4.Text = (@"");
            button5.Text = (@"");
            button6.Text = (@"");
            button7.Text = (@"");
            button8.Text = (@"");
            button9.Text = (@"");
            ttt[0, 0] = -1;
            ttt[0, 1] = -1;
            ttt[0, 2] = -1;
            ttt[1, 0] = -1;
            ttt[1, 1] = -1;
            ttt[1, 2] = -1;
            ttt[2, 0] = -1;
            ttt[2, 1] = -1;
            ttt[2, 2] = -1;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

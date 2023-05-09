namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int move = 0;
        int playerXScore = 0;
        int playerOScore = 0;
        Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { btnBoard1, btnBoard2, btnBoard3, btnBoard4, btnBoard5, btnBoard6, btnBoard7, btnBoard8, btnBoard9 };
        }

        void clearBoard()
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.White;
                btn.Text = string.Empty;
                
            }
            turn = true;
            move = 0;
            labelTurn.Text = "Player X's turn";
        }

        void paintWinnerMoves(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.ForestGreen;
            btn2.BackColor = Color.ForestGreen;
            btn3.BackColor = Color.ForestGreen;
        }

        void checkScore()
        {

            if (buttons[0].Text != "" && buttons[0].Text == buttons[1].Text && buttons[0].Text == buttons[2].Text)
            {
                paintWinnerMoves(buttons[0], buttons[1], buttons[2]);
                if (buttons[0].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[0].Text != "" && buttons[0].Text == buttons[3].Text && buttons[0].Text == buttons[6].Text)
            {
                paintWinnerMoves(buttons[0], buttons[3], buttons[6]);
                if (buttons[0].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[0].Text != "" && buttons[0].Text == buttons[4].Text && buttons[0].Text == buttons[8].Text)
            {
                paintWinnerMoves(buttons[0], buttons[4], buttons[8]);
                if (buttons[0].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[1].Text != "" && buttons[1].Text == buttons[4].Text && buttons[1].Text == buttons[7].Text)
            {
                paintWinnerMoves(buttons[1], buttons[4], buttons[7]);
                if (buttons[1].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[2].Text != "" && buttons[2].Text == buttons[5].Text && buttons[2].Text == buttons[8].Text)
            {
                paintWinnerMoves(buttons[2], buttons[5], buttons[8]);
                if (buttons[2].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[2].Text != "" && buttons[2].Text == buttons[4].Text && buttons[2].Text == buttons[6].Text)
            {
                paintWinnerMoves(buttons[2], buttons[4], buttons[6]);
                if (buttons[2].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[3].Text != "" && buttons[3].Text == buttons[4].Text && buttons[3].Text == buttons[5].Text)
            {
                paintWinnerMoves(buttons[3], buttons[4], buttons[5]);
                if (buttons[3].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }
            if (buttons[6].Text != "" && buttons[6].Text == buttons[7].Text &&   buttons[6].Text == buttons[8].Text)
            {
                paintWinnerMoves(buttons[6], buttons[7], buttons[8]);
                if (buttons[6].Text == "X")
                {
                    labelPlayerX.Text = (++playerXScore).ToString();
                    MessageBox.Show("Winner is the player X");
                    clearBoard();

                }
                else
                {
                    labelPlayerO.Text = (++playerOScore).ToString();
                    MessageBox.Show("Winner is the player O");
                    clearBoard();
                }
            }


            if (move == 9)
            {
                MessageBox.Show("Draw!");
                clearBoard();
            }
        }

        private void btnBoardClick(object sender, EventArgs e)
        {
            Button btnBoard = (Button)sender;
            btnBoard.Enabled = false;
            if (turn)
            {
                btnBoard.Text = "X";
                turn = false;
                labelTurn.Text = "Player O's turn";
            }
            else
            {
                btnBoard.Text = "O";
                turn = true;
                labelTurn.Text = "Player X's turn";

            }
            if (++move >= 5)
            {
                checkScore();
            }
        }

        private void btnBoard_Enable_Changed(object sender, EventArgs e)
        {
            Button btnBoard = (Button)sender;
            btnBoard.ForeColor = btnBoard.Enabled == false ? Color.Blue : Color.Red;
            btnBoard.BackColor = Color.AliceBlue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearBoard();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearBoard();
            playerXScore = 0;
            playerOScore = 0;
            labelPlayerX.Text = playerXScore.ToString();
            labelPlayerO.Text = playerOScore.ToString();
        }
    }
}
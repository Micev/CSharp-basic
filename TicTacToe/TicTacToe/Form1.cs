using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool turn = true;
        private bool isComputerPlayer = false;
        private int counter = 0;

        private Cursor deffaultCursor = Cursors.Arrow;
        private Cursor handCursor = Cursors.Hand;

        
        static String oponent;
        public Form1()
        {
           InitializeComponent();          
        }

        /// <summary>
        /// Set player name depending on player game chose.
        /// </summary>
        /// <param name="str">pllayer name</param>
        public static void setPlayerName(String str)
        {
            oponent = str;
        }

        /// <summary>
        /// Fill button with text and disable the button.
        /// </summary>
        /// <param name="sender">clicked button</param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
            {
                btn.Text = "X";
                btn.Enabled = false;
                btn.BackColor = Color.LightGray;
            }
            else
            {
               
                btn.Text = "O";
                btn.BackColor = Color.LightGray;
            }

            btn.Enabled = false;
            turn = !turn;
            counter++;


            checkForWinner();

            //start computer artificial inteligence
            if (!turn && isComputerPlayer)
            {
                computerMakeMove();
            }
           
        }

        /// <summary>
        /// chech for a winner or draw
        /// </summary>
        private void checkForWinner()
        {
            bool winner = checkHorizontalForWinner() || checkVerticalForWinner() || checkDiagonalForWinner();

            if (winner)
            {
                disableButtons();
                if(turn)
                {
                    MessageBox.Show("Player 2 win","Winner");
                    oWin_counter.Text = (Int32.Parse(oWin_counter.Text)+1).ToString();
                }
                else
                {
                    MessageBox.Show("Player 1 win","Winner");
                    xWin_counter.Text = (Int32.Parse(xWin_counter.Text) + 1).ToString();
                }           
            }
            else
            {
                if (counter == 9)
                {
                    MessageBox.Show("Draw");
                    draw_counter.Text = (Int32.Parse(draw_counter.Text) + 1).ToString();
                }
            }
        }

        /// <summary>
        /// check for diagonal winner
        /// </summary>
        /// <returns>true or false</returns>
        private bool checkDiagonalForWinner()
        {
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                return true;
            }
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// check for vertical winner
        /// </summary>
        /// <returns>true or false</returns>
        private bool checkVerticalForWinner()
        {
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                return true;
            }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                return true;
            }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// check for horizontal winner
        /// </summary>
        /// <returns>true or false</returns>
        private bool checkHorizontalForWinner()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                return true;
            }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                return true;
            }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// disable play buttons if we have winner
        /// </summary>
        /// <returns>true or false</returns>
        private void disableButtons()
        {

            foreach (Control c in Controls)
            {
                try
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                    btn.BackColor = Color.LightGray;
                }
                catch
                {

                }
            }
           
        }

        /// <summary>
        /// make cursor to be nandCursor and show text X or Y on button to show who is on move
        /// </summary>
        public void button_enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                if (this.Cursor == deffaultCursor)
                {
                    this.Cursor = handCursor;
                }

                if (turn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                if (this.Cursor == handCursor)
                {
                    this.Cursor = deffaultCursor;
                }

                btn.Text = "";
            }
        }

        /// <summary>
        /// Start new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            counter = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = Color.Transparent;
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// Reset the results for win and draw.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xWin_counter.Text = "0";
            oWin_counter.Text = "0";
            draw_counter.Text = "0";
        }

        /// <summary>
        /// Exit from game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 \n\rCreate by Georgi Micev (c) 2015.", "About");
        }

        /// <summary>
        /// First show Play Chose form and then set the variable player2 and agains_computer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            PlayChose playChoseForm = new PlayChose();
            playChoseForm.ShowDialog();
            player2.Text = oponent;

            if (player2.Text == "Computer")
            {
                isComputerPlayer = true;
            }
        }
        /// <summary>
        /// Start computer move with priority
        /// </summary>
        private void computerMakeMove()
        {
            //priority 1: win tic tac toe
            //priority 2: block x tic tac toe
            //priority 3: go to nice place tic tac toe
            //priority 4: pick random space
          
            Button move = null;
           
            move = lookForWinOrBlock("O");
            if (move == null)
            {               
                move = lookForWinOrBlock("X");
                if (move == null)
                {   
                    move = lookForNicePlace();
                    if (move == null)
                    {
                        move = pickRandomSpace();
                    }
                }
            }
            if (counter < 9)
            {
                move.PerformClick();// The countdown is launched!
            }
                     
                
        }

        /// <summary>
        /// Pick a random place
        /// </summary>
        /// <returns>Selected button.</returns>
        private Button pickRandomSpace()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        /// <summary>
        /// Lock for a good place first center, second corner.
        /// </summary>
        /// <returns>Selected button</returns>
        private Button lookForNicePlace()
        {
            //prioriti 1 : lock for center
            //prioriti 2 : lock for corner

            if (B2.Text == "")
                return B2;

            if (B2.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        /// <summary>
        /// Check horizontal, vertical and diagonal opportunity to win first or block second
        /// </summary>
        /// <param name="p">Button text</param>
        /// <returns>Selected button</returns>
        private Button lookForWinOrBlock(string p)
        {
            //HORIZONTAL TEST
            //Horizontal test for A row
            if ((A1.Text == p) && (A2.Text == p) && (A3.Text == ""))
                return A3;
            if ((A2.Text == p) && (A3.Text == p) && (A1.Text == ""))
                return A1;
            if ((A1.Text == p) && (A3.Text == p) && (A2.Text == ""))
                return A2;

            if ((B1.Text == p) && (B2.Text == p) && (B3.Text == ""))
                return B3;
            if ((B2.Text == p) && (B3.Text == p) && (B1.Text == ""))
                return B1;
            if ((B1.Text == p) && (B3.Text == p) && (B2.Text == ""))
                return B2;

            if ((C1.Text == p) && (C2.Text == p) && (C3.Text == ""))
                return C3;
            if ((C2.Text == p) && (C3.Text == p) && (C1.Text == ""))
                return C1;
            if ((C1.Text == p) && (C3.Text == p) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == p) && (B1.Text == p) && (C1.Text == ""))
                return C1;
            if ((B1.Text == p) && (C1.Text == p) && (A1.Text == ""))
                return A1;
            if ((A1.Text == p) && (C1.Text == p) && (B1.Text == ""))
                return B1;

            if ((A2.Text == p) && (B2.Text == p) && (C2.Text == ""))
                return C2;
            if ((B2.Text == p) && (C2.Text == p) && (A2.Text == ""))
                return A2;
            if ((A2.Text == p) && (C2.Text == p) && (B2.Text == ""))
                return B2;

            if ((A3.Text == p) && (B3.Text == p) && (C3.Text == ""))
                return C3;
            if ((B3.Text == p) && (C3.Text == p) && (A3.Text == ""))
                return A3;
            if ((A3.Text == p) && (C3.Text == p) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == p) && (B2.Text == p) && (C3.Text == ""))
                return C3;
            if ((B2.Text == p) && (C3.Text == p) && (A1.Text == ""))
                return A1;
            if ((A1.Text == p) && (C3.Text == p) && (B2.Text == ""))
                return B2;

            if ((A3.Text == p) && (B2.Text == p) && (C1.Text == ""))
                return C1;
            if ((B2.Text == p) && (C1.Text == p) && (A3.Text == ""))
                return A3;
            if ((A3.Text == p) && (C1.Text == p) && (B2.Text == ""))
                return B2;

            return null;

        }

        

    }
}

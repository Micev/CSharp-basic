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
        private int counter = 0;

        private Cursor deffaultCursor = Cursors.Arrow;
        private Cursor handCursor = Cursors.Hand;

        public Form1()
        {
           InitializeComponent();          
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by Georgi Micev (c) 2015.", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
            {
                btn.Text = "X";
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "O";
            }

            btn.Enabled = false;
            turn = !turn;
            counter++;


            checkForWinner();
           
        }

        private void checkForWinner()
        {
            bool winner = checkHorizontalForWinner() || checkVerticalForWinner() || checkDiagonalForWinner();

            if (winner)
            {
                disableButton();
                if(turn)
                {
                    MessageBox.Show("\"O\" player win","Winner");
                    oWin_counter.Text = (Int32.Parse(oWin_counter.Text)+1).ToString();
                }
                else
                {
                    MessageBox.Show("\"X\" player win","Winner");
                }           
            }
            else
            {
                if (counter == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

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

        private void disableButton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                }
            }
            catch
            {
                
            }
        }

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
                }
                catch
                {

                }
            }         
        }

        private void button_enter(object sender, EventArgs e)
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
    }
}

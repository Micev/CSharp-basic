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
    public partial class PlayChose : Form
    {
        private Cursor deffaultCursor = Cursors.Arrow;
        private Cursor handCursor = Cursors.Hand;
        public PlayChose()
        {
            InitializeComponent();
        }

        private void singleplay_btn_Click(object sender, EventArgs e)
        {
            Form1.setPlayerName("Computer");
            this.Close();
        }

        private void multiplay_btn_Click(object sender, EventArgs e)
        {
            Form1.setPlayerName("Player 2");
            this.Close();
        }

        public void button_enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                if (this.Cursor == deffaultCursor)
                {
                    this.Cursor = handCursor;
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
            }
        }

        private void singleplay_btn_MouseEnter(object sender, EventArgs e)
        {

        }       
    }
}

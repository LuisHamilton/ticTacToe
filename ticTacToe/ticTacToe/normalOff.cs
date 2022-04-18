using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class normalOff : Form
    {
        bool turn = false;

        public normalOff()
        {
            InitializeComponent();
        }

        private void normalOff_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text != "")
                return;
            if (turn == false)
            {
                btn.Text = "X";
                turn = true;
            }
            else
            {
                btn.Text = "O";
                turn = false;
            }
        }
    }
}

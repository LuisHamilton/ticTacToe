using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playZAPZAP();
        }
        private void playZAPZAP()
        {
            SoundPlayer ZAPZAPsound = new SoundPlayer(Properties.Resources.zapmusic);
            ZAPZAPsound.Play();
        }
    }
}

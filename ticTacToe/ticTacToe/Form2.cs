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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void playZAPZAP()
        {
            SoundPlayer ZAPZAPsound = new SoundPlayer(Properties.Resources.assobio);
            ZAPZAPsound.Play();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            normalOff frm = new normalOff();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            this.Hide();
            frm2.FormClosed += (s, args) => this.Close();
            frm2.Show();
        }
    }
}

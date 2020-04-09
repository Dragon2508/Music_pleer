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

namespace Music_pleer
{
    public partial class Form1 : Form
    {
        SoundPlayer playeer = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playeer = new SoundPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                playeer.SoundLocation = fileName;
                playeer.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenMedia();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using MySql.Data.MySqlClient;
namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        private int j = 9;
        SpeechSynthesizer voice;
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(AddStories.Instance);
            AddStories.Instance.Dock = DockStyle.Fill;
            AddStories.Instance.BringToFront();
            voice = new SpeechSynthesizer();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(AddStories.Instance))
            {
                panel1.Controls.Add(AddStories.Instance);
                AddStories.Instance.Dock = DockStyle.Fill;
                AddStories.Instance.BringToFront();
            }
            else
            {
                AddStories.Instance.BringToFront();
            }
        }
        private void btnStories_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Search.Instance))
            {
                panel1.Controls.Add(Search.Instance);
                Search.Instance.Dock = DockStyle.Fill;
                Search.Instance.BringToFront();
            }
            else
            {
                Search.Instance.BringToFront();
            }
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(About.Instance))
            {
                panel1.Controls.Add(About.Instance);
                About.Instance.Dock = DockStyle.Fill;
                About.Instance.BringToFront();
            }
            else
            {
                About.Instance.BringToFront();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            { 
                panel1.Controls.Add(AddStories.Instance);
                AddStories.Instance.Dock = DockStyle.Fill;
                AddStories.Instance.BringToFront();
            }
          
        }
    }
}

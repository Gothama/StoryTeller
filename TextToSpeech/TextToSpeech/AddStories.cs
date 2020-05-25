using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace TextToSpeech
{
    public partial class AddStories : UserControl
    {      private Stories stories;
        private static AddStories _instance;
        public static AddStories Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddStories();
                }
                return _instance;
            }
        }
        public AddStories()
        {
            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();
         
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
             
                pictureBox1.Image = new Bitmap(open.FileName);
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Png);
            byte[] pic_arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_arr, 0, pic_arr.Length);
            stories = new Stories(textBox1.Text, textBox2.Text);
            stories.sendData(pic_arr);
            textBox1.Clear();
            textBox2.Clear();
            pictureBox1.Image = null;
        }
    }
}

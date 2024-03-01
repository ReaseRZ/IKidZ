using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace IKidZ
{
    public partial class Letter : Panel
    {
        private PrivateFontCollection _privateFontCollection = new PrivateFontCollection();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        ReadForm read = null;
        private string alphabet;
        private string speechVoice;
        const int OFFSET_XCORD = 69;
        const int OFFSET_YCORD = 100;

        private void AdjustPicture()
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.BackColor = Color.Transparent;
        }
        public void AddConfigure()
        {
            this.label1.Location = new Point((this.Parent.Width / 2 - this.label1.Width / 2) - OFFSET_XCORD, (this.Height / 2 - this.label1.Height / 2) + 75);
            this.label2.Location = new Point((this.Parent.Width / 2 - this.label2.Width / 2) + OFFSET_XCORD, (this.Height / 2 - this.label2.Height / 2) + 75);
            this.label3.Location = new Point(this.Parent.Width / 2 - this.label3.Width / 2, (this.Height / 2 - this.label3.Height / 2) + OFFSET_YCORD + 75);
            this.pictureBox1.Location = new Point(this.Parent.Width / 2 - this.pictureBox1.Width / 2, (this.Height / 2 - this.pictureBox1.Height / 2) + OFFSET_YCORD - 225);
            this.ScreenShoot.Location = new Point(this.Parent.Width / 2 - this.ScreenShoot.Width / 2, 480);
        }

        public FontFamily GetFontFamilyByName(string name)
        {
            return _privateFontCollection.Families.FirstOrDefault(x => x.Name == name);
        }

        public void AddFont(string fullFileName)
        {
            AddFont(File.ReadAllBytes(fullFileName));
        }

        public void AddFont(byte[] fontBytes)
        {
            var handle = GCHandle.Alloc(fontBytes, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            try
            {
                _privateFontCollection.AddMemoryFont(pointer, fontBytes.Length);
            }
            finally
            {
                handle.Free();
            }
        }
        
        private void BackToHome(object sender, EventArgs e)
        {
            read.ShowPanel(0);
        }
        private void LeftButton(object sender, EventArgs e)
        {
            if (read.page > 1)
                read.ShowPanel(--read.page);
        }

        private void RightButton(object sender, EventArgs e)
        {
            if (read.page < 26) 
                read.ShowPanel(++read.page);
        }

        public Letter()
        {
            AddFont("PrintDashed-jpO.ttf");
            InitializeComponent();
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
        }
        public Letter(string alphabet,string voice)
        {
            this.alphabet = alphabet;
            this.speechVoice = null;
            AddFont("PrintDashed-jpO.ttf");
            InitializeComponent();
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.Text = voice;
            this.label1.Text = alphabet.ToUpper();
            this.label2.Text = alphabet.ToLower();
        }
        public Letter(string alphabet, string voice, string voiceSpeech)
        {
            this.alphabet = alphabet;
            this.speechVoice = voiceSpeech;
            AddFont("PrintDashed-jpO.ttf");
            this.Size = new System.Drawing.Size(145, 697);
            InitializeComponent();
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.Text = voice;
            this.label1.Text = alphabet.ToUpper();
            this.label2.Text = alphabet.ToLower();
            this.label5.Text = this.speechVoice;
        }

        public Letter(string alphabet, string voice, string voiceSpeech, Bitmap image)
        {
            this.alphabet = alphabet;
            this.speechVoice = voiceSpeech;
            AddFont("PrintDashed-jpO.ttf");
            InitializeComponent();
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.Text = voice;
            this.label1.Text = alphabet.ToUpper();
            this.label2.Text = alphabet.ToLower();
            this.label5.Text = this.speechVoice;
            this.pictureBox1.Image = image;
            AdjustPicture();
        }
        public Letter(ReadForm form, string alphabet, string voice, string voiceSpeech, Bitmap image)
        {
            read = form;  
            this.alphabet = alphabet;
            this.speechVoice = voiceSpeech;
            AddFont("PrintDashed-jpO.ttf");
            InitializeComponent();
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.Text = voice;
            this.label1.Text = alphabet.ToUpper();
            this.label2.Text = alphabet.ToLower();
            this.label5.Text = this.speechVoice;
            this.pictureBox1.Image = image;
            AdjustPicture();
        }


        public void Speech(object sender, EventArgs e)
        {
            speechSynthesizer.SetOutputToDefaultAudioDevice();
            speechSynthesizer.Speak(this.alphabet);
        }

        public void SpeechPictureBox(object sender, EventArgs e)
        {
            speechSynthesizer.SetOutputToDefaultAudioDevice();
            speechSynthesizer.Speak(this.speechVoice);
        }
        
    }
}

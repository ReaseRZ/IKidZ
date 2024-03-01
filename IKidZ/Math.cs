using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKidZ
{
    public partial class Math : Panel
    {
        Quiz quiz = null;
        public Math()
        {
            InitializeComponent();
            this.label1.Parent = pictureBox1;
            this.textBox1.Parent = pictureBox1;
            this.label1.BackColor = Color.Transparent;

        }
        public void AddConfigure()
        {
            this.label1.Location = new Point((this.Parent.Size.Width / 2) - this.label1.Width / 2, (this.Parent.Size.Height / 2) - this.label1.Height / 2-100);
            this.textBox1.Location = new Point((this.Parent.Size.Width / 2) - this.textBox1.Width / 2, (this.Parent.Size.Height / 2) - this.textBox1.Height / 2);
        }

        public void QuizConfigure()
        {
            quiz = new Quiz();
            quiz.Visible = false;
            this.Controls.Add((quiz));
            this.quiz.Parent = this.Parent;
            quiz.SetConfigure();
            this.Parent.Controls.Add(quiz);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8)
            {
                (sender as TextBox).Text = "";
            }
            if(e.KeyChar == 13) 
            {
                int level;
                Int32.TryParse(this.textBox1.Text, out level);
                this.Visible = false;
                this.quiz.Visible = true;
                quiz.SetLevel(level);
            }
            if (!char.IsDigit(e.KeyChar)||(sender as TextBox).Text.Length != 0)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

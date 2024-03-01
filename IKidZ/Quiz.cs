using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IKidZ
{
    public partial class Quiz : Panel
    {
        Random rnd = new Random();
        const int OFFSET_Y = 75;
        private int minNum = 0;
        private int maxNum = 0;
        private int duration = 60;
        private int completedQuiz = 0;
        private const int TOTALQUIZ = 10;

        private void CreateQuizBasedOnLevel(int level)
        {
            switch (level)
            {
                case 0:
                    minNum = 1;
                    maxNum = 10;
                    break;
                case 1:
                    minNum = 10;
                    maxNum = 50;
                    break;
                case 2:
                    minNum = 10;
                    maxNum = 100;
                    break;
                case 3:
                    minNum = 50;
                    maxNum = 150;
                    break;
                case 4:
                    minNum = 75;
                    maxNum = 200;
                    break;
                case 5:
                    minNum = 100;
                    maxNum = 250;
                    break;
                case 6:
                    minNum = 150;
                    maxNum = 300;
                    break;
                case 7:
                    minNum = 250;
                    maxNum = 500;
                    break;
                case 8:
                    minNum = 350;
                    maxNum = 700;
                    break;
                case 9:
                    minNum = 500;
                    maxNum= 1000;
                    break;
            }
        }

        private void ResetQuestion()
        {
            this.label2.Text = rnd.Next(minNum, maxNum + 1).ToString();
            this.label4.Text = rnd.Next(minNum, maxNum + 1).ToString();
            this.label5.Text = completedQuiz.ToString() + "/" + TOTALQUIZ.ToString();
            SetConfigure();
        }

        public void SetConfigure()
        {
            this.label2.Location = new Point((this.Parent.Width / 2 - this.label2.Width / 2)-(this.label2.Width), this.Parent.Height / 2 - this.label2.Height / 2-OFFSET_Y);
            this.label3.Location = new Point((this.Parent.Width / 2 - this.label3.Width / 2), this.Parent.Height / 2 - this.label3.Height / 2-OFFSET_Y);
            this.label4.Location = new Point((this.Parent.Width / 2 - this.label4.Width / 2)+(this.label4.Width), this.Parent.Height / 2 - this.label4.Height / 2 - OFFSET_Y);
            this.textBox1.Location = new Point((this.Parent.Width / 2 - this.textBox1.Width / 2), (this.Parent.Height / 2 - this.textBox1.Height / 2)+this.textBox1.Height-45);
        }

        public void SetLevel(int level)
        {
            CreateQuizBasedOnLevel(level);
            ResetQuestion();
            SetConfigure();
        }

        public Quiz()
        {
            InitializeComponent();
            this.label1.Parent = pictureBox1;
            this.label1.Text = duration.ToString();
            this.label2.Parent = pictureBox1;
            this.label3.Parent = pictureBox1;
            this.label4.Parent = pictureBox1;
            this.label5.Parent = pictureBox1;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent; 
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label5.Text = completedQuiz.ToString()+"/"+TOTALQUIZ.ToString();
            this.dur.Start();

            int tempLeft,tempRight;

            switch (GlobalReference.Operation)
            {
                case Operation.Addition:
                    this.label3.Text = "+";
                    this.label2.Text = rnd.Next(minNum, maxNum + 1).ToString();
                    this.label4.Text = rnd.Next(minNum, maxNum + 1).ToString();
                    break;
                case Operation.Subtraction:
                    this.label3.Text = "-";
                    this.label2.Text = rnd.Next(minNum, maxNum + 1).ToString();
                    this.label4.Text = rnd.Next(minNum, maxNum + 1).ToString();
                    int.TryParse(this.label2.Text, out tempLeft);
                    int.TryParse(this.label4.Text, out tempRight);
                    if(tempRight > tempLeft)
                    {
                        string tempStr = this.label2.Text;
                        this.label2.Text = this.label4.Text;
                        this.label4.Text = tempStr;
                    }
                    break;
                case Operation.Multiplication:
                    this.label3.Text = "X";
                    this.label2.Text = rnd.Next(minNum, maxNum + 1).ToString();
                    this.label4.Text = rnd.Next(minNum, maxNum + 1).ToString();
                    break;
                case Operation.Division:
                    this.label3.Text = ":";
                    int Prolog = 0;
                    tempLeft = rnd.Next(minNum, maxNum + 1);
                    tempRight = rnd.Next(minNum, maxNum + 1);
                    Prolog = tempLeft * tempRight;
                    this.label2.Text = Prolog.ToString();
                    this.label4.Text = tempRight.ToString();
                    break;
            }
        }

        private void dur_Tick(object sender, EventArgs e)
        {
            if (completedQuiz == TOTALQUIZ)
            {
                
                this.dur.Stop();
            }

            if (duration > 0)
            {
                --duration;
                this.label1.Text = duration.ToString();
            }
            else
            {
                this.dur.Stop();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int result = 0; int LeftValue = 0; int RightValue = 0;
            Int32.TryParse((sender as TextBox).Text, out result);
            Int32.TryParse(this.label2.Text, out LeftValue);
            Int32.TryParse(this.label4.Text, out RightValue);
            if(e.KeyChar == 8)
            {
                textBox1.Text = "";
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (DoOperation(LeftValue,RightValue,result))
                {
                    completedQuiz++;
                    textBox1.Text = "";
                    ResetQuestion();
                }
            }
        }
        
        private bool DoOperation(int left,int right,int result)
        {
            if(GlobalReference.Operation == Operation.Addition)
            {
                return (left + right)==result;
            }
            else if(GlobalReference.Operation == Operation.Subtraction)
            {
                return (left - right) == result;
            }
            else if(GlobalReference.Operation== Operation.Multiplication)
            {
                return (left + right) == result;
            }
            else
            {
                return (left/right) == result;
            }
        }
    }
}

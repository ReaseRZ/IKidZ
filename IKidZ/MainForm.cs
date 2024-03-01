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
    public partial class MainForm : Form
    {
        ReadForm readForm = null;
        CountForm countForm = null;
        public MainForm()
        {
            readForm = new ReadForm(this);
            countForm = new CountForm();
            InitializeComponent();
            this.title.Parent = this.pictureBox1;
            this.title.BackColor = System.Drawing.Color.Transparent;
        }

        public void ReadButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            this.readForm.ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.countForm.ShowDialog();
        }
    }
}

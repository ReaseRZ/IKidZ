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
    public partial class CountForm : Form
    {
        System.Windows.Forms.ToolTip toolTipAddition = null;
        System.Windows.Forms.ToolTip ToolTipSubtraction = null;
        System.Windows.Forms.ToolTip toolTipMultiply = null;
        System.Windows.Forms.ToolTip toolTipDivision = null;

        Math newMathPanel = null;

        private void CreateOperationMathPanel()
        {
            newMathPanel = new Math();
            newMathPanel.Visible = false;
            this.Controls.Add(newMathPanel);
            this.newMathPanel.Parent = this;
            newMathPanel.AddConfigure();

            
        }
        public CountForm()
        {
            InitializeComponent();
            CreateOperationMathPanel();
            this.Addition.Parent = pictureBox1;
            this.Substraction.Parent = pictureBox1;
            this.Multiplication.Parent = pictureBox1;
            this.Division.Parent = pictureBox1;
            this.label1.Parent = pictureBox1;
            this.Addition.BackColor = Color.Transparent;
            this.Substraction.BackColor = Color.Transparent;
            this.Multiplication.BackColor = Color.Transparent;
            this.Division.BackColor = Color.Transparent;
            this.label1.BackColor = Color.Transparent;

            toolTipAddition = new System.Windows.Forms.ToolTip();
            ToolTipSubtraction = new System.Windows.Forms.ToolTip();
            toolTipMultiply = new System.Windows.Forms.ToolTip();
            toolTipDivision = new System.Windows.Forms.ToolTip();

            //Add ToolTip
            toolTipAddition.SetToolTip(this.Addition, "Take Quiz Addition");
            ToolTipSubtraction.SetToolTip(this.Substraction, "Take Quiz Subtraction");
            toolTipMultiply.SetToolTip(this.Multiplication, "Take Quiz Multiplication");
            toolTipMultiply.SetToolTip(this.Division, "Take Quiz Division");
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.newMathPanel.Visible = true;
            GlobalReference.Operation = Operation.Addition;
            newMathPanel.QuizConfigure();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            newMathPanel.Visible = true;
            this.panel1.Visible = false;
            GlobalReference.Operation = Operation.Subtraction;
            newMathPanel.QuizConfigure();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            newMathPanel.Visible = true;
            this.panel1.Visible = false;
            GlobalReference.Operation = Operation.Multiplication;
            newMathPanel.QuizConfigure();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            newMathPanel.Visible = true;
            this.panel1.Visible = false;
            GlobalReference.Operation = Operation.Division;
            newMathPanel.QuizConfigure();
        }
    }
}

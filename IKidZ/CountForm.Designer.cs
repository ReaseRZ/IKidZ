using System.Windows.Forms;

namespace IKidZ
{
    partial class CountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Division);
            this.panel1.Controls.Add(this.Multiplication);
            this.panel1.Controls.Add(this.Substraction);
            this.panel1.Controls.Add(this.Addition);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 690);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(514, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 138);
            this.label1.TabIndex = 5;
            this.label1.Text = "MATH";
            // 
            // Division
            // 
            this.Division.BackgroundImage = global::IKidZ.Properties.Resources.div;
            this.Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Division.FlatAppearance.BorderSize = 0;
            this.Division.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division.Location = new System.Drawing.Point(831, 452);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(150, 150);
            this.Division.TabIndex = 3;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.BackgroundImage = global::IKidZ.Properties.Resources.X;
            this.Multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Multiplication.FlatAppearance.BorderSize = 0;
            this.Multiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplication.Location = new System.Drawing.Point(482, 452);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(150, 150);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Substraction
            // 
            this.Substraction.BackColor = System.Drawing.Color.Transparent;
            this.Substraction.BackgroundImage = global::IKidZ.Properties.Resources._1;
            this.Substraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Substraction.FlatAppearance.BorderSize = 0;
            this.Substraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Substraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Substraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Substraction.Location = new System.Drawing.Point(831, 205);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(150, 150);
            this.Substraction.TabIndex = 1;
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Substraction_Click);
            // 
            // Addition
            // 
            this.Addition.BackgroundImage = global::IKidZ.Properties.Resources._;
            this.Addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addition.FlatAppearance.BorderSize = 0;
            this.Addition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addition.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(482, 205);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(150, 150);
            this.Addition.TabIndex = 0;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IKidZ.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1445, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 690);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CountForm";
            this.Text = "CountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private Button Substraction;
        private Button Addition;
    }
}
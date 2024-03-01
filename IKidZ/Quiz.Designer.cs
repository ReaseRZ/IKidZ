using System.Drawing;

namespace IKidZ
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Congrats = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.Sorry = new System.Windows.Forms.Label();
            this.TryAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Completed = new System.Windows.Forms.Panel();
            this.Uncompleted = new System.Windows.Forms.Panel();
            this.Lossssss = new System.Windows.Forms.Panel();
            this.dur = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IKidZ.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1427, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // pictureBox2
            //
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::IKidZ.Properties.Resources.bg;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1427, 643);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            //
            // pictureBox3
            //
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::IKidZ.Properties.Resources.bg;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1427, 643);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 50F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 90F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 173);
            this.label2.TabIndex = 2;
            this.label2.Text = "1231";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 90F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(631, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 173);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 90F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(801, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 173);
            this.label4.TabIndex = 4;
            this.label4.Text = "1111";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dur
            // 
            this.dur.Interval = 1000;
            this.dur.Tick += new System.EventHandler(this.dur_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Eras Demi ITC", 80F);
            this.textBox1.Location = new System.Drawing.Point(545, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 154);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 50F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 97);
            this.label5.TabIndex = 6;
            this.label5.Text = "ex";
            // 
            // Quiz
            // 
            this.ClientSize = new System.Drawing.Size(1427, 643);
            this.Uncompleted.Controls.Add(this.label5);
            this.Uncompleted.Controls.Add(this.label4);
            this.Uncompleted.Controls.Add(this.label3);
            this.Uncompleted.Controls.Add(this.label2);
            this.Uncompleted.Controls.Add(this.label1);
            this.Uncompleted.Controls.Add(this.textBox1);
            this.Uncompleted.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Uncompleted);
            this.Name = "Quiz";
            this.Text = "Quiz";
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // Completed
            //
            this.Completed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Completed.Location = new System.Drawing.Point(0, 0);
            this.Completed.Name = "panel1";
            this.Completed.Size = new System.Drawing.Size(1445, 690);
            this.Completed.Controls.Add(this.Congrats);
            this.Completed.Controls.Add(this.backHome);
            this.Completed.Controls.Add(this.pictureBox2);
            this.Completed.Visible = true;
            //
            // Uncompleted
            //
            this.Uncompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Uncompleted.Location = new System.Drawing.Point(0, 0);
            this.Uncompleted.Name = "panel1";
            this.Uncompleted.Size = new System.Drawing.Size(1445, 690);
            //
            // Loss
            //
            this.Lossssss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lossssss.Location = new System.Drawing.Point(0, 0);
            this.Lossssss.Name = "panel1";
            this.Lossssss.Size = new System.Drawing.Size(1445, 690);
            //
            // Congrats
            //
            this.Congrats.AutoSize = true;
            this.Congrats.Font = new System.Drawing.Font("Eras Demi ITC", 50F);
            this.Congrats.ForeColor = System.Drawing.Color.White;
            this.Congrats.Location = new System.Drawing.Point(13, 537);
            this.Congrats.Name = "Congrats";
            this.Congrats.Size = new System.Drawing.Size(136, 97);
            this.Congrats.TabIndex = 6;
            this.Congrats.Text = "You have completed the whole quiz, Great!!!";
            //
            // backHome
            //
            this.backHome.BackColor = System.Drawing.Color.Transparent;
            //this.backHome.BackgroundImage = global::IKidZ.Properties.Resources.Speaker;
            this.backHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backHome.FlatAppearance.BorderSize = 0;
            this.backHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHome.Location = new System.Drawing.Point(710, 235);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(87, 76);
            this.backHome.TabIndex = 5;
            this.backHome.UseVisualStyleBackColor = false;
            //
            // Sorry
            //
            this.Congrats.AutoSize = true;
            this.Congrats.Font = new System.Drawing.Font("Eras Demi ITC", 50F);
            this.Congrats.ForeColor = System.Drawing.Color.White;
            this.Congrats.Location = new System.Drawing.Point(13, 537);
            this.Congrats.Name = "Sorry";
            this.Congrats.Size = new System.Drawing.Size(136, 97);
            this.Congrats.TabIndex = 6;
            this.Congrats.Text = "You have to try again, don't surrender !!!";
            //
            // TryAgain
            //
            this.backHome.BackColor = System.Drawing.Color.Transparent;
            //this.backHome.BackgroundImage = global::IKidZ.Properties.Resources.Speaker;
            this.backHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backHome.FlatAppearance.BorderSize = 0;
            this.backHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHome.Location = new System.Drawing.Point(710, 235);
            this.backHome.Name = "TryAgain";
            this.backHome.Size = new System.Drawing.Size(87, 76);
            this.backHome.TabIndex = 5;
            this.backHome.UseVisualStyleBackColor = false;

           

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer dur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        
        public System.Windows.Forms.Panel Uncompleted;
        
        public System.Windows.Forms.Panel Completed;
        private System.Windows.Forms.Label Congrats;
        private System.Windows.Forms.Button backHome; 
        
        public System.Windows.Forms.Panel Lossssss;
        private System.Windows.Forms.Label Sorry;
        private System.Windows.Forms.Button TryAgain;
    }
}
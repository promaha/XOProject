using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XOProject.Properties;

namespace XOProject
{
    public partial class Form1 : Form
    {
        //maha is proffessional coder
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);

            pen.Width = 8;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

           // e.Graphics.DrawLine(pen, 300, 100, 300, 400);

            //Line Vertical
            e.Graphics.DrawLine(pen, 450, 100, 450, 400);

            e.Graphics.DrawLine(pen, 600, 100, 600, 400);

            //Line Horizental
            e.Graphics.DrawLine(pen, 300, 190, 740, 190);

            e.Graphics.DrawLine(pen,  300, 300, 740, 300);

        }

        void RestartGaming()
        {
            lblTurn.Text = lblTurn.Tag.ToString();
            lblWin.Text = lblWin.Tag.ToString();
            Count = 0;
            pictureBox1.Image = Resources.QuistionMark;
            pictureBox2.Image = Resources.QuistionMark;
            pictureBox3.Image = Resources.QuistionMark;
            pictureBox4.Image = Resources.QuistionMark;
            pictureBox5.Image = Resources.QuistionMark;
            pictureBox6.Image = Resources.QuistionMark;
            pictureBox7.Image = Resources.QuistionMark;
            pictureBox8.Image = Resources.QuistionMark;
            pictureBox9.Image = Resources.QuistionMark;

            pictureBox1.Tag = "?";
            pictureBox2.Tag = "?";
            pictureBox3.Tag = "?";
            pictureBox4.Tag = "?";
            pictureBox5.Tag = "?";
            pictureBox6.Tag = "?";
            pictureBox7.Tag = "?";
            pictureBox8.Tag = "?";
            pictureBox9.Tag = "?";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestartGaming();
        }

        void ChangeImage()
        {

        }
        void Winner()
        { 
            if( ((pictureBox1.Tag.ToString() == "1") &&
                 (pictureBox2.Tag.ToString() == "1") &&
                 (pictureBox3.Tag.ToString() == "1"))||

                ((pictureBox4.Tag.ToString() == "1") &&
                 (pictureBox5.Tag.ToString() == "1") &&
                 (pictureBox6.Tag.ToString() == "1"))||

                ((pictureBox7.Tag.ToString() == "1")&&
                 (pictureBox8.Tag.ToString() == "1") &&
                 (pictureBox8.Tag.ToString() == "1"))||

                ((pictureBox1.Tag.ToString() == "1") &&
                (pictureBox6.Tag.ToString() == "1") &&
                (pictureBox9.Tag.ToString() == "1")) ||

                ((pictureBox2.Tag.ToString() == "1") &&
                (pictureBox5.Tag.ToString() == "1") &&
                (pictureBox8.Tag.ToString() == "1")) ||

                ((pictureBox3.Tag.ToString() == "1") &&
                (pictureBox4.Tag.ToString() == "1") &&
                (pictureBox7.Tag.ToString() == "1")) ||

                ((pictureBox3.Tag.ToString() == "1") &&
                (pictureBox5.Tag.ToString() == "1") &&
                (pictureBox9.Tag.ToString() == "1")) ||

               ((pictureBox1.Tag.ToString() == "1") &&
                (pictureBox5.Tag.ToString() == "1") &&
                (pictureBox7.Tag.ToString() == "1")))
            {
                lblWin.Text = "Player1";
                MessageBox.Show("Player1 Is Winner", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Count = 9;

                return;
            }
            if (((pictureBox1.Tag.ToString() == "2") &&
                 (pictureBox2.Tag.ToString() == "2") &&
                 (pictureBox3.Tag.ToString() == "2")) ||

                ((pictureBox4.Tag.ToString() == "2") &&
                 (pictureBox5.Tag.ToString() == "2") &&
                 (pictureBox6.Tag.ToString() == "2")) ||

                ((pictureBox7.Tag.ToString() == "2") &&
                 (pictureBox8.Tag.ToString() == "2") &&
                 (pictureBox9.Tag.ToString() == "2")) ||

                ((pictureBox1.Tag.ToString() == "2") &&
                 (pictureBox6.Tag.ToString() == "2") &&
                 (pictureBox9.Tag.ToString() == "2")) ||

                ((pictureBox2.Tag.ToString() == "2") &&
                 (pictureBox5.Tag.ToString() == "2") &&
                 (pictureBox8.Tag.ToString() == "2")) ||

                ((pictureBox3.Tag.ToString() == "2") &&
                 (pictureBox4.Tag.ToString() == "2") &&
                 (pictureBox7.Tag.ToString() == "2")) ||

                ((pictureBox3.Tag.ToString() == "2") &&
                 (pictureBox5.Tag.ToString() == "2") &&
                 (pictureBox9.Tag.ToString() == "2")) ||

                ((pictureBox1.Tag.ToString() == "2") &&
                 (pictureBox5.Tag.ToString() == "2") &&
                 (pictureBox7.Tag.ToString() == "2")))
            {
                lblWin.Text = "Player2";
                MessageBox.Show("Player2 Is Winner", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Count = 9;

                return;
            }
            if ((pictureBox1.Tag.ToString() !="?") &&
                (pictureBox3.Tag.ToString() !="?") &&
                (pictureBox2.Tag.ToString() !="?") &&
                                              
               (pictureBox4.Tag.ToString()  !="?") &&
                (pictureBox5.Tag.ToString() !="?") &&
                (pictureBox6.Tag.ToString() !="?") &&
                                             
               (pictureBox7.Tag.ToString()  !="?") &&
                (pictureBox8.Tag.ToString() !="?") &&
                (pictureBox9.Tag.ToString() !="?"))
            {
                lblWin.Text = "No Winner";
                MessageBox.Show("No Winner", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Count = 9;
                return;
            }
        }
        short Count = 0;
        void ConvertPBox(PictureBox  PB)
        {
            if (PB.Tag.ToString() == "?" && Count < 9)
            {
                if (lblTurn.Text == "Player1")
                {
                    PB.Image = Resources.X;
                    lblTurn.Text = "Player2";
                    PB.Tag = 1;
                    Count++;
                }
                else
                {
                    PB.Image = Resources.O;
                    lblTurn.Text = "Player1";
                    PB.Tag = 2;
                    Count++;
                }

            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ConvertPBox((PictureBox)sender);
            Winner();

        }
    }
}

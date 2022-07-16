using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taraftartimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\Nur\Desktop\LVBEL C5 - '10 numara, (1).mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();

            if (checkBox1.Checked == true)
            {

                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Red;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Yellow;
                }
            }


            if (checkBox2.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Navy;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Navy;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Navy;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Navy;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Navy;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Navy;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Navy;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Navy;
                    button8.BackColor = Color.Yellow;
                }
            }

            if (checkBox3.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    button8.BackColor = Color.White;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    button8.BackColor = Color.White;
                }
            }

            if (checkBox4.Checked == true)
            {


                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Purple;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Purple;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Purple;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Purple;
                    button8.BackColor = Color.Blue;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Purple;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Purple;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Purple;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Purple;
                    button8.BackColor = Color.Blue;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\Nur\Desktop\LVBEL C5 - '10 numara, (1).mp3";

           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\Nur\Desktop\LVBEL C5 - '10 numara, (1).mp3";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\Nur\Desktop\LVBEL C5 - '10 numara, (1).mp3";
        }
    }
}

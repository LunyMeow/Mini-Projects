using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Media;

namespace WindowsFormsApplication9
{    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random yönr = new Random();
        byte yön;
        int süre=60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yön == 1)
            {
                top.Left += 2;
                top.Top -= 6;
            }
            if (yön == 2)
            {
                top.Left += 4;
                top.Top -= 4;
            }
            if (yön == 3)
            {
                top.Left += 6;
                top.Top -= 2;
            }
            if (yön == 4)
            {
                top.Left += 4;
            }
            if (yön == 5)
            {
                top.Left += 6;
                top.Top += 2;
            }
            if (yön == 6)
            {
                top.Left += 4;
                top.Top += 4;
            }
            if (yön == 7)
            {
                top.Left += 2;
                top.Top += 6;
            }
            if (yön == 8)
            {
                top.Left -= 2;
                top.Top += 6;
            }
            if (yön == 9)
            {
                top.Left -= 4;
                top.Top += 4;

            }
            if (yön == 10)
            {
                top.Left -= 6;
                top.Top += 2;
            }
            if (yön == 11)
            {
                top.Left -= 4;
            }
            if (yön == 12)
            {
                top.Left -= 6;
                top.Top -= 2;
            }
            if (yön == 13)
            {
                top.Left -= 4;
                top.Top -= 4;
            }
            if (yön == 14)
            {
                top.Left -= 2;
                top.Top -= 6;
            }

            

            if (top.Bounds.IntersectsWith(label1.Bounds))
            {
                if (yön == 1||yön==2||yön==3)
                {
                    yön = Convert.ToByte(new Random().Next(12,14));
                }
                
                if (yön == 4)
                {
                    yön = Convert.ToByte(yönr.Next(8, 14));
                }
                if (yön == 5||yön == 6||yön==7)
                {
                    yön = Convert.ToByte(new Random().Next(8, 10));
                }
                

            }

            if (top.Bounds.IntersectsWith(label2.Bounds))
            {
                if (yön == 8 || yön==9||yön==10)
                {
                    yön = Convert.ToByte(new Random().Next(5, 7)); ;
                }
               
                if (yön == 11)
                {
                    yön = Convert.ToByte(yönr.Next(1, 7));
                }
                if (yön == 12||yön==13||yön==14)
                {
                    yön = Convert.ToByte(new Random().Next(1, 3)); ;
                }
                
            }

            if (yön==1||yön==2||yön==3)
            {
                if (top.Top<10)
                {
                    if (yön==1)
                    {
                        yön = 7;
                    }
                    else if (yön == 2)
                    {
                        yön = 6;
                    }
                    else if (yön == 3)
                    {
                        yön = 5;
                    }
                }
            }
            if (yön == 14 || yön == 12 || yön == 13)
            {
                if (top.Top < 10)
                {
                    if (yön == 14)
                    {
                        yön = 8;
                    }
                    else if (yön == 12)
                    {
                        yön = 10;
                    }
                    else if (yön == 13)
                    {
                        yön = 9;
                    }
                }
            }
            //
            if (yön == 5 || yön == 6 || yön == 7)
            {
                if (top.Top > 275)
                {
                    if (yön == 5)
                    {
                        yön = 3;
                    }
                    else if (yön == 6)
                    {
                        yön = 2;
                    }
                    else if (yön == 7)
                    {
                        yön = 1;
                    }
                }
            }
            if (yön == 8 || yön == 9 || yön == 10)
            {
                if (top.Top > 275)
                {
                    if (yön == 8)
                    {
                        yön = 14;
                    }
                    else if (yön == 9)
                    {
                        yön = 13;
                    }
                    else if (yön == 10)
                    {
                        yön = 12;
                    }
                }
            }
            if (top.Left>710)
            {
                p1++;
                label3.Text = p1.ToString();
                puan();
            }
            if (top.Left<0)
            {
                p2++;
                label4.Text = p2.ToString();
                puan();
            }


        }
        void puan()
        {
            timer1.Stop();
            top.Left = 350;
            top.Top = 145;
            timer4.Enabled = true;
            label6.Visible = true;
            yön = Convert.ToByte(yönr.Next(1,14));


        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
            yön = Convert.ToByte(yönr.Next(1,14));
            timer1.Enabled = false;
            timer4.Enabled = false;
            timer3.Enabled = false;
            
        }
        bool l1up = false, l1down = false;
        bool l2up = false, l2down = false;
        Keys SağOyuncuDown = Keys.Down;
        Keys SağOyuncuUp = Keys.Up;
        Keys SolOyuncuDown = Keys.S;
        Keys SolOyuncuUp = Keys.W;
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==SağOyuncuDown)
            {
                l1down = true;
                l1up = false;
            }

            if (e.KeyCode==SağOyuncuUp)
            {
                l1up = true;
                l1down = false;
            }

            if (e.KeyCode == SolOyuncuDown)
            {
                l2down = true;
                l2up = false;
            }

            if (e.KeyCode == SolOyuncuUp)
            {
                l2up = true;
                l2down = false;
            }

        }
        int p1=0, p2=0;
        void Kaybetti()
        {

            timer3.Enabled = false;
            timer1.Enabled = false;
            timer4.Enabled = false;
            timer2.Enabled = false;

            timer6.Enabled = true;
            
            
            
            l1up = false;
            l1down = false;
            l2up = false;
            l2down = false;

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (l1up&&label1.Top>0)
            {
                label1.Top -= 2;
            }
            if (l1down&&label1.Top<=220)
            {
                label1.Top += 2;
            }

            if (l2up && label2.Top > 0)
            {
                label2.Top -= 2;
            }
            if (l2down && label2.Top <= 220)
            {
                label2.Top += 2;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label5.Text = süre.ToString();
            if (süre<10)
            {
                label5.ForeColor = Color.Red;
            }


            if (süre == 0)
            {
                Kaybetti();
            }
            süre--;
        }
        int bsüre = 4;
        private void timer4_Tick(object sender, EventArgs e)
        {
            bsüre--;
            label6.Visible = true;
            timer1.Enabled = false;
            timer3.Enabled = false;
            label6.Text = bsüre.ToString();
           
            if (bsüre == 0)
            {
                label6.Visible = false;
                bsüre = 4;
                label6.Text = "3";
                timer1.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = false;

            }
            this.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tur_sayısı = 1;
            p1 = 0;
            p2 = 0;
            label3.Text = "0";
            label4.Text = "0";
            süre = Convert.ToInt32(textBox1.Text);
            yön = Convert.ToByte(yönr.Next(1, 14));
            top.Left = 350;
            top.Top = 145;
            timer1.Interval = 25;
            timer1.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            button1.TabIndex = 5;
            
            label5.ForeColor = Color.Lime;
            label5.Text = textBox1.Text.ToString();
            panel1.Visible = false;
            label1.Top = 103;
            label2.Top = 103;
            timer2.Enabled = true;
            this.Focus();
            
        }
        int red = 0, blue = 0, green = 0;
        int red2 = 255, blue2 = 255, green2 = 255;
        byte a = 0;
        byte b = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (a == 0)
            {
                red+=4;
                if (red == 252)
                {
                    a++;
                }
            }

            if (a == 1)
            {
                green+=4;
                if (green == 252)
                {
                    a++;

                }
            }
            if (a == 2)
            {
                blue+=4;
                if (blue == 252)
                {
                    a++;
                }
            }

            if (a == 3)
            {
                red-=4;
                if (red == 4)
                {
                    a++;
                }
            }
            if (a == 4)
            {
                green-=4;
                if (green == 4)
                {
                    a++;
                }
            }
            if (a == 5)
            {
                blue-=4;
                if (blue == 4)
                {
                    a++;
                }
            }




            if (a == 6)
            {
                a = 0;
            }


            panel1.BackColor = Color.FromArgb(red, green, blue);
            //
            //
            if (b == 0)
            {
                red2--;
                if (red2 == 0)
                {
                    b++;
                }
            }

            if (b == 1)
            {
                green2--;
                if (green2 == 0)
                {
                    b++;

                }
            }
            if (b == 2)
            {
                blue2--;
                if (blue2 == 0)
                {
                    b++;
                }
            }

            if (b == 3)
            {
                red2++;
                if (red2 == 255)
                {
                    b++;
                }
            }
            if (b == 4)
            {
                green2++;
                if (green2 == 255)
                {
                    b++;
                }
            }
            if (b == 5)
            {
                blue2++;
                if (blue2 == 255)
                {
                    b++;
                }
            }




            if (b == 6)
            {
                b = 0;
            }

            label9.ForeColor = Color.FromArgb(red2, green2, blue2);
            label10.ForeColor = Color.FromArgb(red2, green2, blue2);
        }
        bool kazanansayaç = false;
        byte sayaç = 0;
        bool abcd = false;
        private void timer6_Tick(object sender, EventArgs e)
        {
            
            if (p1 < p2)
            {
                
                if (sayaç<=10)
                {
                    
                    if (kazanansayaç==false)
                    {
                        label1.BackColor = Color.Lime;
                        kazanansayaç = true;
                    }
                    else if (kazanansayaç==true)
                    {
                        label1.BackColor = SystemColors.MenuHighlight;
                        kazanansayaç = false;
                    }
                    
                    
                }
                else if (sayaç==11)
                {
                    sayaç = 0;
                    label1.BackColor = SystemColors.MenuHighlight;
                    timer6.Enabled = false;
                    abcd = true;
                }
            }
            else if (p2 < p1)
            {
                if (sayaç <= 10)
                {
                    if (kazanansayaç == false)
                    {
                        label2.BackColor = Color.Lime;
                        kazanansayaç = true;
                    }
                    else if (kazanansayaç == true)
                    {
                        label2.BackColor = SystemColors.MenuHighlight;
                        kazanansayaç = false;
                    }


                }
                else if (sayaç == 11)
                {
                    sayaç = 0;
                    label2.BackColor = SystemColors.MenuHighlight;
                    timer6.Enabled = false;
                    abcd = true;
                }
            }
            else
            {
                if (sayaç <= 10)
                {
                    if (kazanansayaç == false)
                    {
                        label1.BackColor = Color.Lime;
                        label2.BackColor = Color.Lime;
                        kazanansayaç = true;
                    }
                    else if (kazanansayaç == true)
                    {
                        label1.BackColor = SystemColors.MenuHighlight;
                        label2.BackColor = SystemColors.MenuHighlight;
                        kazanansayaç = false;
                    }

                    
                }
                else if (sayaç == 11)
                {
                    sayaç = 0;
                    label1.BackColor = SystemColors.MenuHighlight; 
                    label2.BackColor = SystemColors.MenuHighlight;
                    timer6.Enabled = false;
                    abcd = true;
                }
            }
            sayaç++;
            if (abcd)
            {
                //panel1.Visible = true;
                if (tur_sayısı == 1)
                {
                    tur_sayısı = 2;
                    Round2();
                }
                else if (tur_sayısı == 2)
                {
                    tur_sayısı = 3;
                    Round3();
                }
                else if (tur_sayısı == 3)
                {
                    panel1.Visible = true;
                }
                else
                    MessageBox.Show("Hata");
                
                sayaç = 0;
                kazanansayaç = false;
                this.Focus();
                abcd = false;
            }
        }

        private void Round3()
        {
            round.Visible = true;
            timer1.Interval = 1;
            label1.Top = 103;
            label2.Top = 103;
            //
            p1 = 0;
            p2 = 0;
            label3.Text = "0";
            label4.Text = "0";
            süre = Convert.ToInt32(textBox1.Text);
            yön = Convert.ToByte(yönr.Next(1, 14));
            top.Left = 350;
            top.Top = 145;

            timer1.Enabled = false;
            timer3.Enabled = false;

            button1.TabIndex = 5;

            label5.ForeColor = Color.Lime;
            label5.Text = textBox1.Text.ToString();

            label1.Top = 103;
            label2.Top = 103;
            timer2.Enabled = true;
            this.Focus();
            //
            timer7.Enabled = true;
            top.Left = 350;
            top.Top = 145;


        }
        byte tur_sayısı=1;

        void Round2()
        {
            round.Visible = true;
            timer1.Interval = 10;
            label1.Top = 103;
            label2.Top = 103;
            //
            
            p1 = 0;
            p2 = 0;
            label3.Text = "0";
            label4.Text = "0";
            süre = Convert.ToInt32(textBox1.Text);
            yön = Convert.ToByte(yönr.Next(1, 14));
            top.Left = 350;
            top.Top = 145;
            
            timer1.Enabled = false;
            timer3.Enabled = false;
            
            button1.TabIndex = 5;

            label5.ForeColor = Color.Lime;
            label5.Text = textBox1.Text.ToString();
            
            label1.Top = 103;
            label2.Top = 103;
            timer2.Enabled = true;
            this.Focus();

            //
            top.Left = 350;
            top.Top = 145;
            timer7.Enabled = true;
        }
        byte t7 = 1;
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (t7 < 3)
            {
                round.Visible = true;
                if (tur_sayısı == 2)
                {
                    round.Text = "Round 2";
                }
                else if (tur_sayısı == 3)
                {
                    round.Text = "Round 3";
                }
            }
            else
            {
                round.Visible = false;
                round.Text = "Round ";
               // t7 = 0;
                timer7.Enabled = false;
                timer4.Enabled = true;
                t7 = 0;
            }
            t7++;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Tuş Bekleniyor";
            button2.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Focus();
            
            button3.Text = "Tuş Bekleniyor";
            button2.Enabled = false;
            button4.Enabled=false;
            button5.Enabled=false;
            button6.Enabled = false;
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
       {           
            SağOyuncuUp = e.KeyCode;
            button3.Text = SağOyuncuUp.ToString();
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Tuş Bekleniyor";
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            SağOyuncuDown = e.KeyCode;
            button4.Text = SağOyuncuDown.ToString();
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            SolOyuncuUp = e.KeyCode;
            button5.Text = SolOyuncuUp.ToString();
            button2.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Tuş Bekleniyor";
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            SolOyuncuDown = e.KeyCode;
            button6.Text = SolOyuncuDown.ToString();
            button2.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }





    }
}

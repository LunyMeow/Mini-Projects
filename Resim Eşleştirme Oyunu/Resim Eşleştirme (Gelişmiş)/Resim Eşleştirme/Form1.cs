using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;


namespace Resim_Eşleştirme
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int yer = 0;
        public bool s1 = false, s2 = false, s3 = false, s4 = false, s5 = false, s6 = false, s7 = false, s8 = false, s9 = false, s10 = false;
        bool s11 = false, s12 = false, s13 = false, s14 = false, s15 = false, s16 = false, s17 = false, s18 = false, s19 = false, s20 = false;
        int deneme = 0;
        int t1 = 0;
       
        bool tıklama1 = false, tıklama2 = false, tıklama3 = false, tıklama4 = false, tıklama5 = false, tıklama6 = false, tıklama7 = false, tıklama8 = false, tıklama9 = false, tıklama10 = false;
        bool tıklama11 = false, tıklama12 = false, tıklama13 = false, tıklama14 = false, tıklama15 = false, tıklama16 = false, tıklama17 = false, tıklama18 = false, tıklama19 = false, tıklama20 = false;
        //int sayacbilmemkac2 = 0;

        void Ding()
        {
            axWindowsMediaPlayer1.URL = "true-and-false-sound-effects-correct-and-wrong-sound-effect-dogru-ve-yanlis-ses_yw5iLv2w (online-audio-converter.com).wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }


        public Form1()
        {
            InitializeComponent();
        }
        byte tıklasınır = 0;
        bool oyunbaşla = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama1==false)
                {
                    tıklasınır++;    
                }
                
                if (tıklasınır < 3)
                {

                    if (seçiliresimler == 1) pictureBox1.Image = Image.FromFile("1-1.png");
                    else if (seçiliresimler == 2) pictureBox1.Image = Image.FromFile("2-1.png");
                    else if (seçiliresimler == 3) pictureBox1.Image = Image.FromFile(@"3-1.png");




                    tıklama1 = true;
                    if (tıklama2 == true)
                    {
                        timer1.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();



                    }
                }
                else
                    resimsil();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1==1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                
                tıklasınır = 0;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                t1 = 0;
                timer1.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                oyunbaşla = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama2 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {

                    if (seçiliresimler == 1) pictureBox2.Image = Image.FromFile("1-1.png");
                    else if (seçiliresimler == 2) pictureBox2.Image = Image.FromFile("2-1.png");
                    else if (seçiliresimler == 3) pictureBox2.Image = Image.FromFile(@"3-1.png");


                    tıklama2 = true;
                    if (tıklama1 == true)
                    {
                        timer1.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();

            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama3 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {

                    if (seçiliresimler == 1) pictureBox3.Image = Image.FromFile("1-2.png");
                    else if (seçiliresimler == 2) pictureBox3.Image = Image.FromFile("2-2.png");
                    else if (seçiliresimler == 3) pictureBox3.Image = Image.FromFile(@"3-2.png");


                    tıklama3 = true;
                    if (tıklama4 == true)
                    {
                        timer2.Enabled = true;
                    }
                    else if (tıklama1 == true || tıklama2 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama4 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox4.Image = Image.FromFile("1-2.png");
                    else if (seçiliresimler == 2) pictureBox4.Image = Image.FromFile("2-2.png");
                    else if (seçiliresimler == 3) pictureBox4.Image = Image.FromFile(@"3-2.png");


                    tıklama4 = true;
                    if (tıklama3 == true)
                    {
                        timer2.Enabled = true;
                    }
                    else if (tıklama1 == true || tıklama2 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama5 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox5.Image = Image.FromFile("1-3.png");
                    else if (seçiliresimler == 2) pictureBox5.Image = Image.FromFile("2-3.png");
                    else if (seçiliresimler == 3) pictureBox5.Image = Image.FromFile(@"3-3.png");


                    tıklama5 = true;
                    if (tıklama6 == true)
                    {
                        timer3.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama1 == true || tıklama2 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama6 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox6.Image = Image.FromFile("1-3.png");
                    else if (seçiliresimler == 2) pictureBox6.Image = Image.FromFile("2-3.png");
                    else if (seçiliresimler == 3) pictureBox6.Image = Image.FromFile(@"3-3.png");



                    tıklama6 = true;
                    if (tıklama5 == true)
                    {
                        timer3.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama1 == true || tıklama2 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama7 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox7.Image = Image.FromFile("1-4.png");
                    else if (seçiliresimler == 2) pictureBox7.Image = Image.FromFile("2-4.png");
                    else if (seçiliresimler == 3) pictureBox7.Image = Image.FromFile(@"3-4.png");



                    tıklama7 = true;
                    if (tıklama8 == true)
                    {
                        timer4.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama1 == true || tıklama2 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama8 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox8.Image = Image.FromFile("1-4.png");
                    else if (seçiliresimler == 2) pictureBox8.Image = Image.FromFile("2-4.png");
                    else if (seçiliresimler == 3) pictureBox8.Image = Image.FromFile(@"3-4.png");



                    tıklama8 = true;
                    if (tıklama7 == true)
                    {
                        timer4.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama1 == true || tıklama2 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                t1 = 0;
                timer2.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                oyunbaşla = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                t1 = 0;
                timer3.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                oyunbaşla = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                t1 = 0;
                timer4.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                oyunbaşla = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                t1 = 0;
                timer5.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                oyunbaşla = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama9 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox9.Image = Image.FromFile("1-5.png");
                    else if (seçiliresimler == 2) pictureBox9.Image = Image.FromFile("2-5.png");
                    else if (seçiliresimler == 3) pictureBox9.Image = Image.FromFile(@"3-5.png");



                    tıklama9 = true;
                    if (tıklama10 == true)
                    {
                        timer5.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama1 == true || tıklama2 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama10 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox10.Image = Image.FromFile("1-5.png");
                    else if (seçiliresimler == 2) pictureBox10.Image = Image.FromFile("2-5.png");
                    else if (seçiliresimler == 3) pictureBox10.Image = Image.FromFile(@"3-5.png");




                    tıklama10 = true;
                    if (tıklama9 == true)
                    {
                        timer5.Enabled = true;
                    }
                    else if (tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama1 == true || tıklama2 == true || tıklama11 == true || tıklama12 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;
                        resimsil();
                    }
                }
                else
                    resimsil();
            }

        }
        //
        //
        //
        //
        void resimsil()
        {
            timer6.Enabled = true;
            oyunbaşla = false;
        }

        void KazanKontrol()
        {
           
            if (pictureBox1.Visible==false&&pictureBox2.Visible==false&&pictureBox3.Visible==false&&pictureBox4.Visible==false&&pictureBox5.Visible==false&&pictureBox6.Visible==false&&pictureBox7.Visible==false&&pictureBox8.Visible==false&&pictureBox9.Visible==false&&pictureBox10.Visible==false&&pictureBox11.Visible==false&&pictureBox12.Visible==false&&pictureBox13.Visible==false&&pictureBox14.Visible==false&&pictureBox15.Visible==false&&pictureBox16.Visible==false&&pictureBox17.Visible==false&&pictureBox18.Visible==false&&pictureBox19.Visible==false&&pictureBox20.Visible==false)
            {
                //MessageBox.Show("");
                timer15.Enabled = true;
                label8.Visible = true;
            }
            


            
        }

        void kontrol()
        {
            yer = rnd.Next(1, 21);
        }

        public byte sürekontrol = 1;
        string sesyolu="";
        
        SoundPlayer menüsesi;
        void MenüSesi()
        {
            if (sesyolu!="")
            {
                axWindowsMediaPlayer2.URL = sesyolu;
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            
        }


        
        void KartSesi(bool ses)
        {
            if (ses)
            {
                axWindowsMediaPlayer1.URL = "Iron_Club_Hits_Golf_Ball (mp3cut.net).wav";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Height = 0;
            pictureBox21.Image = Image.FromFile("33-339612_media-player-play-button-clipart.png");
            axWindowsMediaPlayer1.settings.volume = 100;
            axWindowsMediaPlayer2.settings.volume = 100;
            
            //tıklasınır = 4;
            panel2.Height = 1;
            panel2.Width = 1;
            if (sürekontrol == 1)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                //timer12.Enabled = true;
            }
            
            //timer12.Enabled = true;
            
            

        }

       

        public void yüklenme()
        {

            deneme = 0;
            label2.Text = deneme.ToString();


            int[] yerler = new int[21];


            while (s1 != true || s2 != true || s3 != true || s4 != true || s5 != true || s6 != true || s7 != true || s8 != true || s9 != true || s10 != true || s11 != true || s12 != true || s13 != true || s14 != true || s15 != true || s16 != true || s17 != true || s18 != true || s19 != true || s20 != true)
            {
            aaa:
                foreach (int item in yerler)
                {
                    if (yer == item)
                    {
                        kontrol();
                        goto aaa;
                    }
                }

                #region picture1
                if (yer == 1)
                {
                    yerler[0] = 1;
                    if (s1 == false)
                    {
                        pictureBox1.Left = 12;
                        pictureBox1.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox1.Left = 12;
                        pictureBox1.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox1.Left = 151;
                        pictureBox1.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox1.Left = 151;
                        pictureBox1.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox1.Left = 290;
                        pictureBox1.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox1.Left = 290;
                        pictureBox1.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox1.Left = 429;
                        pictureBox1.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox1.Left = 429;
                        pictureBox1.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox1.Left = 568;
                        pictureBox1.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox1.Left = 568;
                        pictureBox1.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox1.Left = 12;
                        pictureBox1.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox1.Left = 12;
                        pictureBox1.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox1.Left = 151;
                        pictureBox1.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox1.Left = 151;
                        pictureBox1.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox1.Left = 290;
                        pictureBox1.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox1.Left = 290;
                        pictureBox1.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox1.Left = 429;
                        pictureBox1.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox1.Left = 429;
                        pictureBox1.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox1.Left = 568;
                        pictureBox1.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox1.Left = 568;
                        pictureBox1.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture2
                if (yer == 2)
                {
                    yerler[1] = 2;
                    if (s1 == false)
                    {
                        pictureBox2.Left = 12;
                        pictureBox2.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox2.Left = 12;
                        pictureBox2.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox2.Left = 151;
                        pictureBox2.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox2.Left = 151;
                        pictureBox2.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox2.Left = 290;
                        pictureBox2.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox2.Left = 290;
                        pictureBox2.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox2.Left = 429;
                        pictureBox2.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox2.Left = 429;
                        pictureBox2.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox2.Left = 568;
                        pictureBox2.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox2.Left = 568;
                        pictureBox2.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox2.Left = 12;
                        pictureBox2.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox2.Left = 12;
                        pictureBox2.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox2.Left = 151;
                        pictureBox2.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox2.Left = 151;
                        pictureBox2.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox2.Left = 290;
                        pictureBox2.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox2.Left = 290;
                        pictureBox2.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox2.Left = 429;
                        pictureBox2.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox2.Left = 429;
                        pictureBox2.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox2.Left = 568;
                        pictureBox2.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox2.Left = 568;
                        pictureBox2.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture3
                if (yer == 3)
                {
                    yerler[2] = 3;
                    if (s1 == false)
                    {
                        pictureBox3.Left = 12;
                        pictureBox3.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox3.Left = 12;
                        pictureBox3.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox3.Left = 151;
                        pictureBox3.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox3.Left = 151;
                        pictureBox3.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox3.Left = 290;
                        pictureBox3.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox3.Left = 290;
                        pictureBox3.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox3.Left = 429;
                        pictureBox3.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox3.Left = 429;
                        pictureBox3.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox3.Left = 568;
                        pictureBox3.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox3.Left = 568;
                        pictureBox3.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox3.Left = 12;
                        pictureBox3.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox3.Left = 12;
                        pictureBox3.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox3.Left = 151;
                        pictureBox3.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox3.Left = 151;
                        pictureBox3.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox3.Left = 290;
                        pictureBox3.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox3.Left = 290;
                        pictureBox3.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox3.Left = 429;
                        pictureBox3.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox3.Left = 429;
                        pictureBox3.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox3.Left = 568;
                        pictureBox3.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox3.Left = 568;
                        pictureBox3.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture4
                if (yer == 4)
                {
                    yerler[3] = 4;
                    if (s1 == false)
                    {
                        pictureBox4.Left = 12;
                        pictureBox4.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox4.Left = 12;
                        pictureBox4.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox4.Left = 151;
                        pictureBox4.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox4.Left = 151;
                        pictureBox4.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox4.Left = 290;
                        pictureBox4.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox4.Left = 290;
                        pictureBox4.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox4.Left = 429;
                        pictureBox4.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox4.Left = 429;
                        pictureBox4.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox4.Left = 568;
                        pictureBox4.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox4.Left = 568;
                        pictureBox4.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox4.Left = 12;
                        pictureBox4.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox4.Left = 12;
                        pictureBox4.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox4.Left = 151;
                        pictureBox4.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox4.Left = 151;
                        pictureBox4.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox4.Left = 290;
                        pictureBox4.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox4.Left = 290;
                        pictureBox4.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox4.Left = 429;
                        pictureBox4.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox4.Left = 429;
                        pictureBox4.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox4.Left = 568;
                        pictureBox4.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox4.Left = 568;
                        pictureBox4.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture5
                if (yer == 5)
                {
                    yerler[4] = 5;
                    if (s1 == false)
                    {
                        pictureBox5.Left = 12;
                        pictureBox5.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox5.Left = 12;
                        pictureBox5.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox5.Left = 151;
                        pictureBox5.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox5.Left = 151;
                        pictureBox5.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox5.Left = 290;
                        pictureBox5.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox5.Left = 290;
                        pictureBox5.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox5.Left = 429;
                        pictureBox5.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox5.Left = 429;
                        pictureBox5.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox5.Left = 568;
                        pictureBox5.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox5.Left = 568;
                        pictureBox5.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox5.Left = 12;
                        pictureBox5.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox5.Left = 12;
                        pictureBox5.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox5.Left = 151;
                        pictureBox5.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox5.Left = 151;
                        pictureBox5.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox5.Left = 290;
                        pictureBox5.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox5.Left = 290;
                        pictureBox5.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox5.Left = 429;
                        pictureBox5.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox5.Left = 429;
                        pictureBox5.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox5.Left = 568;
                        pictureBox5.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox5.Left = 568;
                        pictureBox5.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture6
                if (yer == 6)
                {
                    yerler[5] = 6;
                    if (s1 == false)
                    {
                        pictureBox6.Left = 12;
                        pictureBox6.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox6.Left = 12;
                        pictureBox6.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox6.Left = 151;
                        pictureBox6.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox6.Left = 151;
                        pictureBox6.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox6.Left = 290;
                        pictureBox6.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox6.Left = 290;
                        pictureBox6.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox6.Left = 429;
                        pictureBox6.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox6.Left = 429;
                        pictureBox6.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox6.Left = 568;
                        pictureBox6.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox6.Left = 568;
                        pictureBox6.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox6.Left = 12;
                        pictureBox6.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox6.Left = 12;
                        pictureBox6.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox6.Left = 151;
                        pictureBox6.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox6.Left = 151;
                        pictureBox6.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox6.Left = 290;
                        pictureBox6.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox6.Left = 290;
                        pictureBox6.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox6.Left = 429;
                        pictureBox6.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox6.Left = 429;
                        pictureBox6.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox6.Left = 568;
                        pictureBox6.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox6.Left = 568;
                        pictureBox6.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture7
                if (yer == 7)
                {
                    yerler[6] = 7;
                    if (s1 == false)
                    {
                        pictureBox7.Left = 12;
                        pictureBox7.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox7.Left = 12;
                        pictureBox7.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox7.Left = 151;
                        pictureBox7.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox7.Left = 151;
                        pictureBox7.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox7.Left = 290;
                        pictureBox7.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox7.Left = 290;
                        pictureBox7.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox7.Left = 429;
                        pictureBox7.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox7.Left = 429;
                        pictureBox7.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox7.Left = 568;
                        pictureBox7.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox7.Left = 568;
                        pictureBox7.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox7.Left = 12;
                        pictureBox7.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox7.Left = 12;
                        pictureBox7.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox7.Left = 151;
                        pictureBox7.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox7.Left = 151;
                        pictureBox7.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox7.Left = 290;
                        pictureBox7.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox7.Left = 290;
                        pictureBox7.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox7.Left = 429;
                        pictureBox7.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox7.Left = 429;
                        pictureBox7.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox7.Left = 568;
                        pictureBox7.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox7.Left = 568;
                        pictureBox7.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture8
                if (yer == 8)
                {
                    yerler[7] = 8;
                    if (s1 == false)
                    {
                        pictureBox8.Left = 12;
                        pictureBox8.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox8.Left = 12;
                        pictureBox8.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox8.Left = 151;
                        pictureBox8.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox8.Left = 151;
                        pictureBox8.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox8.Left = 290;
                        pictureBox8.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox8.Left = 290;
                        pictureBox8.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox8.Left = 429;
                        pictureBox8.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox8.Left = 429;
                        pictureBox8.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox8.Left = 568;
                        pictureBox8.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox8.Left = 568;
                        pictureBox8.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox8.Left = 12;
                        pictureBox8.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox8.Left = 12;
                        pictureBox8.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox8.Left = 151;
                        pictureBox8.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox8.Left = 151;
                        pictureBox8.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox8.Left = 290;
                        pictureBox8.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox8.Left = 290;
                        pictureBox8.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox8.Left = 429;
                        pictureBox8.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox8.Left = 429;
                        pictureBox8.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox8.Left = 568;
                        pictureBox8.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox8.Left = 568;
                        pictureBox8.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture9
                if (yer == 9)
                {
                    yerler[8] = 9;
                    if (s1 == false)
                    {
                        pictureBox9.Left = 12;
                        pictureBox9.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox9.Left = 12;
                        pictureBox9.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox9.Left = 151;
                        pictureBox9.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox9.Left = 151;
                        pictureBox9.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox9.Left = 290;
                        pictureBox9.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox9.Left = 290;
                        pictureBox9.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox9.Left = 429;
                        pictureBox9.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox9.Left = 429;
                        pictureBox9.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox9.Left = 568;
                        pictureBox9.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox9.Left = 568;
                        pictureBox9.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox9.Left = 12;
                        pictureBox9.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox9.Left = 12;
                        pictureBox9.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox9.Left = 151;
                        pictureBox9.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox9.Left = 151;
                        pictureBox9.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox9.Left = 290;
                        pictureBox9.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox9.Left = 290;
                        pictureBox9.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox9.Left = 429;
                        pictureBox9.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox9.Left = 429;
                        pictureBox9.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox9.Left = 568;
                        pictureBox9.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox9.Left = 568;
                        pictureBox9.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture10
                if (yer == 10)
                {
                    yerler[9] = 10;
                    if (s1 == false)
                    {
                        pictureBox10.Left = 12;
                        pictureBox10.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox10.Left = 12;
                        pictureBox10.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox10.Left = 151;
                        pictureBox10.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox10.Left = 151;
                        pictureBox10.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox10.Left = 290;
                        pictureBox10.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox10.Left = 290;
                        pictureBox10.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox10.Left = 429;
                        pictureBox10.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox10.Left = 429;
                        pictureBox10.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox10.Left = 568;
                        pictureBox10.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox10.Left = 568;
                        pictureBox10.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox10.Left = 12;
                        pictureBox10.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox10.Left = 12;
                        pictureBox10.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox10.Left = 151;
                        pictureBox10.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox10.Left = 151;
                        pictureBox10.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox10.Left = 290;
                        pictureBox10.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox10.Left = 290;
                        pictureBox10.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox10.Left = 429;
                        pictureBox10.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox10.Left = 429;
                        pictureBox10.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox10.Left = 568;
                        pictureBox10.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox10.Left = 568;
                        pictureBox10.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture11
                if (yer == 11)
                {
                    yerler[10] = 11;
                    if (s1 == false)
                    {
                        pictureBox11.Left = 12;
                        pictureBox11.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox11.Left = 12;
                        pictureBox11.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox11.Left = 151;
                        pictureBox11.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox11.Left = 151;
                        pictureBox11.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox11.Left = 290;
                        pictureBox11.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox11.Left = 290;
                        pictureBox11.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox11.Left = 429;
                        pictureBox11.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox11.Left = 429;
                        pictureBox11.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox11.Left = 568;
                        pictureBox11.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox11.Left = 568;
                        pictureBox11.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox11.Left = 12;
                        pictureBox11.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox11.Left = 12;
                        pictureBox11.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox11.Left = 151;
                        pictureBox11.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox11.Left = 151;
                        pictureBox11.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox11.Left = 290;
                        pictureBox11.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox11.Left = 290;
                        pictureBox11.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox11.Left = 429;
                        pictureBox11.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox11.Left = 429;
                        pictureBox11.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox11.Left = 568;
                        pictureBox11.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox11.Left = 568;
                        pictureBox11.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture12
                if (yer == 12)
                {
                    yerler[11] = 12;
                    if (s1 == false)
                    {
                        pictureBox12.Left = 12;
                        pictureBox12.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox12.Left = 12;
                        pictureBox12.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox12.Left = 151;
                        pictureBox12.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox12.Left = 151;
                        pictureBox12.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox12.Left = 290;
                        pictureBox12.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox12.Left = 290;
                        pictureBox12.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox12.Left = 429;
                        pictureBox12.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox12.Left = 429;
                        pictureBox12.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox12.Left = 568;
                        pictureBox12.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox12.Left = 568;
                        pictureBox12.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox12.Left = 12;
                        pictureBox12.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox12.Left = 12;
                        pictureBox12.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox12.Left = 151;
                        pictureBox12.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox12.Left = 151;
                        pictureBox12.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox12.Left = 290;
                        pictureBox12.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox12.Left = 290;
                        pictureBox12.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox12.Left = 429;
                        pictureBox12.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox12.Left = 429;
                        pictureBox12.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox12.Left = 568;
                        pictureBox12.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox12.Left = 568;
                        pictureBox12.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture13
                if (yer == 13)
                {
                    yerler[12] = 13;
                    if (s1 == false)
                    {
                        pictureBox13.Left = 12;
                        pictureBox13.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox13.Left = 12;
                        pictureBox13.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox13.Left = 151;
                        pictureBox13.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox13.Left = 151;
                        pictureBox13.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox13.Left = 290;
                        pictureBox13.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox13.Left = 290;
                        pictureBox13.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox13.Left = 429;
                        pictureBox13.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox13.Left = 429;
                        pictureBox13.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox13.Left = 568;
                        pictureBox13.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox13.Left = 568;
                        pictureBox13.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox13.Left = 12;
                        pictureBox13.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox13.Left = 12;
                        pictureBox13.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox13.Left = 151;
                        pictureBox13.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox13.Left = 151;
                        pictureBox13.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox13.Left = 290;
                        pictureBox13.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox13.Left = 290;
                        pictureBox13.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox13.Left = 429;
                        pictureBox13.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox13.Left = 429;
                        pictureBox13.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox13.Left = 568;
                        pictureBox13.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox13.Left = 568;
                        pictureBox13.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture14
                if (yer == 14)
                {
                    yerler[13] = 14;
                    if (s1 == false)
                    {
                        pictureBox14.Left = 12;
                        pictureBox14.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox14.Left = 12;
                        pictureBox14.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox14.Left = 151;
                        pictureBox14.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox14.Left = 151;
                        pictureBox14.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox14.Left = 290;
                        pictureBox14.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox14.Left = 290;
                        pictureBox14.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox14.Left = 429;
                        pictureBox14.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox14.Left = 429;
                        pictureBox14.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox14.Left = 568;
                        pictureBox14.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox14.Left = 568;
                        pictureBox14.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox14.Left = 12;
                        pictureBox14.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox14.Left = 12;
                        pictureBox14.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox14.Left = 151;
                        pictureBox14.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox14.Left = 151;
                        pictureBox14.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox14.Left = 290;
                        pictureBox14.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox14.Left = 290;
                        pictureBox14.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox14.Left = 429;
                        pictureBox14.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox14.Left = 429;
                        pictureBox14.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox14.Left = 568;
                        pictureBox14.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox14.Left = 568;
                        pictureBox14.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture15
                if (yer == 15)
                {
                    yerler[14] = 15;
                    if (s1 == false)
                    {
                        pictureBox15.Left = 12;
                        pictureBox15.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox15.Left = 12;
                        pictureBox15.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox15.Left = 151;
                        pictureBox15.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox15.Left = 151;
                        pictureBox15.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox15.Left = 290;
                        pictureBox15.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox15.Left = 290;
                        pictureBox15.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox15.Left = 429;
                        pictureBox15.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox15.Left = 429;
                        pictureBox15.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox15.Left = 568;
                        pictureBox15.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox15.Left = 568;
                        pictureBox15.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox15.Left = 12;
                        pictureBox15.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox15.Left = 12;
                        pictureBox15.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox15.Left = 151;
                        pictureBox15.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox15.Left = 151;
                        pictureBox15.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox15.Left = 290;
                        pictureBox15.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox15.Left = 290;
                        pictureBox15.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox15.Left = 429;
                        pictureBox15.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox15.Left = 429;
                        pictureBox15.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox15.Left = 568;
                        pictureBox15.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox15.Left = 568;
                        pictureBox15.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture16
                if (yer == 16)
                {
                    yerler[15] = 16;
                    if (s1 == false)
                    {
                        pictureBox16.Left = 12;
                        pictureBox16.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox16.Left = 12;
                        pictureBox16.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox16.Left = 151;
                        pictureBox16.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox16.Left = 151;
                        pictureBox16.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox16.Left = 290;
                        pictureBox16.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox16.Left = 290;
                        pictureBox16.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox16.Left = 429;
                        pictureBox16.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox16.Left = 429;
                        pictureBox16.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox16.Left = 568;
                        pictureBox16.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox16.Left = 568;
                        pictureBox16.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox16.Left = 12;
                        pictureBox16.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox16.Left = 12;
                        pictureBox16.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox16.Left = 151;
                        pictureBox16.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox16.Left = 151;
                        pictureBox16.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox16.Left = 290;
                        pictureBox16.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox16.Left = 290;
                        pictureBox16.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox16.Left = 429;
                        pictureBox16.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox16.Left = 429;
                        pictureBox16.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox16.Left = 568;
                        pictureBox16.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox16.Left = 568;
                        pictureBox16.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture17
                if (yer == 17)
                {
                    yerler[16] = 17;
                    if (s1 == false)
                    {
                        pictureBox17.Left = 12;
                        pictureBox17.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox17.Left = 12;
                        pictureBox17.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox17.Left = 151;
                        pictureBox17.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox17.Left = 151;
                        pictureBox17.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox17.Left = 290;
                        pictureBox17.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox17.Left = 290;
                        pictureBox17.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox17.Left = 429;
                        pictureBox17.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox17.Left = 429;
                        pictureBox17.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox17.Left = 568;
                        pictureBox17.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox17.Left = 568;
                        pictureBox17.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox17.Left = 12;
                        pictureBox17.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox17.Left = 12;
                        pictureBox17.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox17.Left = 151;
                        pictureBox17.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox17.Left = 151;
                        pictureBox17.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox17.Left = 290;
                        pictureBox17.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox17.Left = 290;
                        pictureBox17.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox17.Left = 429;
                        pictureBox17.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox17.Left = 429;
                        pictureBox17.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox17.Left = 568;
                        pictureBox17.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox17.Left = 568;
                        pictureBox17.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture18
                if (yer == 18)
                {
                    yerler[17] = 18;
                    if (s1 == false)
                    {
                        pictureBox18.Left = 12;
                        pictureBox18.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox18.Left = 12;
                        pictureBox18.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox18.Left = 151;
                        pictureBox18.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox18.Left = 151;
                        pictureBox18.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox18.Left = 290;
                        pictureBox18.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox18.Left = 290;
                        pictureBox18.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox18.Left = 429;
                        pictureBox18.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox18.Left = 429;
                        pictureBox18.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox18.Left = 568;
                        pictureBox18.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox18.Left = 568;
                        pictureBox18.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox18.Left = 12;
                        pictureBox18.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox18.Left = 12;
                        pictureBox18.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox18.Left = 151;
                        pictureBox18.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox18.Left = 151;
                        pictureBox18.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox18.Left = 290;
                        pictureBox18.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox18.Left = 290;
                        pictureBox18.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox18.Left = 429;
                        pictureBox18.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox18.Left = 429;
                        pictureBox18.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox18.Left = 568;
                        pictureBox18.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox18.Left = 568;
                        pictureBox18.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture19
                if (yer == 19)
                {
                    yerler[18] = 19;
                    if (s1 == false)
                    {
                        pictureBox19.Left = 12;
                        pictureBox19.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox19.Left = 12;
                        pictureBox19.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox19.Left = 151;
                        pictureBox19.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox19.Left = 151;
                        pictureBox19.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox19.Left = 290;
                        pictureBox19.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox19.Left = 290;
                        pictureBox19.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox19.Left = 429;
                        pictureBox19.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox19.Left = 429;
                        pictureBox19.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox19.Left = 568;
                        pictureBox19.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox19.Left = 568;
                        pictureBox19.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox19.Left = 12;
                        pictureBox19.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox19.Left = 12;
                        pictureBox19.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox19.Left = 151;
                        pictureBox19.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox19.Left = 151;
                        pictureBox19.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox19.Left = 290;
                        pictureBox19.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox19.Left = 290;
                        pictureBox19.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox19.Left = 429;
                        pictureBox19.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox19.Left = 429;
                        pictureBox19.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox19.Left = 568;
                        pictureBox19.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox19.Left = 568;
                        pictureBox19.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                #region picture20
                if (yer == 20)
                {
                    yerler[19] = 20;
                    if (s1 == false)
                    {
                        pictureBox20.Left = 12;
                        pictureBox20.Top = 9;
                        s1 = true;
                    }
                    else if (s2 == false)
                    {
                        pictureBox20.Left = 12;
                        pictureBox20.Top = 142;
                        s2 = true;
                    }
                    else if (s3 == false)
                    {
                        pictureBox20.Left = 151;
                        pictureBox20.Top = 9;
                        s3 = true;
                    }
                    else if (s4 == false)
                    {
                        pictureBox20.Left = 151;
                        pictureBox20.Top = 142;
                        s4 = true;
                    }
                    else if (s5 == false)
                    {
                        pictureBox20.Left = 290;
                        pictureBox20.Top = 9;
                        s5 = true;
                    }
                    else if (s6 == false)
                    {
                        pictureBox20.Left = 290;
                        pictureBox20.Top = 142;
                        s6 = true;
                    }
                    else if (s7 == false)
                    {
                        pictureBox20.Left = 429;
                        pictureBox20.Top = 9;
                        s7 = true;
                    }
                    else if (s8 == false)
                    {
                        pictureBox20.Left = 429;
                        pictureBox20.Top = 142;
                        s8 = true;
                    }
                    else if (s9 == false)
                    {
                        pictureBox20.Left = 568;
                        pictureBox20.Top = 9;
                        s9 = true;
                    }
                    else if (s10 == false)
                    {
                        pictureBox20.Left = 568;
                        pictureBox20.Top = 142;
                        s10 = true;
                    }
                    //

                    else if (s11 == false)
                    {
                        pictureBox20.Left = 12;
                        pictureBox20.Top = 275;
                        s11 = true;
                    }
                    else if (s12 == false)
                    {
                        pictureBox20.Left = 12;
                        pictureBox20.Top = 408;
                        s12 = true;
                    }
                    else if (s13 == false)
                    {
                        pictureBox20.Left = 151;
                        pictureBox20.Top = 275;
                        s13 = true;
                    }
                    else if (s14 == false)
                    {
                        pictureBox20.Left = 151;
                        pictureBox20.Top = 408;
                        s14 = true;
                    }
                    else if (s15 == false)
                    {
                        pictureBox20.Left = 290;
                        pictureBox20.Top = 275;
                        s15 = true;
                    }
                    else if (s16 == false)
                    {
                        pictureBox20.Left = 290;
                        pictureBox20.Top = 408;
                        s16 = true;
                    }
                    else if (s17 == false)
                    {
                        pictureBox20.Left = 429;
                        pictureBox20.Top = 275;
                        s17 = true;
                    }
                    else if (s18 == false)
                    {
                        pictureBox20.Left = 429;
                        pictureBox20.Top = 408;
                        s18 = true;
                    }
                    else if (s19 == false)
                    {
                        pictureBox20.Left = 568;
                        pictureBox20.Top = 275;
                        s19 = true;
                    }
                    else if (s20 == false)
                    {
                        pictureBox20.Left = 568;
                        pictureBox20.Top = 408;
                        s20 = true;
                    }


                }
                #endregion

                
            }//döngünün sonu
            oyunbaşla = true;
           
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            yüklenme();
            this.Hide();
            resimsil();

        }

        public int seçiliresimler = 3;
        private void resimDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            yüklenme();
            this.Hide();
            resimsil();
        }



        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);

                if (tıklama11 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox11.Image = Image.FromFile("1-6.png");
                    else if (seçiliresimler == 2) pictureBox11.Image = Image.FromFile("2-6.png");
                    else if (seçiliresimler == 3) pictureBox11.Image = Image.FromFile(@"3-6.png");



                    tıklama11 = true;
                    if (tıklama12 == true)
                    {
                        timer7.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false; tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }//

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama12 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox12.Image = Image.FromFile("1-6.png");
                    else if (seçiliresimler == 2) pictureBox12.Image = Image.FromFile("2-6.png");
                    else if (seçiliresimler == 3) pictureBox12.Image = Image.FromFile(@"3-6.png");



                    tıklama12 = true;
                    if (tıklama11 == true)
                    {
                        timer7.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false; tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }//

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama13 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {

                    if (seçiliresimler == 1) pictureBox13.Image = Image.FromFile("1-7.png");
                    else if (seçiliresimler == 2) pictureBox13.Image = Image.FromFile("2-7.png");
                    else if (seçiliresimler == 3) pictureBox13.Image = Image.FromFile(@"3-7.jpg");


                    tıklama13 = true;
                    if (tıklama14 == true)
                    {
                        timer8.Enabled = true;
                    }
                    else if (tıklama1 == true || tıklama2 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama11 == true || tıklama12 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false; tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }

        }//

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama14 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox14.Image = Image.FromFile("1-7.png");
                    else if (seçiliresimler == 2) pictureBox14.Image = Image.FromFile("2-7.png");
                    else if (seçiliresimler == 3) pictureBox14.Image = Image.FromFile(@"3-7.jpg");

                    tıklama14 = true;
                    if (tıklama13 == true)
                    {
                        timer8.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama12 == true || tıklama11 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();



                    }
                }
                else
                    resimsil();
            }
        }//

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama15 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox15.Image = Image.FromFile("1-8.png");
                    else if (seçiliresimler == 2) pictureBox15.Image = Image.FromFile("2-8.png");
                    else if (seçiliresimler == 3) pictureBox15.Image = Image.FromFile(@"3-8.jpg");



                    tıklama15 = true;
                    if (tıklama16 == true)
                    {
                        timer9.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama11 == true || tıklama12 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }//

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama16 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox16.Image = Image.FromFile("1-8.png");
                    else if (seçiliresimler == 2) pictureBox16.Image = Image.FromFile("2-8.png");
                    else if (seçiliresimler == 3) pictureBox16.Image = Image.FromFile(@"3-8.jpg");


                    tıklama16 = true;
                    if (tıklama15 == true)
                    {
                        timer9.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama11 == true || tıklama12 == true || tıklama17 == true || tıklama18 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }//

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama17 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox17.Image = Image.FromFile("1-9.png");
                    else if (seçiliresimler == 2) pictureBox17.Image = Image.FromFile("2-9.png");
                    else if (seçiliresimler == 3) pictureBox17.Image = Image.FromFile(@"3-9.jpg");



                    tıklama17 = true;
                    if (tıklama18 == true)
                    {
                        timer10.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama11 == true || tıklama12 == true || tıklama15 == true || tıklama16 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }

        }//

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama18 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox18.Image = Image.FromFile("1-9.png");
                    else if (seçiliresimler == 2) pictureBox18.Image = Image.FromFile("2-9.png");
                    else if (seçiliresimler == 3) pictureBox18.Image = Image.FromFile(@"3-9.jpg");

                    tıklama18 = true;
                    if (tıklama17 == true)
                    {
                        timer10.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama11 == true || tıklama12 == true || tıklama15 == true || tıklama16 == true || tıklama19 == true || tıklama20 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();


                    }
                }
                else
                    resimsil();
            }
        }//

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama19 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox19.Image = Image.FromFile("1-10.png");
                    else if (seçiliresimler == 2) pictureBox19.Image = Image.FromFile("2-10.png");
                    else if (seçiliresimler == 3) pictureBox19.Image = Image.FromFile(@"3-10.png");



                    tıklama19 = true;
                    if (tıklama20 == true)
                    {
                        timer11.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama11 == true || tıklama12 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }

        }//

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (oyunbaşla)
            {
                KartSesi(true);
                if (tıklama20 == false)
                {
                    tıklasınır++;
                }
                if (tıklasınır < 3)
                {
                    if (seçiliresimler == 1) pictureBox20.Image = Image.FromFile("1-10.png");
                    else if (seçiliresimler == 2) pictureBox20.Image = Image.FromFile("2-10.png");
                    else if (seçiliresimler == 3) pictureBox20.Image = Image.FromFile(@"3-10.png");



                    tıklama20 = true;
                    if (tıklama19 == true)
                    {
                        timer11.Enabled = true;
                    }
                    else if (tıklama2 == true || tıklama1 == true || tıklama3 == true || tıklama4 == true || tıklama5 == true || tıklama6 == true || tıklama7 == true || tıklama8 == true || tıklama9 == true || tıklama10 == true || tıklama13 == true || tıklama14 == true || tıklama11 == true || tıklama12 == true || tıklama15 == true || tıklama16 == true || tıklama17 == true || tıklama18 == true)
                    {
                        deneme++;
                        label2.Text = deneme.ToString();
                        tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                        resimsil();

                    }
                }
                else
                    resimsil();
            }
        }//

        /* *
         * 
         * */
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır=0;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                t1 = 0;
                timer7.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                oyunbaşla = true;
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                t1 = 0;
                timer8.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                oyunbaşla = true;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                t1 = 0;
                timer9.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                oyunbaşla = true;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                t1 = 0;
                timer10.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                oyunbaşla = true;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (t1 == 1)
            {
                Ding();
            }
            oyunbaşla = false;
            t1++;
            if (t1 >= 7)
            {
                tıklasınır = 0;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                t1 = 0;
                timer11.Enabled = false;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false;/* */tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                oyunbaşla = true;
            }
        }

        private void yapımcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public byte a = 0;
        public int saniye = 60;
        
        
        int dakika=0;
        public byte seçilisüre=2;
        
        private void timer12_Tick(object sender, EventArgs e)
        {
            KazanKontrol();
            if (a == 0)
            {
                //Form2 we = new Form2();
                
                dakika = seçilisüre;
                a++;
            }

            saniye--;
            label5.Text = saniye.ToString();
            label4.Text = (dakika).ToString();
            if (saniye < 0)
            {
                dakika--;
                label4.Text = dakika.ToString();
                if (dakika >= 0)
                {
                    saniye = 59;
                }
            }
            
            
            if (label4.Text == "-1")
            {

                timer12.Enabled=false;
                label4.Text = "0";
                label5.Text = "0";
                SüreBitti();
                           
            }
            if (dakika<=0&&saniye<10)
            {
               
                
            }



        }

        void SüreBitti()
        {
            label8.Visible = true;
            oyunbaşla = false;
            if (pictureBox1.Visible==true)
            {
                pictureBox1.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox3.Visible == true)
            {
                pictureBox3.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox4.Visible == true)
            {
                pictureBox4.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox5.Visible == true)
            {
                pictureBox5.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox6.Visible == true)
            {
                pictureBox6.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox7.Visible == true)
            {
                pictureBox7.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox8.Visible == true)
            {
                pictureBox8.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox9.Visible == true)
            {
                pictureBox9.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox10.Visible == true)
            {
                pictureBox10.Image = Image.FromFile("AdsızK.png");
            }

            //

            if (pictureBox11.Visible == true)
            {
                pictureBox11.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox12.Visible == true)
            {
                pictureBox12.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox13.Visible == true)
            {
                pictureBox13.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox14.Visible == true)
            {
                pictureBox14.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox15.Visible == true)
            {
                pictureBox15.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox16.Visible == true)
            {
                pictureBox16.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox17.Visible == true)
            {
                pictureBox17.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox18.Visible == true)
            {
                pictureBox18.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox19.Visible == true)
            {
                pictureBox19.Image = Image.FromFile("AdsızK.png");
            }
            if (pictureBox20.Visible == true)
            {
                pictureBox20.Image = Image.FromFile("AdsızK.png");
            }
            timer12.Enabled = false;

        }





        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        
        public byte sayaç2 = 0;
        private void timer13_Tick(object sender, EventArgs e)
        {
            
            if (sayaç2<10)
            {
                #region resim1
                pictureBox1.Visible = true;
                if (seçiliresimler == 1) pictureBox1.Image = Image.FromFile("1-1.png");
                else if (seçiliresimler == 2) pictureBox1.Image = Image.FromFile("2-1.png");
                else if (seçiliresimler == 3) pictureBox1.Image = Image.FromFile(@"3-1.png");

                #endregion
                #region resim2
                pictureBox2.Visible = true;
                if (seçiliresimler == 1) pictureBox2.Image = Image.FromFile("1-1.png");
                else if (seçiliresimler == 2) pictureBox2.Image = Image.FromFile("2-1.png");
                else if (seçiliresimler == 3) pictureBox2.Image = Image.FromFile(@"3-1.png");

                #endregion
                #region resim3
                pictureBox3.Visible = true;
                if (seçiliresimler == 1) pictureBox3.Image = Image.FromFile("1-2.png");
                else if (seçiliresimler == 2) pictureBox3.Image = Image.FromFile("2-2.png");
                else if (seçiliresimler == 3) pictureBox3.Image = Image.FromFile(@"3-2.png");

                #endregion
                #region resim4
                pictureBox4.Visible = true;
                if (seçiliresimler == 1) pictureBox4.Image = Image.FromFile("1-2.png");
                else if (seçiliresimler == 2) pictureBox4.Image = Image.FromFile("2-2.png");
                else if (seçiliresimler == 3) pictureBox4.Image = Image.FromFile(@"3-2.png");

                #endregion
                #region resim5
                pictureBox5.Visible = true;
                if (seçiliresimler == 1) pictureBox5.Image = Image.FromFile("1-3.png");
                else if (seçiliresimler == 2) pictureBox5.Image = Image.FromFile("2-3.png");
                else if (seçiliresimler == 3) pictureBox5.Image = Image.FromFile(@"3-3.png");

                #endregion
                #region resim6
                pictureBox6.Visible = true;
                if (seçiliresimler == 1) pictureBox6.Image = Image.FromFile("1-3.png");
                else if (seçiliresimler == 2) pictureBox6.Image = Image.FromFile("2-3.png");
                else if (seçiliresimler == 3) pictureBox6.Image = Image.FromFile(@"3-3.png");

                #endregion
                #region resim7
                pictureBox7.Visible = true;
                if (seçiliresimler == 1) pictureBox7.Image = Image.FromFile("1-4.png");
                else if (seçiliresimler == 2) pictureBox7.Image = Image.FromFile("2-4.png");
                else if (seçiliresimler == 3) pictureBox7.Image = Image.FromFile(@"3-4.png");

                #endregion
                #region resim8
                pictureBox8.Visible = true;
                if (seçiliresimler == 1) pictureBox8.Image = Image.FromFile("1-4.png");
                else if (seçiliresimler == 2) pictureBox8.Image = Image.FromFile("2-4.png");
                else if (seçiliresimler == 3) pictureBox8.Image = Image.FromFile(@"3-4.png");

                #endregion
                #region resim9
                pictureBox9.Visible = true;
                if (seçiliresimler == 1) pictureBox9.Image = Image.FromFile("1-5.png");
                else if (seçiliresimler == 2) pictureBox9.Image = Image.FromFile("2-5.png");
                else if (seçiliresimler == 3) pictureBox9.Image = Image.FromFile(@"3-5.png");

                #endregion
                #region resim10
                pictureBox10.Visible = true;
                if (seçiliresimler == 1) pictureBox10.Image = Image.FromFile("1-5.png");
                else if (seçiliresimler == 2) pictureBox10.Image = Image.FromFile("2-5.png");
                else if (seçiliresimler == 3) pictureBox10.Image = Image.FromFile(@"3-5.png");

                #endregion
                //
                #region resim11
                pictureBox11.Visible = true;
                if (seçiliresimler == 1) pictureBox11.Image = Image.FromFile("1-6.png");
                else if (seçiliresimler == 2) pictureBox11.Image = Image.FromFile("2-6.png");
                else if (seçiliresimler == 3) pictureBox11.Image = Image.FromFile(@"3-6.png");

                #endregion
                #region resim12
                pictureBox12.Visible = true;
                if (seçiliresimler == 1) pictureBox12.Image = Image.FromFile("1-6.png");
                else if (seçiliresimler == 2) pictureBox12.Image = Image.FromFile("2-6.png");
                else if (seçiliresimler == 3) pictureBox12.Image = Image.FromFile(@"3-6.png");

                #endregion
                #region resim13
                pictureBox13.Visible = true;
                if (seçiliresimler == 1) pictureBox13.Image = Image.FromFile("1-7.png");
                else if (seçiliresimler == 2) pictureBox13.Image = Image.FromFile("2-7.png");
                else if (seçiliresimler == 3) pictureBox13.Image = Image.FromFile(@"3-7.jpg");

                #endregion
                #region resim14
                pictureBox14.Visible = true;
                if (seçiliresimler == 1) pictureBox14.Image = Image.FromFile("1-7.png");
                else if (seçiliresimler == 2) pictureBox14.Image = Image.FromFile("2-7.png");
                else if (seçiliresimler == 3) pictureBox14.Image = Image.FromFile(@"3-7.jpg");

                #endregion
                #region resim15
                pictureBox15.Visible = true;
                if (seçiliresimler == 1) pictureBox15.Image = Image.FromFile("1-8.png");
                else if (seçiliresimler == 2) pictureBox15.Image = Image.FromFile("2-8.png");
                else if (seçiliresimler == 3) pictureBox15.Image = Image.FromFile(@"3-8.jpg");

                #endregion
                #region resim16
                pictureBox16.Visible = true;
                if (seçiliresimler == 1) pictureBox16.Image = Image.FromFile("1-8.png");
                else if (seçiliresimler == 2) pictureBox16.Image = Image.FromFile("2-8.png");
                else if (seçiliresimler == 3) pictureBox16.Image = Image.FromFile(@"3-8.jpg");

                #endregion
                #region resim17
                pictureBox17.Visible = true;
                if (seçiliresimler == 1) pictureBox17.Image = Image.FromFile("1-9.png");
                else if (seçiliresimler == 2) pictureBox17.Image = Image.FromFile("2-9.png");
                else if (seçiliresimler == 3) pictureBox17.Image = Image.FromFile(@"3-9.jpg");

                #endregion
                #region resim18
                pictureBox18.Visible = true;
                if (seçiliresimler == 1) pictureBox18.Image = Image.FromFile("1-9.png");
                else if (seçiliresimler == 2) pictureBox18.Image = Image.FromFile("2-9.png");
                else if (seçiliresimler == 3) pictureBox18.Image = Image.FromFile(@"3-9.jpg");

                #endregion
                #region resim19
                pictureBox19.Visible = true;
                if (seçiliresimler == 1) pictureBox19.Image = Image.FromFile("1-10.png");
                else if (seçiliresimler == 2) pictureBox19.Image = Image.FromFile("2-10.png");
                else if (seçiliresimler == 3) pictureBox19.Image = Image.FromFile(@"3-10.png");

                #endregion
                #region resim20
                pictureBox20.Visible = true;
                if (seçiliresimler == 1) pictureBox20.Image = Image.FromFile("1-10.png");
                else if (seçiliresimler == 2) pictureBox20.Image = Image.FromFile("2-10.png");
                else if (seçiliresimler == 3) pictureBox20.Image = Image.FromFile(@"3-10.png");

                #endregion
            }
            else
            {
                #region
                pictureBox1.Image = Image.FromFile(@"Adsız.png");
                pictureBox2.Image = Image.FromFile(@"Adsız.png");
                pictureBox3.Image = Image.FromFile(@"Adsız.png");
                pictureBox4.Image = Image.FromFile(@"Adsız.png");
                pictureBox5.Image = Image.FromFile(@"Adsız.png");
                pictureBox6.Image = Image.FromFile(@"Adsız.png");
                pictureBox7.Image = Image.FromFile(@"Adsız.png");
                pictureBox8.Image = Image.FromFile(@"Adsız.png");
                pictureBox9.Image = Image.FromFile(@"Adsız.png");
                pictureBox10.Image = Image.FromFile(@"Adsız.png");

                pictureBox11.Image = Image.FromFile(@"Adsız.png");
                pictureBox12.Image = Image.FromFile(@"Adsız.png");
                pictureBox13.Image = Image.FromFile(@"Adsız.png");
                pictureBox14.Image = Image.FromFile(@"Adsız.png");
                pictureBox15.Image = Image.FromFile(@"Adsız.png");
                pictureBox16.Image = Image.FromFile(@"Adsız.png");
                pictureBox17.Image = Image.FromFile(@"Adsız.png");
                pictureBox18.Image = Image.FromFile(@"Adsız.png");
                pictureBox19.Image = Image.FromFile(@"Adsız.png");
                pictureBox20.Image = Image.FromFile(@"Adsız.png");
                sayaç2 = 0;
                timer13.Enabled = false;
                #endregion
                timer12.Enabled = true;
            }

            sayaç2++;


        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            button8.Visible = true;

            axWindowsMediaPlayer1.URL = "bandicam 2020-05-22 13-27-41-083 (online-audio-converter.com).mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            label8.Visible = false;
            //resimsil();
            tıklasınır = 0;
            tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false; tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
            
            #region
            s1 = false;
            s2 = false;
            s3 = false;
            s4 = false;
            s5 = false;
            s6 = false;
            s7 = false;
            s8 = false;
            s9 = false;
            s10 = false;
            s11 = false;
            s12 = false;
            s13 = false;
            s14 = false;
            s15 = false;
            s16 = false;
            s17 = false;
            s18 = false;
            s19 = false;
            s20 = false;
            #endregion
            saniye = 60;
            dakika = 0;
            label2.Text = "0";
            rendks = 0;
            //oyunbaşla = true;
            a = 0;
            sayaç2 = 0;
            timer13.Enabled = true;
            yüklenme();
            
            
            //if (comboBox1.SelectedItem == "Manzaralar")
            //{
            //    seçiliresimler = 1;


            //}
            //if (comboBox1.SelectedItem == "Oyunlar")
            //{
            //    seçiliresimler = 2;

            //}
            //if (comboBox1.SelectedItem == "Karışık")
            //{
            //    seçiliresimler = 3;

            //}



            timer12.Enabled = true;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (hazır)
            {
                if (açık)
                {
                    açık = false;
                }
                else
                    açık = true;


                timer14.Enabled = true;
            }
           // panel2.Height = 5;
           
        }
        byte abc = 1;
        bool açık = false;
        bool hazır = true;
        private void timer14_Tick(object sender, EventArgs e)
        {
            hazır = false;
            if (açık)
            {
                abc++;
                if (abc > 1 && abc < 23)
                {
                    panel2.Width += 5;
                }
                else if (abc >= 23 && abc < 46)
                {
                    panel2.Height += 5;
                }
                else
                {
                    abc = 1;
                    timer14.Enabled = false;
                    hazır = true;
                }
            }
            else
            {
                abc++;
                if (abc > 1 && abc < 23)
                {
                    panel2.Width -= 5;
                }
                else if (abc >= 23 && abc < 46)
                {
                    panel2.Height -= 5;
                }
                else
                {
                    abc = 1;
                    timer14.Enabled = false;
                    hazır = true;
                }
            }


           
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seçilisüre = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            seçilisüre = 1;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            seçilisüre = 0;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.Silver;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.White;
        }
        bool renkd = false;
        byte rendks = 0;
        
        private void timer15_Tick(object sender, EventArgs e)//Kazanınca Arkaplan renginin değişmesi
        {
            if (rendks < 10)
            {

                timer12.Enabled = false;
                if (renkd)
                {
                    this.BackColor = Color.Blue;
                    renkd = false;
                }
                else
                {
                    this.BackColor = Color.Aqua;
                    renkd = true;
                }
                rendks++;
            }
            else
            {
                button7.Visible = false;
                button8.Visible = false;
                YeniOyun();
                timer15.Enabled = false;
                this.BackColor = Color.Blue;
                
            }
            
        }

        void YeniOyun()
        {
           // resimsil();
            deneme = 0;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(@"Adsız.png");
            pictureBox2.Visible = true;
            pictureBox2.Image = Image.FromFile(@"Adsız.png");
            pictureBox3.Visible = true;
            pictureBox3.Image = Image.FromFile(@"Adsız.png");
            pictureBox4.Visible = true;
            pictureBox4.Image = Image.FromFile(@"Adsız.png");
            pictureBox5.Visible = true;
            pictureBox5.Image = Image.FromFile(@"Adsız.png");
            pictureBox6.Visible = true;
            pictureBox6.Image = Image.FromFile(@"Adsız.png");
            pictureBox7.Visible = true;
            pictureBox7.Image = Image.FromFile(@"Adsız.png");
            pictureBox8.Visible = true;
            pictureBox8.Image = Image.FromFile(@"Adsız.png");
            pictureBox9.Visible = true;
            pictureBox9.Image = Image.FromFile(@"Adsız.png");
            pictureBox10.Visible = true;
            pictureBox10.Image = Image.FromFile(@"Adsız.png");
            pictureBox11.Visible = true;
            pictureBox11.Image = Image.FromFile(@"Adsız.png");
            pictureBox12.Visible = true;
            pictureBox12.Image = Image.FromFile(@"Adsız.png");
            pictureBox13.Visible = true;
            pictureBox13.Image = Image.FromFile(@"Adsız.png");
            pictureBox14.Visible = true;
            pictureBox14.Image = Image.FromFile(@"Adsız.png");
            pictureBox15.Visible = true;
            pictureBox15.Image = Image.FromFile(@"Adsız.png");
            pictureBox16.Visible = true;
            pictureBox16.Image = Image.FromFile(@"Adsız.png");
            pictureBox17.Visible = true;
            pictureBox17.Image = Image.FromFile(@"Adsız.png");
            pictureBox18.Visible = true;
            pictureBox18.Image = Image.FromFile(@"Adsız.png");
            pictureBox19.Visible = true;
            pictureBox19.Image = Image.FromFile(@"Adsız.png");
            pictureBox20.Visible = true;
            pictureBox20.Image = Image.FromFile(@"Adsız.png");
            tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false;
            tıklama10 = false; tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
            
            oyunbaşla = false;
            label4.Text = "0";
            label5.Text = "0";
        }
        byte red = 0, blue = 0, green = 0;
        bool reda = true, bluea = true, greena = true;
        private void timer16_Tick(object sender, EventArgs e)
        {
            if (reda)
            {
                red+=2;
                if (red > 252)
                {
                    reda = false;
                }
            }
            else
            {
                red-=2;
                if (red<2)
                {
                    reda = true;
                }
            }

            //
            if (bluea)
            {
                blue++;
                if (blue > 252)
                {
                    bluea = false;
                }
            }
            else
            {
                blue--;
                if (blue < 1)
                {
                    bluea = true;
                }
            }

            //
            if (greena)
            {
                green+=3;
                if (green > 252)
                {
                    greena = false;
                }
            }
            else
            {
                green-=3;
                if (green < 4)
                {
                    greena = true;
                }
            }

            button1.ForeColor = Color.FromArgb(red, green, blue);

        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.Gray;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.White;
        }
        bool hazır2 = true;
        private void label8_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (hazır2)
            {
                ResimSeç();
                if (panel)
                {
                    panel = false;
                }
                else
                    panel = true;
            }
        }
        bool panel = false;

        void ResimSeç()
        {
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            if (seçiliresimler == 1) pictureBox1.Image = Image.FromFile("1-1.png");
            else if (seçiliresimler == 2) pictureBox1.Image = Image.FromFile("2-1.png");
            else if (seçiliresimler == 3) pictureBox1.Image = Image.FromFile(@"3-1.png");

            if (seçiliresimler == 1) pictureBox2.Image = Image.FromFile("1-1.png");
            else if (seçiliresimler == 2) pictureBox2.Image = Image.FromFile("2-1.png");
            else if (seçiliresimler == 3) pictureBox2.Image = Image.FromFile(@"3-1.png");

            if (seçiliresimler == 1) pictureBox3.Image = Image.FromFile("1-2.png");
            else if (seçiliresimler == 2) pictureBox3.Image = Image.FromFile("2-2.png");
            else if (seçiliresimler == 3) pictureBox3.Image = Image.FromFile(@"3-2.png");

            if (seçiliresimler == 1) pictureBox4.Image = Image.FromFile("1-2.png");
            else if (seçiliresimler == 2) pictureBox4.Image = Image.FromFile("2-2.png");
            else if (seçiliresimler == 3) pictureBox4.Image = Image.FromFile(@"3-2.png");

            if (seçiliresimler == 1) pictureBox5.Image = Image.FromFile("1-3.png");
            else if (seçiliresimler == 2) pictureBox5.Image = Image.FromFile("2-3.png");
            else if (seçiliresimler == 3) pictureBox5.Image = Image.FromFile(@"3-3.png");

            if (seçiliresimler == 1) pictureBox6.Image = Image.FromFile("1-3.png");
            else if (seçiliresimler == 2) pictureBox6.Image = Image.FromFile("2-3.png");
            else if (seçiliresimler == 3) pictureBox6.Image = Image.FromFile(@"3-3.png");

            if (seçiliresimler == 1) pictureBox7.Image = Image.FromFile("1-4.png");
            else if (seçiliresimler == 2) pictureBox7.Image = Image.FromFile("2-4.png");
            else if (seçiliresimler == 3) pictureBox7.Image = Image.FromFile(@"3-4.png");

            if (seçiliresimler == 1) pictureBox8.Image = Image.FromFile("1-4.png");
            else if (seçiliresimler == 2) pictureBox8.Image = Image.FromFile("2-4.png");
            else if (seçiliresimler == 3) pictureBox8.Image = Image.FromFile(@"3-4.png");

            if (seçiliresimler == 1) pictureBox9.Image = Image.FromFile("1-5.png");
            else if (seçiliresimler == 2) pictureBox9.Image = Image.FromFile("2-5.png");
            else if (seçiliresimler == 3) pictureBox9.Image = Image.FromFile(@"3-5.png");

            if (seçiliresimler == 1) pictureBox10.Image = Image.FromFile("1-5.png");
            else if (seçiliresimler == 2) pictureBox10.Image = Image.FromFile("2-5.png");
            else if (seçiliresimler == 3) pictureBox10.Image = Image.FromFile(@"3-5.png");

            if (seçiliresimler == 1) pictureBox11.Image = Image.FromFile("1-6.png");
            else if (seçiliresimler == 2) pictureBox11.Image = Image.FromFile("2-6.png");
            else if (seçiliresimler == 3) pictureBox11.Image = Image.FromFile(@"3-6.png");

            if (seçiliresimler == 1) pictureBox12.Image = Image.FromFile("1-6.png");
            else if (seçiliresimler == 2) pictureBox12.Image = Image.FromFile("2-6.png");
            else if (seçiliresimler == 3) pictureBox12.Image = Image.FromFile(@"3-6.png");

            if (seçiliresimler == 1) pictureBox13.Image = Image.FromFile("1-7.png");
            else if (seçiliresimler == 2) pictureBox13.Image = Image.FromFile("2-7.png");
            else if (seçiliresimler == 3) pictureBox13.Image = Image.FromFile(@"3-7.jpg");

            if (seçiliresimler == 1) pictureBox14.Image = Image.FromFile("1-7.png");
            else if (seçiliresimler == 2) pictureBox14.Image = Image.FromFile("2-7.png");
            else if (seçiliresimler == 3) pictureBox14.Image = Image.FromFile(@"3-7.jpg");

            if (seçiliresimler == 1) pictureBox15.Image = Image.FromFile("1-8.png");
            else if (seçiliresimler == 2) pictureBox15.Image = Image.FromFile("2-8.png");
            else if (seçiliresimler == 3) pictureBox15.Image = Image.FromFile(@"3-8.jpg");

            if (seçiliresimler == 1) pictureBox16.Image = Image.FromFile("1-8.png");
            else if (seçiliresimler == 2) pictureBox16.Image = Image.FromFile("2-8.png");
            else if (seçiliresimler == 3) pictureBox16.Image = Image.FromFile(@"3-8.jpg");

            if (seçiliresimler == 1) pictureBox17.Image = Image.FromFile("1-9.png");
            else if (seçiliresimler == 2) pictureBox17.Image = Image.FromFile("2-9.png");
            else if (seçiliresimler == 3) pictureBox17.Image = Image.FromFile(@"3-9.jpg");

            if (seçiliresimler == 1) pictureBox18.Image = Image.FromFile("1-9.png");
            else if (seçiliresimler == 2) pictureBox18.Image = Image.FromFile("2-9.png");
            else if (seçiliresimler == 3) pictureBox18.Image = Image.FromFile(@"3-9.jpg");

            if (seçiliresimler == 1) pictureBox19.Image = Image.FromFile("1-10.png");
            else if (seçiliresimler == 2) pictureBox19.Image = Image.FromFile("2-10.png");
            else if (seçiliresimler == 3) pictureBox19.Image = Image.FromFile(@"3-10.png");

            if (seçiliresimler == 1) pictureBox20.Image = Image.FromFile("1-10.png");
            else if (seçiliresimler == 2) pictureBox20.Image = Image.FromFile("2-10.png");
            else if (seçiliresimler == 3) pictureBox20.Image = Image.FromFile(@"3-10.png");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            seçiliresimler++;
            if (seçiliresimler<=3)
            {
                
            }
            else
                seçiliresimler=1;
            ResimSeç();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seçiliresimler--;
            if (seçiliresimler > 0)
            {

            }
            else
                seçiliresimler = 3;
            ResimSeç();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            resimsil();
        }

        byte abcd = 0;
        private void timer6_Tick(object sender, EventArgs e)
        {
            //oyunbaşla = false;
            abcd++;
            if (abcd > 10)
            {


                //tıklasınır = 0;
                tıklama1 = false; tıklama2 = false; tıklama3 = false; tıklama4 = false; tıklama5 = false; tıklama6 = false; tıklama7 = false; tıklama8 = false; tıklama9 = false; tıklama10 = false; tıklama11 = false; tıklama12 = false; tıklama13 = false; tıklama14 = false; tıklama15 = false; tıklama16 = false; tıklama17 = false; tıklama18 = false; tıklama19 = false; tıklama20 = false;
                pictureBox1.Image = Image.FromFile(@"Adsız.png");
                pictureBox2.Image = Image.FromFile(@"Adsız.png");
                pictureBox3.Image = Image.FromFile(@"Adsız.png");
                pictureBox4.Image = Image.FromFile(@"Adsız.png");
                pictureBox5.Image = Image.FromFile(@"Adsız.png");
                pictureBox6.Image = Image.FromFile(@"Adsız.png");
                pictureBox7.Image = Image.FromFile(@"Adsız.png");
                pictureBox8.Image = Image.FromFile(@"Adsız.png");
                pictureBox9.Image = Image.FromFile(@"Adsız.png");
                pictureBox10.Image = Image.FromFile(@"Adsız.png");

                pictureBox11.Image = Image.FromFile(@"Adsız.png");
                pictureBox12.Image = Image.FromFile(@"Adsız.png");
                pictureBox13.Image = Image.FromFile(@"Adsız.png");
                pictureBox14.Image = Image.FromFile(@"Adsız.png");
                pictureBox15.Image = Image.FromFile(@"Adsız.png");
                pictureBox16.Image = Image.FromFile(@"Adsız.png");
                pictureBox17.Image = Image.FromFile(@"Adsız.png");
                pictureBox18.Image = Image.FromFile(@"Adsız.png");
                pictureBox19.Image = Image.FromFile(@"Adsız.png");
                pictureBox20.Image = Image.FromFile(@"Adsız.png");
                abcd = 0;
                timer6.Enabled = false;
                oyunbaşla = true;               
                tıklasınır = 0;
            }
            

        }

        private void timer17_Tick(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool sesaçık = false;
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (sesyolu != "")
            {

                if (sesaçık)
                {
                    sesaçık = false;

                     pictureBox21.Image = Image.FromFile("33-339612_media-player-play-button-clipart.png");
                    axWindowsMediaPlayer2.Ctlcontrols.stop();


                }
                else
                {
                    sesaçık = true;

                    pictureBox21.Image = Image.FromFile("118-1181044_button-pause-stop-icon-sy-pause-play-stop-removebg-preview.png");
                    //timer18.Enabled = true;
                   
                        MenüSesi();
                    // menüsesi.Play();
                   
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Dur")
            {
                button8.Text = "Başlat";
                //başlatma kodları
                timer12.Stop();
                oyunbaşla = false;
            }
            else
            {
                button8.Text = "Dur";
                //Durunca yazılacak kodlar
                timer12.Start();
                oyunbaşla = true;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SüreBitti();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/d.r.y.offical/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            pictureBox21.Image = Image.FromFile("33-339612_media-player-play-button-clipart.png");
            openFileDialog1.Filter = "Sound files (*.mp3;*.wav;*.wow;*.m4a)|*.mp3;*.wav;*.wow;*.m4a";
           // openFileDialog1.InitialDirectory = "";
            openFileDialog1.ShowDialog();
            sesyolu = openFileDialog1.FileName;
        }
        byte h2 = 0;
        bool aç = false;//açıkken true
        private void timer18_Tick(object sender, EventArgs e)
        {
            if (aç)
            {
                h2--;
                if (h2 < 1)
                {
                    timer18.Enabled = false;
                    aç = false;
                }
            }
            else
            {
                h2++;
                if (h2>55)
                {
                    timer18.Enabled = false;
                    aç = true;
                }
            }
            panel3.Height = h2;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (panel3.Height==0)
            {
                aç = false;
            }
            else
                aç = true;
            timer18.Enabled = true;
        }

       



        
    }
}

﻿using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Linq;

namespace WFA_SayisalLoto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        Random rnd = new Random();
        int index = 0;
        int[] sayilar = new int[6];

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = rnd.Next(1, 50);
            if (index < 10)
            {
                sayilar[0] = sayi;
                t1.Text = sayilar[0].ToString();
            }

            else if (index < 20)
            {

                if (sayilar.Contains(sayi))
                {
                    index--;
                    t2.BackColor = Color.Tomato;
                }

                sayilar[1] = sayi;
                t2.Text = sayilar[1].ToString();

            }
            else if (index < 30)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t3.BackColor = Color.Tomato;
                }

                sayilar[2] = sayi;
                t3.Text = sayilar[2].ToString();
            }
            else if (index < 40)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t4.BackColor = Color.Tomato;
                }

                sayilar[3] = sayi;
                t4.Text = sayilar[3].ToString();
            }
            else if (index < 50)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t5.BackColor = Color.Tomato;
                }

                sayilar[4] = sayi;
                t5.Text = sayilar[4].ToString();
            }
            else if (index < 60)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t6.BackColor = Color.Tomato;
                }

                sayilar[5] = sayi;
                t6.Text = sayilar[5].ToString();
            }

             
            if (index == 70)
            {
                Array.Sort(sayilar);
                t1.Text = sayilar[0].ToString();
                t2.Text = sayilar[1].ToString();
                t3.Text = sayilar[2].ToString();
                t4.Text = sayilar[3].ToString();
                t5.Text = sayilar[4].ToString();
                t6.Text = sayilar[5].ToString();
                t1.BackColor = default;
                t2.BackColor = default;
                t3.BackColor = default;
                t4.BackColor = default;
                t5.BackColor = default;
                t6.BackColor = default;
                 
            }
             
            index++;
        }
    }
}

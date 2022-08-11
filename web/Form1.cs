using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using System.IO;

namespace web
{
    public partial class Form1 : Form
    {
        IWebDriver driver1;
        int sec,tt,rr,y;
        public Form1()
        {
           
            InitializeComponent();
            x = 0;
            sec = 0;
            tt = 0;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = false;
            button7.Text = "Start";  
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            if (x >= 1)
            {
                sec++;
                textBox20.Text = sec.ToString();
                textBox21.Text = tt.ToString();
                try
                {
                    if (sec == 2)
                    {
                        textBox1.Text = numbers[x-1].ToString();
                        button4.PerformClick();
                        if (x == numbers.Length)
                        {
                            q = 0;
                            textBox1.Text ="1";
                            button4.PerformClick();
                            x = -1;
                        }
                        x++;
                    }
                    if (sec == 3)
                    {
                       
                        button3.PerformClick();
                    }
                    if (sec == 6)
                    {
                        tt++;
                        sec = 0;
                        button6.PerformClick();

                    }

                    if (tt == rr)
                    {
                        button7.PerformClick();
                        tt = 0;
                    }

                }
                catch { }
            }

            if (x <= 0)
            {
                sec++;
                textBox20.Text = sec.ToString();
                textBox21.Text = tt.ToString();
                try
                {
                    if (Convert.ToInt32(textBox1.Text) > 1)
                    {
                        textBox1.Text = "1";
                        button4.PerformClick();
                    }
                    if (sec == 2)
                    {

                        button3.PerformClick();
                    }
                    if (sec == 5)
                    {
                        tt++;
                        sec = 0;
                        button6.PerformClick();

                    }

                    if (tt == rr)
                    {
                        button7.PerformClick();
                        tt = 0;
                    }

                }
                catch { }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            driver1 = new ChromeDriver();
            driver1.Url = "https://1x-bet86595.com/ru/dice/lobby/";
            driver1.Manage().Window.Maximize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                var wx = driver1.FindElement(By.Name("valueFrom"));
            wx.Clear();
            wx.SendKeys(textBox5.Text);
            var w = driver1.FindElement(By.Name("valueTo"));
                w.Clear();
                w.SendKeys(textBox6.Text);

        }
        public void prov(int m)
        {
            if (m >= 0 && m < 10)
            {
                textBox8.Text = Convert.ToString(1 + Convert.ToInt32(textBox8.Text));
                m = 111;
            }
            if (m >= 10 && m < 20)
            {
                textBox9.Text = Convert.ToString(1 + Convert.ToInt32(textBox9.Text));
                m = 111;
            }
            if (m >= 20 && m < 30)
            {
                textBox10.Text = Convert.ToString(1 + Convert.ToInt32(textBox10.Text));
                m = 111;
            }
            if (m >= 30 && m < 40)
            {
                textBox11.Text = Convert.ToString(1 + Convert.ToInt32(textBox11.Text));
                m = 111;
            }
            if (m >= 40 && m < 50)
            {
                textBox12.Text = Convert.ToString(1 + Convert.ToInt32(textBox12.Text));
                m = 111;
            }
            if (m >= 50 && m < 60)
            {
                textBox13.Text = Convert.ToString(1 + Convert.ToInt32(textBox13.Text));
                m = 111;
            }
            if (m >= 60 && m < 70)
            {
                textBox14.Text = Convert.ToString(1 + Convert.ToInt32(textBox14.Text));
                m = 111;
            }
            if (m >= 70 && m < 80)
            {
                textBox15.Text = Convert.ToString(1 + Convert.ToInt32(textBox15.Text));
                m = 111;
            }
            if (m >= 80 && m <= 90)
            {
                textBox16.Text = Convert.ToString(1 + Convert.ToInt32(textBox16.Text));
                m = 111;
            }
            if (m >= 90 && m < 100)
            {
                textBox17.Text = Convert.ToString(1 + Convert.ToInt32(textBox17.Text));
                m = 111;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            driver1.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[2]/input")).Click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var w = driver1.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div[1]/input"));
            w.Clear();
            w.SendKeys(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var w = driver1.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div[5]/div/input"));
                w.Clear();
            w.SendKeys(textBox4.Text);
        }
        int q,x;

        private void button8_Click(object sender, EventArgs e)
        {
            q = 0;
            sec = 0;
            x = -1;
            tt = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox22.Text = "";
            textBox20.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = Convert.ToString(1 + Convert.ToInt32(textBox24.Text));
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = Convert.ToString(1 + Convert.ToInt32(textBox24.Text));
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = Convert.ToString(1 + Convert.ToInt32(textBox24.Text));
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = Convert.ToString(1 + Convert.ToInt32(textBox24.Text));
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = Convert.ToString(1 + Convert.ToInt32(textBox24.Text));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = Convert.ToString(1 + Convert.ToInt32(textBox23.Text));
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = Convert.ToString(1 + Convert.ToInt32(textBox23.Text));
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = Convert.ToString(1 + Convert.ToInt32(textBox23.Text));
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = Convert.ToString(1 + Convert.ToInt32(textBox23.Text));
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = Convert.ToString(1 + Convert.ToInt32(textBox23.Text));
        }
        string put;
        int[] numbers;
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new OpenFileDialog();
            myFile.Title = "First step Site";
            myFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (myFile.ShowDialog() == DialogResult.OK)
            {
                put = myFile.FileName;
            }
            string file = File.ReadAllText(put);
                numbers = file
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
            y = numbers.Length;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void qwe(string w)
        {
         
            if (w != "Выигрыш")
            {
                q++;
                if (q.ToString() == textBox2.Text.ToString())
                {
                    x = 1;
                   // textBox22.Text += "-";
                }
                textBox3.Text = Convert.ToString(1 + Convert.ToInt32(textBox3.Text));
                textBox22.Text +="-";
            }
            else
            {
                x = -1;
                    textBox22.Text += "+";
                
                q = 0;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            var x = driver1.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div[9]/div/div/div[1]/div[1]/span"));
            textBox18.Text = x.Text;//число
            var result = textBox18.Text.Split('.')[0];
            int m = int.Parse(result);
            prov(m);
            var c = driver1.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div[9]/div/div/div[1]/div[5]/span"));
            textBox19.Text = c.Text;// результ
            qwe(textBox19.Text);
            var v = driver1.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[1]/div/div")); //банк title
            textBox7.Text = v.Text;
            if(Convert.ToInt32(textBox7.Text) < Convert.ToInt32(textBox26.Text))
            {
                button7.PerformClick();
            }
            if (Convert.ToInt32(textBox7.Text) > Convert.ToInt32(textBox25.Text))
            {
                button7.PerformClick();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rr = (int)(numericUpDown1.Value);
            if (button7.Text == "Start")
            {
                button7.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                button7.Text = "Start";
                timer1.Enabled = false;
            }
        }
    }
}

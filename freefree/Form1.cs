using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace freefree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("계산기");
            listBox1.Items.Add("인터넷");
            listBox1.Items.Add("cmd");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string a = listBox1.SelectedItem.ToString();
                if (a == "계산기")
                {
                    Process.Start("calc.exe");
                }
                if (a == "인터넷")
                {
                    Process.Start("chrome.exe", "https://www.naver.com");
                }
                if (a == "cmd")
                {
                    Process.Start("cmd.exe");
                }
            }

            catch
            {
                MessageBox.Show("please choie");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = "/c" + textBox1.Text;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.Start();
            string txt1 = cmd.StandardOutput.ReadToEnd();
            textBox2.Text = txt1;
        }
    }
}

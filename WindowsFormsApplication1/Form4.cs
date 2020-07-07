using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//頭像
namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public static Image Icon1=Image.FromFile(Application.StartupPath + "\\Asset\\1.png"); //頭像1   
        public static Image Icon2=Image.FromFile(Application.StartupPath + "\\Asset\\2.png"); //頭像2
        public static Image Icon3=Image.FromFile(Application.StartupPath + "\\Asset\\3.png"); //頭像3
        public static int ic; //頭像
        public static bool ic_lock; //判斷頭像1~2是否解鎖
        public static bool ic3_lock; //判斷頭像3是否解鎖

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) 
        {
            this.Location = new Point(370, 0);

            //頭像設定
            pictureBox1.Image = Icon1;
            pictureBox2.Image = Icon2;
            pictureBox3.Image = Icon3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ic = 1;
            ic_lock = true;
            pictureBox4.Enabled = true;

            if (ic3_lock == true) 
            {
                ic_lock = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ic = 2;
            ic_lock = true;
            pictureBox4.Enabled = true;

            if (ic3_lock == true) 
            {
                ic_lock = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ic = 0;

            if (ic3_lock == true)
            {
                ic = 3;
                ic_lock = true;
            }
            else
            {
                ic_lock = false;
            }

            if (Form1.money < 1000) //金錢不足
            {
                pictureBox4.Enabled = false;
            }
        }  

        private void pictureBox4_Click(object sender, EventArgs e) //購買頭像
        {
            if (Form1.money > 1000 && ic_lock == false)
            {
                Form1.money -= 1000;
                radioButton3.Text = "頭像3";
                MessageBox.Show("購買成功!");
                ic = 3;
                ic_lock = true;
                ic3_lock = true;
            }
            else if (ic_lock == true)
            {
                Form1.money -= 0;
                MessageBox.Show("已擁有此頭像!");
            }
        }
    }
}

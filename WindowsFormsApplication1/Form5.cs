using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//怪物夥伴
namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static int mon; //玩家所選擇之怪物夥伴

        private void Form5_Load(object sender, EventArgs e) 
        {
            this.Location = new Point(370, 0);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon1-1-R.png");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon2-1-R.png");
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon3-1-R.png");
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon4-1-R.png");
        }

        private void button1_Click(object sender, EventArgs e) //選擇按鈕
        {
            Form1.bet = 0;
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mon = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mon = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mon = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mon = 4;
        }
    }
}

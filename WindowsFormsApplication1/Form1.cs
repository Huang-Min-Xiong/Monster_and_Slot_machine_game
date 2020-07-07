using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//主畫面
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static int money; //玩家籌碼
        public static int bet; //賭注金額
        public static int count=0; //借貸次數

        public Form1()
        {           
           InitializeComponent();                     
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);      
            money = 5000; //初始籌碼                             
        }

        private void pictureBox1_Click(object sender, EventArgs e) //100籌碼
        {           
             if (money < 100)
            {
                money -= 0;
                bet += 0;
                MessageBox.Show("籌碼不夠!");
            }
            else
            {
                money -= 100;
                textBox2.Text = money.ToString();
                bet += 100;
                textBox1.Text = bet.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) //500籌碼
        {     
             if (money < 500)
            {
                money -= 0;
                bet += 0;
                MessageBox.Show("籌碼不夠!");
            }
            else
            {
                money -= 500;
                textBox2.Text = money.ToString();
                bet += 500;
                textBox1.Text = bet.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //1000籌碼
        {
             if (money < 1000)
            {
                money -= 0;
                bet += 0;
                MessageBox.Show("籌碼不夠!");
            }
            else
            {
                money -= 1000;
                textBox2.Text = money.ToString();
                bet += 1000;
                textBox1.Text = bet.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) //5000籌碼
        {        
            if (money < 5000)
            {
                money -= 0;
                bet += 0;
                MessageBox.Show("籌碼不夠!");
            }
            else
            {
                money -= 5000;
                textBox2.Text = money.ToString();
                bet += 5000;
                textBox1.Text = bet.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) //彈出頭像表單
        {   
            Form4 f4 = new Form4();
            f4.Show();           
        }

        private void icon_tmr_Tick(object sender, EventArgs e) //偵測頭像
        {
             if (Form4.ic == 0)
            {
                pictureBox5.Image = null;
            }
            else if (Form4.ic == 1)
            {
                pictureBox5.Image = Form4.Icon1;
            }
            else if (Form4.ic == 2)
            {
                pictureBox5.Image = Form4.Icon2;
            }
            else if (Form4.ic == 3)
            {
                pictureBox5.Image = Form4.Icon3;
            }
            textBox2.Text = money.ToString();
            textBox1.Text = bet.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e) //進入競賽遊戲畫面
        {
            if (bet == 0)
            {
                MessageBox.Show("請投注金額!");
                return;
            }

            Form5 fm5 = new Form5();
            fm5.Show();        
        }

        private void button1_Click(object sender, EventArgs e) //借貸按鈕
        {        
            count++;
            if(count==1) {
                money += 1000;
                MessageBox.Show("這是你唯一能夠翻身的機會");
            }
            else if(count >=2) 
            {
                money += 0;
                MessageBox.Show("你的信用已破產，無法再踏入此遊戲!");
                this.Close();
            }
        }

        private void count_tmr_Tick(object sender, EventArgs e) //判斷借貸按鈕啟用
        {
            if (money == 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
   



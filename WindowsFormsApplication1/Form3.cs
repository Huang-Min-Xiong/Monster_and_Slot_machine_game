using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//拉霸機
namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {   
        public Form3()
        {
            InitializeComponent();

            //按鈕初始設定
            pictureBox9.Enabled = false; 
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
        }

        public static int total_money = 0; //拉霸獲得總金額
        int pic,pic2,pic3; //競賽結果圖片
        int prize=0; //777大獎

        private void Form3_Load(object sender, EventArgs e) 
        {
            this.Location = new Point(600, 0);
            pic = rd.Next(0, 4);
            pic2 = rd.Next(0, 4);
            pic3 = rd.Next(0, 4);
            pictureBox1.Image = result_pic.Images[pic];
            pictureBox2.Image = result_pic.Images[pic2];
            pictureBox3.Image = result_pic.Images[pic3];

            //圖片順序設定  
            pictureBox7.BringToFront();
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
        }  

        int pic4, pic5,pic6; //拉霸完圖片
        Random rd = new Random();

        private void tmr4_Tick(object sender, EventArgs e)
        {           
            pic4 = rd.Next(0, 6);
            pictureBox4.Image = pic4_imgs.Images[pic4];               
        }

        private void tmr5_Tick(object sender, EventArgs e)
        {
            pic5 = rd.Next(0, 6);
            pictureBox5.Image = pic5_imgs.Images[pic5];       
        }

        private void tmr6_Tick(object sender, EventArgs e)
        {
            pic6 = rd.Next(0, 6);
            pictureBox6.Image = pic6_imgs.Images[pic6];
        }

        bool btn1, btn2, btn3; //判斷按鈕是否點擊
        private void chk_Tick(object sender, EventArgs e)
        {          
            if (btn1 == true && btn2 == true && btn3 == true) //若三個按鈕皆點擊完
            {
                if(prize==3) //獲得三個777
                {
                    total_money = 5000;
                }

                pictureBox8.Enabled = false;
                chk.Enabled = false;
                Form1.money += total_money;
                MessageBox.Show("你獲得了"+total_money+"金錢!");
                this.Close();
            }         
        }

        private void pictureBox8_Click(object sender, EventArgs e) //拉霸桿
        {
            //按鈕啟用
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;

            //timer啟用
            tmr4.Enabled = true;
            tmr5.Enabled = true;
            tmr6.Enabled = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e) //第一個按鈕
        {
            btn1 = true;
            tmr4.Enabled = false;
            if(pic==pic4) 
            {
                total_money += 1000;
            }
            
            if(pic==5) //777大獎
            { 
                prize++; 
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e) //第二個按鈕
        {
            btn2 = true;
            tmr5.Enabled = false;
            if (pic2 == pic5)
            {
                total_money += 1000;
            }

            if (pic == 5) //777大獎
            {
                prize++;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e) //第三個按鈕
        {
            btn3 = true;
            tmr6.Enabled = false;
            if (pic3 == pic6)
            {
                total_money += 1000;
            }

            if (pic == 5) //777大獎
            {
                prize++;
            }
        }
    }
}


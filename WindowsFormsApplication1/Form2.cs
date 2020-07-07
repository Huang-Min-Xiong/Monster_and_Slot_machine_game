using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//競賽
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false; //拉霸畫面按鈕初始設定
        }

        int mon1_pic = 0; //怪物1初始圖片
        int mon2_pic = 0; //怪物2初始圖片
        int mon3_pic = 0; //怪物3初始圖片
        int mon4_pic = 0; //怪物4初始圖片

        int[] speed_arr = new int[4];
        Random speed_rd = new Random(); //隨機速度
        public static int sp; //怪物1移動速度
        public static int sp2; //怪物2移動速度
        public static int sp3; //怪物3移動速度
        public static int sp4; //怪物4移動速度

        public static int player_rank; //判斷玩家所選擇之怪物夥伴是否為第1名
        public static int result_rank; //排名結果
        public static int get_money=Form1.bet*2; //猜中金額
        int[] map_arr = new int[3]; 
        Random map_rd = new Random(); //隨機背景

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i=0;i<1;i++) 
            {
                map_arr[i]= map_rd.Next(0, 3); 

                //背景圖片設定
                if (map_arr[i] == 0)
                {
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\map.jpg");
                }
               else if (map_arr[i] == 1)
                {
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\map2.jpg");
                }
                else if (map_arr[i] == 2)
                {
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\map3.jpg");
                }
            }
          

            for (int i = 0; i < 4; i++)
            {
                speed_arr[i] = speed_rd.Next(15, 21); //隨機速度
                for (int j = 0; j < i; j++)
                {
                    while (speed_arr[j] == speed_arr[i]) //若速度數值重複
                    {
                        j = 0; //如有重複，重新產生數值
                        speed_arr[i] = speed_rd.Next(15, 21); //重新產生數值
                    }
                }
            }
            this.Location = new Point(0, 330);

            //怪物1~4速度設定
            sp = speed_arr[0];
            sp2 = speed_arr[1];
            sp3 = speed_arr[2];
            sp4 = speed_arr[3];
        }

        private void m1_Tick(object sender, EventArgs e) //怪物1移動圖片設定
        {
            pictureBox1.Image = mon1.Images[mon1_pic];
            if (mon1_pic == 2)
            {
                mon1_pic = 0;
            }
            else
            {
                mon1_pic++;
            }
            pictureBox1.Location = new Point(pictureBox1.Location.X + sp, pictureBox1.Location.Y);
        }

        private void m2_Tick(object sender, EventArgs e) //怪物2移動圖片設定
        {
            pictureBox2.Image = mon2.Images[mon2_pic];
            if (mon2_pic == 2)
            {
                mon2_pic = 0;
            }
            else
            {
                mon2_pic++;
            }
            pictureBox2.Location = new Point(pictureBox2.Location.X + sp2, pictureBox2.Location.Y);
        }

        private void m3_Tick(object sender, EventArgs e) //怪物3移動圖片設定
        {
            pictureBox3.Image = mon3.Images[mon3_pic];
            if (mon3_pic == 1)
            {
                mon3_pic = 0;
            }
            else
            {
                mon3_pic++;
            }
            pictureBox3.Location = new Point(pictureBox3.Location.X + sp3, pictureBox3.Location.Y);
        }

        private void m4_Tick(object sender, EventArgs e) //怪物4移動圖片設定
        {
            pictureBox4.Image = mon4.Images[mon4_pic];
            if (mon4_pic == 2)
            {
                mon4_pic = 0;
            }
            else
            {
                mon4_pic++;
            }
            pictureBox4.Location = new Point(pictureBox4.Location.X + sp4, pictureBox4.Location.Y);      
        }

        private void chk_Tick(object sender, EventArgs e) //判斷終點
        {
            if (pictureBox1.Location.X > 1200) //怪物1到達終點
            {
                m1.Enabled = false;
                tmr.Enabled = false;
                if (sp > sp2 && sp > sp3 && sp > sp4)
                {
                    result_rank = sp;
                }
                if (Form5.mon == 1)
                {                   
                    if (sp > sp2 && sp > sp3 && sp > sp4) 
                    {                      
                        player_rank = sp;                    
                    }
                    else 
                    {
                        get_money = 0;
                        Form1.money += get_money;
                    }
                }
            }

            if (pictureBox2.Location.X > 1200) //怪物2到達終點
            {
                m2.Enabled = false;
                tmr2.Enabled = false;
                if (sp2 > sp && sp2 > sp3 && sp2 > sp4) 
                {
                    result_rank = sp2;
                }
                if (Form5.mon == 2)
                {
                    if (sp2 > sp && sp2 > sp3 && sp2 > sp4) 
                    {
                        player_rank = sp2;
                    }
                    else
                    {
                        get_money = 0;
                        Form1.money += get_money;
                    }
                }
            }

            if (pictureBox3.Location.X > 1200) //怪物3到達終點
            {
                m3.Enabled = false;
                tmr3.Enabled = false;
                if (sp3 > sp && sp3 > sp2 && sp3 > sp4) 
                {
                    result_rank = sp3;
                }
                if (Form5.mon == 3)
                {
                    if (sp3 > sp && sp3 > sp2 && sp3 > sp4) 
                    {        
                        player_rank = sp3;                   
                    }
                    else
                    {
                        get_money = 0;
                        Form1.money += get_money;
                    }
                }
            }

            if (pictureBox4.Location.X > 1200) //怪物4到達終點
            {
                m4.Enabled = false;
                tmr4.Enabled = false;
                if (sp4 > sp && sp4 > sp2 && sp4 > sp3) //電腦判斷SP4第一
                {
                    result_rank = sp4;
                }
                if (Form5.mon == 4)
                {
                    if (sp4 > sp && sp4 > sp2 && sp4 > sp3) 
                    {
                        player_rank = sp4;   
                    }
                    else
                    {
                        get_money = 0;
                        Form1.money += get_money;
                    }
                }
            }

            //當怪物1~4皆到達終點
            if (pictureBox1.Location.X > 1200 && pictureBox2.Location.X > 1200 && pictureBox3.Location.X > 1200 && pictureBox4.Location.X > 1200)
            {
                chk.Enabled = false;
                button1.Enabled = true; //拉霸畫面按鈕啟用
                Form6 fm6 = new Form6();
                fm6.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e) //拉霸畫面按鈕
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Close();
        }
    }
}


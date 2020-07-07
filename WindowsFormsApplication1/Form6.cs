using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//競賽結果
namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e) 
        {
            this.Location = new Point(365, 70);

            //判斷排名結果與玩家所選擇之怪物夥伴結果是否相同
            if (Form2.result_rank==Form2.sp) {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon1-1-R.png");
                if(Form2.player_rank== Form2.result_rank)
                 {
                    Form1.money += Form2.get_money;
                }
            }
            else if (Form2.result_rank == Form2.sp2)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon2-1-R.png");
                if (Form2.player_rank == Form2.result_rank)
                {
                    Form1.money += Form2.get_money;
                }
            }
            else if (Form2.result_rank == Form2.sp3)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon3-1-R.png");
                if (Form2.player_rank == Form2.result_rank)
                {
                    Form1.money += Form2.get_money;
                }
            }
            else if (Form2.result_rank == Form2.sp4)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Asset\\mon4-1-R.png");
                if (Form2.player_rank == Form2.result_rank)
                {
                    Form1.money += Form2.get_money;
                }
            }         
            label1.Text = "獲得金額:" + Form2.get_money;
        }

        private void button1_Click(object sender, EventArgs e) //關閉視窗按鈕
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetMePassTheCustom
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

        }
        bool[] islv = new bool[7];
        bool[] condi = new bool[3];
        bool[] magic = new bool[3];
        bool start;
        Random r = new Random();
        private void home_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    label9.Top -= 4;
                    break;
                case Keys.Down:
                    label9.Top += 4;
                    break;
                case Keys.Left:
                    label9.Left -= 4;
                    break;
                case Keys.Right:
                    label9.Left += 4;
                    break;
            }
        }
        int time;
        private void home_Load(object sender, EventArgs e)
        {
            int i, j = r.Next(0, 3); time = 300;start = true; label12.Text = Texts.gameguide;
            //init timer all bool
            for (i = 0; i < 7; ++i)
            {
                islv[i] = false;
                if (i < 3)
                {
                    magic[i] = false;
                    condi[i] = false;
                }
            }
            if (j == 1) { time = 360; }
            condi[j] = true; label1.Text = "狀態:" + Texts.condit[j] + "持有價值60萬之寶石。";
            j = r.Next(0, 3);
            magic[j] = true; label1.Text = label1.Text + "道具:" + Texts.mag[j];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {

                string diffMin = Convert.ToString(time / 60);
                string diffSec = Convert.ToString(time % 60);
                label10.Text = "還有" + diffMin + " 分 " + diffSec + " 秒 ";
                //hungry
                if (condi[0] && time == 40)
                {
                    timer1.Stop();
                    if (magic[0])
                    {
                        MessageBox.Show("突發事件:你突然好想吃東西!!!\r\n肚子餓剛好有帶麵包，幸運:)");
                    }
                    else
                    {
                        MessageBox.Show("突發事件:你突然好想吃東西!!!\r\n跑去買東西，排隊好久:(");
                        time -= 19;
                    }
                }
                timer1.Start();
                time--;
            }
            else
            {
                timer1.Stop();
                label10.Text = "還有0 分 0 秒 ";
                if (!islv[6])
                {
                    var yesno = MessageBox.Show("時間到!!通關失敗!\r\nyes離開遊戲，no回主畫面", "離開遊戲", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yesno == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        this.Hide();
                        (new Form1()).Show();
                    }
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Solider.ready == true)
            {
                label2.BackColor = Color.Aquamarine;
            }
            else
            {
                start = true;
            }
            if(label9.Bounds.IntersectsWith(label5.Bounds))
            {
                (new FastPass()).Show();
                label9.Location = new Point(label9.Left - 10, label9.Bottom + 10);
            }
            if (label9.Bounds.IntersectsWith(label2.Bounds) && start)
            {
                start = false;
                islv[0] = true;
                (new Passport()).Show();
                label9.Location = new Point(label9.Location.X, label2.Bottom + 15);

            }
            if (label9.Bounds.IntersectsWith(label3.Bounds) && islv[0])
            {
                islv[1] = true;
                islv[0] = false;
                label3.BackColor = Color.Aquamarine;
                (new BookingTicket()).Show();

            }
            if (label9.Bounds.IntersectsWith(label4.Bounds) && islv[1])
            {
                label1.Text += "。成功申報。";
                islv[1] = false;
                timer2.Stop();
                islv[2] = true; label4.BackColor = Color.Aquamarine;
                if (condi[2])
                {
                    if (!magic[1])
                    {
                        //no pan
                        MessageBox.Show("要填單子找不到筆，浪費一些時間(-20 sec)");
                        //co time
                        time -= 20;

                    }
                    else
                    {
                        //have pen
                        MessageBox.Show("要填單子找不到筆，還好我有自帶!");
                    }
                }
                //no water
                timer2.Start();
            }
       /*   if (label9.Bounds.IntersectsWith(label5.Bounds) && islv[2])
            {//託運
                islv[2] = false;
                islv[3] = true; label5.BackColor = Color.Aquamarine;
                //   (new ItemClass()).Show();

            }*/
            if (label9.Bounds.IntersectsWith(label6.Bounds) && islv[2])
            {
                //手提
                islv[2] = false;
                islv[4] = true;
                label6.BackColor = Color.Aquamarine;
             (new Items()).Show();
            }
            if (label9.Bounds.IntersectsWith(label7.Bounds) && islv[4])
            {//out
                islv[4] = false;
                islv[5] = true;
                timer2.Stop(); label7.BackColor = Color.Aquamarine;
                if (magic[2])
                {
                    MessageBox.Show("有快速通關護照就是省時間\r\n你申辦了嗎?\r\n點擊下方框框看看如何申請");
                }
                else
                {
                    MessageBox.Show("慢慢地排隊到前面驗護照，時間流逝中(-30 sec)");
                    //co time
                    time -= 30;
                }
                timer2.Start();
                label5.Visible = true;
            }
            if (label9.Bounds.IntersectsWith(label8.Bounds) && islv[5])
            {//finish
                islv[5] = false;
                islv[6] = true;
                timer1.Stop();
                timer2.Stop();
                var yesno = MessageBox.Show("您已通關!!\r\nyes離開遊戲，no回主畫面", "離開遊戲", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesno == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.Hide();
                    (new Form1()).Show();
                }

            }





        }

        private void label11_Click(object sender, EventArgs e)
        {
            label12.Visible = !label12.Visible;
            
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           // (new 快速通關()).Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

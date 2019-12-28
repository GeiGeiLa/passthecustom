using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace LetMePassTheCustom
{
    public partial class Items : Form
    {
        static string itempath = @"..\..\..\assests\items\";
        Point[] range = {new Point(23,70), new Point(802, 70),
                    new Point(23, 746), new Point(802, 746)};
        List<Label> message;
        List<TrackBar> trackbar;
        public Items()
        {
            InitializeComponent();
            message = new List<Label>();
            trackbar = new List<TrackBar>();
            btn_next.Enabled = false;
            message.Add(label1);  trackbar.Add(trackBar1);
            message.Add(label2);  trackbar.Add(trackBar2);
            message.Add(label3);  trackbar.Add(trackBar3);
            message.Add(label4);  trackbar.Add(trackBar4);
            message.Add(label5);  trackbar.Add(trackBar5);
            message.Add(label6);  trackbar.Add(trackBar6);
            message.Add(label7);  trackbar.Add(trackBar7);
            message.Add(label8);  trackbar.Add(trackBar8);
            message.Add(label9);  trackbar.Add(trackBar9);
            message.Add(label10); trackbar.Add(trackBar10);
            Random rnd = new Random();
            for (int i = 0; i < message.Count; i++)
            {
                message[i].Text = "";
                message[i].ForeColor = Color.Red;
                trackbar[i].Value = rnd.Next(0, 3);
            }
            //string[] s_bringall = Directory.GetFiles(itempath + @"small\All\");
            //string[] all = new string[s_bringall.Length];
            //string[] s_bringcarryon = Directory.GetFiles(itempath + @"small\Carryon");
            //string[] co = new string[s_bringcarryon.Length];
            //string[] s_bringcheckin = Directory.GetFiles(itempath + @"small\Checkin");
            //string[] ci = new string[s_bringcheckin.Length];
            //string[] s_forbidden = Directory.GetFiles(itempath + @"small\Forbidden");
            //string[] forb = new string[s_forbidden.Length];
            //for (int i = 0; i < s_bringall.Length; i++)
            //{
            //    all[i] = Path.GetFileNameWithoutExtension(s_bringall[i]);
            //    Debug.WriteLine(s_bringall[i]);
            //    var pb = new PictureBox();
            //    pb.Image = Image.FromFile(s_bringall[i]);
            //}
            //for (int i = 0; i < s_bringcarryon.Length; i++)
            //{
            //    co[i] = Path.GetFileNameWithoutExtension(s_bringcarryon[i]);
            //    Debug.WriteLine(s_bringcarryon[i]);
            //}
            //for (int i = 0; i < s_bringcheckin.Length; i++)
            //{
            //    ci[i] = Path.GetFileNameWithoutExtension(s_bringcheckin[i]);
            //    Debug.WriteLine(s_bringcheckin[i]);
            //}
            //for (int i = 0; i < s_forbidden.Length; i++)
            //{
            //    forb[i] = Path.GetFileNameWithoutExtension(s_forbidden[i]);
            //    Debug.WriteLine(s_forbidden[i]);
            //}

            // 尋找bring all

        }



        bool bringallowed(ItemClass item, Container container)
        {
            if (item.canBring == Bring.Forbidden) return false;
            if (item.canBring == Bring.All) return true;
            if(container is Backpack)
            {
                return (item.canBring == Bring.Carryon);
            }
            else if(container is Lugguage)
            {
                return (item.canBring == Bring.Checkin);
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pb_backpack_Click(object sender, EventArgs e)
        {

        }

        private void pb_luggage_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int correct = 0;
            const string error = "錯誤";
            for(int i = 0; i < 10; i++)
            {
                switch(i)
                {
                    // co
                    case 0:
                    case 2:
                        message[i].Text = (trackbar[i].Value == 1) ? "" : error;
                        correct += (trackbar[i].Value == 1) ? 1 : 0;
                        break;
                    // forbid
                    case 1:
                    case 5:
                    case 8:
                        message[i].Text = (trackbar[i].Value == 0) ? "" : error;
                        correct += (trackbar[i].Value == 0) ? 1 : 0;
                        break;
                    // ci
                    case 7:
                    case 9:
                        message[i].Text = (trackbar[i].Value == 2) ? "" : error;
                        correct += (trackbar[i].Value == 2) ? 1 : 0;
                        break;
                    default: // all
                        message[i].Text = (trackbar[i].Value != 0) ? "" : error;
                        correct += (trackbar[i].Value != 0) ? 1 : 0;
                        break;
                }
            }
            if (correct == 10)
            {
                btn_next.Enabled = true;
                message[3].Text = "兩者皆可";
                message[3].ForeColor = Color.DarkOliveGreen;
                message[4].Text = "兩者皆可";
                message[4].ForeColor = Color.DarkOliveGreen;
                message[6].ForeColor = Color.DarkOliveGreen;
                message[6].Text = "兩者皆可";
                lb_success.Text = "回答正確";
                lb_success.ForeColor = Color.DarkOliveGreen;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("若行李箱或背包都可放，拉到非禁止圖示即可\n提示：會著火的東西不能放著沒人管\n有人在飛機上拿刀你會怎麼樣？\n改變空氣壓力的行為超危險！","提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

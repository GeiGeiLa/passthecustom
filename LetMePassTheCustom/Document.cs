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
// 我寫了一些 
using LetMePassTheCustom.CustomLibs;
namespace LetMePassTheCustom
{
    public partial class Document : Form
    {
        readonly List<Point> OriginalPositions;
        List<bool> draggable;
        List<Point> fixedPoints;
        readonly List<Point> destPoints;
        public Document()
        {
            InitializeComponent();
            OriginalPositions = new List<Point>();
            fixedPoints = new List<Point>();
            draggable = new List<bool>();
            destPoints = new List<Point>();
            for(int i = 0; i < 4; i++)
            {
                draggable.Add(false);
            }
            // 記錄所有圖片的初始位置
            OriginalPositions.Add(pb_passport.Location);
            OriginalPositions.Add(pb_id.Location);
            OriginalPositions.Add(pb_atmcard.Location);
            OriginalPositions.Add(pb_visa.Location);
            fixedPoints.Add(pb_passport.Location);
            fixedPoints.Add(pb_id.Location);
            fixedPoints.Add(pb_atmcard.Location);
            fixedPoints.Add(pb_visa.Location);
            destPoints.Add(new Point(37,180));
            destPoints.Add(new Point(193, 180));
            destPoints.Add(new Point(414, 180));
            destPoints.Add(new Point(644, 180));

        }
        bool InRange(Form form, Control draggedObject, Control referenceObject)
        {
            return false;
        }
        private void lb_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.boca.gov.tw/cp-37-220-9f130-1.html");
        }

        private void Document_Load(object sender, EventArgs e)
        {
  
        }

        private void Document_Click(object sender, EventArgs e)
        {
            if(sender is PictureBox)
            {
                Debug.WriteLine("dragging");
            }
        }

        private void pb_id_Click(object sender, EventArgs e)
        {

        }

        private void pb_id_MouseUp(object sender, MouseEventArgs e)
        {
            draggable[1] = false;
            if(Utils.CenterOf(pb_id).X < rd_id.Right+50 && Utils.CenterOf(pb_id).X > rd_id.Left)
            {
                pb_id.Location = destPoints[1];
            }
            else
            {
                pb_id.Location = OriginalPositions[1];
            }
        }

        private void pb_id_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.mouseDrag(this,(Control)pb_id, e, this.draggable[1], this.fixedPoints[1]);
        }

        private void pb_id_MouseDown(object sender, MouseEventArgs e)
        {
            draggable[1] = true;
            fixedPoints[1] = new Point(e.X, e.Y);
        }
        private void pb_atmcard_MouseDown(object sender, MouseEventArgs e)
        {
            draggable[2] = true;
            fixedPoints[2] = new Point(e.X, e.Y);
        }

        private void pb_atmcard_MouseUp(object sender, MouseEventArgs e)
        {
            draggable[2] = false;
            if (Utils.CenterOf(pb_atmcard).X < rd_atmcard.Right + 50 && Utils.CenterOf(pb_atmcard).X > rd_atmcard.Left)
            {
                pb_atmcard.Location = destPoints[2];
            }
            else
            {
                pb_atmcard.Location = OriginalPositions[2];
            }
        }

        private void pb_atmcard_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.mouseDrag(this, (Control)pb_atmcard, e, this.draggable[2], this.fixedPoints[2]);

        }

        private void pb_passport_MouseDown(object sender, MouseEventArgs e)
        {
            draggable[0] = true;
            fixedPoints[0] = new Point(e.X, e.Y);
        }

        private void pb_passport_MouseUp(object sender, MouseEventArgs e)
        {
            draggable[1] = false;
            if (Utils.CenterOf(pb_passport).X < rd_passport.Right + 50 && Utils.CenterOf(pb_passport).X > rd_passport.Left)
            {
                pb_passport.Location = destPoints[0];
            }
            else
            {
                pb_passport.Location = OriginalPositions[0];
            }
        }

        private void pb_passport_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.mouseDrag(this, (Control)pb_passport, e, this.draggable[0], this.fixedPoints[0]);

        }

        private void pb_visa_MouseDown(object sender, MouseEventArgs e)
        {
            draggable[3] = true;
            fixedPoints[3] = new Point(e.X, e.Y);
        }

        private void pb_visa_MouseUp(object sender, MouseEventArgs e)
        {
            draggable[0] = false;
            if (Utils.CenterOf(pb_visa).X < rd_visa.Right + 50 && Utils.CenterOf(pb_visa).X > rd_visa.Left)
            {
                pb_visa.Location = destPoints[3];
            }
            else
            {
                pb_visa.Location = OriginalPositions[3];
            }
        }

        private void pb_visa_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.mouseDrag(this, (Control)pb_visa, e, this.draggable[3], this.fixedPoints[3]);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bool dragged = pb_passport.Location == destPoints[0]
                && pb_id.Location == destPoints[1]
                && pb_atmcard.Location == destPoints[2]
                && pb_visa.Location == destPoints[3];
            bool correct = rd_safepassport.Checked &&
                 rd_atmopened.Checked &&
                 !rd_visaok.Checked;

            if(!dragged || !correct)
            {
                MessageBox.Show( "答錯了", "再檢查一下", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                (new Items()).Show();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Document_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 確認關閉視窗
            Form1.Form1_FormClosing(sender, e);
        }
    }
}

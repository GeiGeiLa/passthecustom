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
namespace LetMePassTheCustom
{
    public partial class Document : Form
    {
        List<Point> OriginalPositions;
        List<bool> draggable;
        List<Point> fixedPoints;
        public Document()
        {
            InitializeComponent();
            OriginalPositions = new List<Point>();
            fixedPoints = new List<Point>();
            draggable = new List<bool>();
            draggable.Add(false);
            // 記錄所有圖片的初始位置
            foreach(var pb in this.Controls.OfType<PictureBox>())
            {
                OriginalPositions.Add(pb.Location);
                fixedPoints.Add(pb.Location);
            }
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
            draggable[0] = false;
            if(CenterOf(pb_id).X < )
            {

            }
        }

        private void pb_id_MouseMove(object sender, MouseEventArgs e)
        {
            mouseDrag((Control)pb_id, e, this.draggable[0], this.fixedPoints[0]);
        }

        private void pb_id_MouseDown(object sender, MouseEventArgs e)
        {
            draggable[0] = true;
            fixedPoints[0] = new Point(e.X, e.Y);
        }
        void mouseDrag(Control control, MouseEventArgs e, bool canDrag, Point oldPoint)
        {
            if(canDrag && e.Button == MouseButtons.Left)
            {
                int x = control.Left + (e.X - oldPoint.X);
                if(x > this.ClientSize.Width - control.Width)
                {
                    x = this.ClientSize.Width - control.Width;
                }
                x = (x < 0) ? 0 : x;
                control.Left = x;
                int y = control.Top + (e.Y - oldPoint.Y);
                if (y > this.ClientSize.Height - control.Height)
                {
                    y = this.ClientSize.Height - control.Height;
                }
                y = (y < 0) ? 0 : y;
                control.Top = y;
            }
        }
        Point CenterOf(Control control)
        {
            return new Point(
                control.Left + control.Width / 2,
                control.Top + control.Height / 2);
        }
    }
}

using LetMePassTheCustom.CustomLibs;
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
using System.Media;

namespace LetMePassTheCustom
{

    enum State { ready, bad, shoot};
    public partial class FastPass : Form
    {
        State state;
        PictureBox pb_in;
        Dictionary<string, Point> originalPoints, fixedPoints;
        Dictionary<string, bool> canDrag;
        Dictionary<string, PictureBox> pictureBoxes;
        Dictionary<string, PictureBox> TempContainer;
        readonly Point[] destRange;
        static string itempath = @"..\..\..\assets\fastpass\";
        public FastPass()
        {
            InitializeComponent();
            state = State.bad;
            TempContainer = new Dictionary<string, PictureBox>();
            originalPoints = new Dictionary<string, Point>();
            fixedPoints = new Dictionary<string, Point>();
            pictureBoxes = new Dictionary<string, PictureBox>();
            canDrag = new Dictionary<string, bool>();
            pb_human.Controls.Add(null);
            //destRange = new Point[]
            //{
            //    new Point()
            //}
            var cap = make_picturebox(Image.FromFile(itempath + "cap.png"), pb_human);
            cap.Location = new Point(532, 99);
            cap.Show();
            originalPoints.Add(nameof(cap), cap.Location);
            pictureBoxes.Add(nameof(cap), cap);
            canDrag.Add(nameof(cap), false);
            var glass = make_picturebox(Image.FromFile(itempath + "sunglasses.png"), pb_human);
            glass.Location = new Point(570, 164);
            glass.Show();
            canDrag.Add(nameof(glass), false);
            originalPoints.Add(nameof(glass), glass.Location);
            pictureBoxes.Add(nameof(glass), glass);
            var mask = make_picturebox(Image.FromFile(itempath + "themask.png"), pb_human);
            mask.Location = new Point(578, 179);
            mask.Show();
            originalPoints.Add(nameof(mask), mask.Location);
            pictureBoxes.Add(nameof(mask), mask);
            canDrag.Add(nameof(mask), false);
            var watch = make_picturebox(Image.FromFile(itempath + "watch.png"), pb_human);
            watch.Location = new Point(632, 357);
            watch.Show();
            originalPoints.Add(nameof(watch), watch.Location);
            pictureBoxes.Add(nameof(watch), watch);
            canDrag.Add(nameof(watch), false);
            var bag = make_picturebox(Image.FromFile(itempath + "bag.png"), pb_human);
            bag.Location = new Point(500, 370);
            bag.Show();
            originalPoints.Add(nameof(bag), bag.Location);
            pictureBoxes.Add(nameof(bag), bag);
            canDrag.Add(nameof(bag), false);
            Debug.WriteLine("now"+pictureBoxes.Count);
            addDelegates();
            foreach(var f in originalPoints)
            {
                fixedPoints.Add(f.Key, f.Value);
            }
            pb_temp.Parent = pb_human;
            lb_hint.Visible = false;
            pb_out.Visible = false;
            pb_perfect.Visible = false;
        }

        private void FastPass_Load(object sender, EventArgs e)
        { 
        }

        private void tab_preparing_Click(object sender, EventArgs e)
        {
            var cap = new PictureBox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        static PictureBox make_picturebox(Image img, PictureBox parent = null)
        {
            var pb = new PictureBox();
            pb.Image = img;
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            if(parent != null)
            {
                parent.Controls.Add(pb);
            }
            return pb;
        }
        void addDelegates()
        {
            Debug.WriteLine(pictureBoxes.Count());
            foreach(var pb in pictureBoxes)
            {
                pb.Value.BringToFront();
                pb.Value.MouseDown += delegate (object sender, MouseEventArgs e)
                {
                    Debug.WriteLine("MOUSEDOWN");
                    canDrag[pb.Key] = true;
                    fixedPoints[pb.Key] = new Point(e.X, e.Y);
                    
                };
                pb.Value.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    pb.Value.BringToFront();
                    Utils.mouseDrag(this, pb.Value, e, canDrag[pb.Key], fixedPoints[pb.Key]);
                };
                pb.Value.MouseUp += delegate (object sender, MouseEventArgs e)
                {
                    var center = Utils.CenterOf(pb.Value);
                    canDrag[pb.Key] = false;
                    if(center.X >= 750
                    && center.X <= 750 + pb_temp.Width
                    && center.Y >= 282
                    && center.Y <= 282 + pb_temp.Height)
                    {
                        if (!TempContainer.ContainsKey(pb.Key))
                        {
                            TempContainer.Add(pb.Key, pb.Value);
                        }
                    }
                    else
                    {
                        if(TempContainer.ContainsKey(pb.Key))
                        {
                            TempContainer.Remove(pb.Key);
                        }
                        pb.Value.Location = originalPoints[pb.Key];
                    }
                };
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string[] takeoff = { "cap","glass","mask" };
            int i = 0;
            foreach (var s in takeoff)
            {

                if (TempContainer.ContainsKey(s)) i++;
            }
            if(i == 3 && TempContainer.Count == 3)
            {
                if(!checkBox1.Checked)
                {
                    MessageBox.Show("你不符合辦理快速通關的資格", "錯誤",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("準備完成！請按開始標籤來拍照", "成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    state = State.ready;
                    initCamera();
                }
                
                
            }
            else
            {
                MessageBox.Show("不能遮到臉，也不要把非必要脫下的東西脫掉", "錯誤",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tab_start_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                MessageBox.Show("FUCK");
            }
        }

        private void tab_control_KeyDown(object sender, KeyEventArgs e)
        {
            if(state == State.ready)
            {
                if(e.KeyCode == Keys.W)
                {
                    pb_in.Location = new Point(pb_in.Location.X, pb_in.Location.Y + 7);
                }
                if(e.KeyCode == Keys.S)
                {
                    pb_in.Location = new Point(pb_in.Location.X, pb_in.Location.Y - 7);

                }
                if (e.KeyCode == Keys.A)
                {
                    pb_in.Location = new Point(pb_in.Location.X + 7, pb_in.Location.Y );

                }
                if (e.KeyCode == Keys.D)
                {
                    pb_in.Location = new Point(pb_in.Location.X - 7, pb_in.Location.Y);

                }
                if(pb_in.Location.X >= 550 && (pb_in.Location.X + pb_in.Width) <= (530 + pb_perfect.Width)
                    && pb_in.Location.Y >= 280 && pb_in.Location.Y + pb_in.Height <= (240 + pb_perfect.Height))
                {
                    state = State.shoot;
                    pb_out.Visible = false;
                    pb_in.Visible = false;
                    pb_perfect.Visible = true;
                    btn_shoot.Enabled = true;
                }
            }
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            using (var sound = new SoundPlayer(itempath + "shoot.wav"))
            {
                sound.Play();
            }
            MessageBox.Show("拍照完成！\n快速通關是永久有效的，你等海關的時間將會大幅減少！","太好了！",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("申辦快速通關的拍照方式就跟拍大頭貼一樣，把該脫的東西用滑鼠脫掉\r\n"+
                "即使在外面沒有事前申請，在機場也還是可以申請\r\n"+
                "而且在沒排隊的情下只要10分鐘的時間就可以辦好，而且還終身有效\r\n"+
                "這麼棒的東西不辦嗎？");
        }

        void initCamera()
        {
            lb_notready.Hide();
            lb_hint.Visible = true;
            pb_out.Visible = true;
            pb_perfect.Visible = false;
            var inst = new PictureBox();
            inst.Image = Image.FromFile(itempath + "in.png");
            inst.SizeMode = PictureBoxSizeMode.AutoSize;
            inst.BackColor = Color.Transparent;
            pb_out.Controls.Add(inst);
            inst.Show();
            pb_in = inst;
        }
    }
}

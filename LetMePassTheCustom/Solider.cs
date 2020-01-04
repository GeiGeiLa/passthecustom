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
    public partial class Solider : Form
    {
        public static bool ready = false;
        public Solider()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.ris.gov.tw/departure/app/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("你已經準備好了！","",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ready = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("再檢查一下！","",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("被宣判為免役的男人申請繳交免服兵役公文並且申請註銷兵役章，才可以合法出境。");
        }
    }
}

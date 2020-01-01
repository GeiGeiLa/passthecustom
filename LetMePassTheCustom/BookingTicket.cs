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
    public partial class BookingTicket : Form
    {
        public BookingTicket()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void BookingTicket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="3"&&
                comboBox2.Text=="1"&&comboBox3.Text=="2"&&
                comboBox4.Text=="否"&&checkBox1.Checked&&checkBox3.Checked&&!checkBox2.Checked
                ) {
                MessageBox.Show("答對了!!");
                this.Hide();
            } else {
                MessageBox.Show("答錯了!!再檢查一下吧!");
            }
        }
    }
}

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
    public partial class Passport : Form
    {

        public Passport()
        {
            InitializeComponent();

        }

        private void Passport_Load(object sender, EventArgs e)
        {
            lb_applyForPassport.Text = Texts.ApplyForPassport;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.boca.gov.tw/cp-56-3012-9e168-1.html");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            if(Feb.Checked)
            {
                lb_result.Text = "答案正確";
                next.Enabled = true;
                
            }
            else
            {
                lb_result.Text = "答錯了";
                next.Enabled = false;
            }
        }

        private void lb_result_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Document()).Show();
        }
    }
}

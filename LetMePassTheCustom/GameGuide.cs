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
    public partial class GameGuide : Form
    {
        public GameGuide()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void GameGuide_Load(object sender, EventArgs e)
        {
            lb_intro.Text = Texts.Introduction;

        }
    }
}

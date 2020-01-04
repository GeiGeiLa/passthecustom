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
    public partial class openedWindows : Form
    {
        public openedWindows()
        {
            InitializeComponent();
        }
        public static List<Form> Windows = new List<Form>();
    }
}

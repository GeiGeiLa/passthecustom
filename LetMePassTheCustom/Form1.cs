﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Passport()).Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Application.Run(new GameGuide());
            // 會發生例外狀況
            var gameGuide = new GameGuide();
            gameGuide.Show();
        }
    }
}

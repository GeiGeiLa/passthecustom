namespace LetMePassTheCustom
{
    partial class FastPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_preparing = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tab_start = new System.Windows.Forms.TabPage();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.lb_hint = new System.Windows.Forms.Label();
            this.lb_notready = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.pb_temp = new System.Windows.Forms.PictureBox();
            this.pb_human = new System.Windows.Forms.PictureBox();
            this.pb_perfect = new System.Windows.Forms.PictureBox();
            this.pb_out = new System.Windows.Forms.PictureBox();
            this.tab_control.SuspendLayout();
            this.tab_preparing.SuspendLayout();
            this.tab_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_human)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_out)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_preparing);
            this.tab_control.Controls.Add(this.tab_start);
            this.tab_control.Font = new System.Drawing.Font("微軟正黑體", 9.310345F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_control.Location = new System.Drawing.Point(12, 16);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1205, 739);
            this.tab_control.TabIndex = 0;
            this.tab_control.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tab_control_KeyDown);
            // 
            // tab_preparing
            // 
            this.tab_preparing.Controls.Add(this.pb_temp);
            this.tab_preparing.Controls.Add(this.pb_human);
            this.tab_preparing.Controls.Add(this.label1);
            this.tab_preparing.Controls.Add(this.button2);
            this.tab_preparing.Location = new System.Drawing.Point(4, 28);
            this.tab_preparing.Name = "tab_preparing";
            this.tab_preparing.Padding = new System.Windows.Forms.Padding(3);
            this.tab_preparing.Size = new System.Drawing.Size(1197, 707);
            this.tab_preparing.TabIndex = 0;
            this.tab_preparing.Text = "準備";
            this.tab_preparing.UseVisualStyleBackColor = true;
            this.tab_preparing.Click += new System.EventHandler(this.tab_preparing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.27586F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(406, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "請脫掉辦理快速通關不可佩戴之物品";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1048, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "準備好了";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tab_start
            // 
            this.tab_start.Controls.Add(this.btn_shoot);
            this.tab_start.Controls.Add(this.lb_hint);
            this.tab_start.Controls.Add(this.lb_notready);
            this.tab_start.Controls.Add(this.pb_perfect);
            this.tab_start.Controls.Add(this.pb_out);
            this.tab_start.Location = new System.Drawing.Point(4, 25);
            this.tab_start.Name = "tab_start";
            this.tab_start.Padding = new System.Windows.Forms.Padding(3);
            this.tab_start.Size = new System.Drawing.Size(1197, 710);
            this.tab_start.TabIndex = 1;
            this.tab_start.Text = "開始";
            this.tab_start.UseVisualStyleBackColor = true;
            this.tab_start.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tab_start_PreviewKeyDown);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Enabled = false;
            this.btn_shoot.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shoot.Location = new System.Drawing.Point(560, 640);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(121, 46);
            this.btn_shoot.TabIndex = 5;
            this.btn_shoot.Text = "拍照";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // lb_hint
            // 
            this.lb_hint.AutoSize = true;
            this.lb_hint.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_hint.Location = new System.Drawing.Point(379, 89);
            this.lb_hint.Name = "lb_hint";
            this.lb_hint.Size = new System.Drawing.Size(484, 37);
            this.lb_hint.TabIndex = 4;
            this.lb_hint.Text = "用WASD來移動身體，以便對準鏡頭";
            // 
            // lb_notready
            // 
            this.lb_notready.AutoSize = true;
            this.lb_notready.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_notready.Location = new System.Drawing.Point(370, 291);
            this.lb_notready.Name = "lb_notready";
            this.lb_notready.Size = new System.Drawing.Size(452, 37);
            this.lb_notready.TabIndex = 0;
            this.lb_notready.Text = "當您準備完成時，就可以開始查驗";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.310345F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 761);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "說明";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(202, 766);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(351, 27);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "我已滿 14 歲，而且身高至少有 140 公分";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check.Location = new System.Drawing.Point(1043, 765);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(167, 33);
            this.btn_check.TabIndex = 8;
            this.btn_check.Text = "準備完成";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // pb_temp
            // 
            this.pb_temp.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pb_temp.Image = global::LetMePassTheCustom.Properties.Resources.temp;
            this.pb_temp.Location = new System.Drawing.Point(750, 282);
            this.pb_temp.Name = "pb_temp";
            this.pb_temp.Size = new System.Drawing.Size(396, 278);
            this.pb_temp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_temp.TabIndex = 8;
            this.pb_temp.TabStop = false;
            this.pb_temp.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pb_human
            // 
            this.pb_human.BackgroundImage = global::LetMePassTheCustom.Properties.Resources.bg;
            this.pb_human.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_human.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_human.Image = global::LetMePassTheCustom.Properties.Resources.person;
            this.pb_human.Location = new System.Drawing.Point(3, 3);
            this.pb_human.Name = "pb_human";
            this.pb_human.Size = new System.Drawing.Size(1191, 701);
            this.pb_human.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_human.TabIndex = 3;
            this.pb_human.TabStop = false;
            // 
            // pb_perfect
            // 
            this.pb_perfect.Image = global::LetMePassTheCustom.Properties.Resources.perfect;
            this.pb_perfect.Location = new System.Drawing.Point(541, 269);
            this.pb_perfect.Name = "pb_perfect";
            this.pb_perfect.Size = new System.Drawing.Size(151, 151);
            this.pb_perfect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_perfect.TabIndex = 3;
            this.pb_perfect.TabStop = false;
            this.pb_perfect.Visible = false;
            // 
            // pb_out
            // 
            this.pb_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_out.Image = global::LetMePassTheCustom.Properties.Resources.out_whole;
            this.pb_out.Location = new System.Drawing.Point(3, 3);
            this.pb_out.Name = "pb_out";
            this.pb_out.Size = new System.Drawing.Size(1191, 704);
            this.pb_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_out.TabIndex = 1;
            this.pb_out.TabStop = false;
            // 
            // FastPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 806);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tab_control);
            this.Name = "FastPass";
            this.Text = "FastPass";
            this.Load += new System.EventHandler(this.FastPass_Load);
            this.tab_control.ResumeLayout(false);
            this.tab_preparing.ResumeLayout(false);
            this.tab_preparing.PerformLayout();
            this.tab_start.ResumeLayout(false);
            this.tab_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_human)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_preparing;
        private System.Windows.Forms.TabPage tab_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb_human;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lb_notready;
        private System.Windows.Forms.PictureBox pb_temp;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.PictureBox pb_perfect;
        private System.Windows.Forms.PictureBox pb_out;
        private System.Windows.Forms.Label lb_hint;
        private System.Windows.Forms.Button btn_shoot;
    }
}
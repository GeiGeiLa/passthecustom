namespace LetMePassTheCustom
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.lb_1 = new System.Windows.Forms.Label();
            this.rd_passport = new System.Windows.Forms.CheckBox();
            this.rd_id = new System.Windows.Forms.CheckBox();
            this.rd_atmcard = new System.Windows.Forms.CheckBox();
            this.rd_visa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_atmopened = new System.Windows.Forms.CheckBox();
            this.rd_safepassport = new System.Windows.Forms.CheckBox();
            this.rd_visaok = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_next = new System.Windows.Forms.Button();
            this.blank1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_visa = new System.Windows.Forms.PictureBox();
            this.pb_atmcard = new System.Windows.Forms.PictureBox();
            this.pb_id = new System.Windows.Forms.PictureBox();
            this.pb_passport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_visa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_atmcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_passport)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("微軟正黑體", 11.7931F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_1.Location = new System.Drawing.Point(308, 64);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(314, 24);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "請將圖片拖曳至對應的物品文字下方";
            this.lb_1.Click += new System.EventHandler(this.lb_1_Click);
            // 
            // rd_passport
            // 
            this.rd_passport.AutoSize = true;
            this.rd_passport.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rd_passport.Location = new System.Drawing.Point(81, 114);
            this.rd_passport.Name = "rd_passport";
            this.rd_passport.Size = new System.Drawing.Size(56, 19);
            this.rd_passport.TabIndex = 2;
            this.rd_passport.Text = "護照";
            this.rd_passport.UseVisualStyleBackColor = true;
            // 
            // rd_id
            // 
            this.rd_id.AutoSize = true;
            this.rd_id.Location = new System.Drawing.Point(264, 114);
            this.rd_id.Name = "rd_id";
            this.rd_id.Size = new System.Drawing.Size(71, 19);
            this.rd_id.TabIndex = 3;
            this.rd_id.Text = "身分證";
            this.rd_id.UseVisualStyleBackColor = true;
            // 
            // rd_atmcard
            // 
            this.rd_atmcard.AutoSize = true;
            this.rd_atmcard.Location = new System.Drawing.Point(468, 114);
            this.rd_atmcard.Name = "rd_atmcard";
            this.rd_atmcard.Size = new System.Drawing.Size(120, 19);
            this.rd_atmcard.TabIndex = 4;
            this.rd_atmcard.Text = "金融卡/信用卡";
            this.rd_atmcard.UseVisualStyleBackColor = true;
            // 
            // rd_visa
            // 
            this.rd_visa.AutoSize = true;
            this.rd_visa.Location = new System.Drawing.Point(743, 114);
            this.rd_visa.Name = "rd_visa";
            this.rd_visa.Size = new System.Drawing.Size(56, 19);
            this.rd_visa.TabIndex = 5;
            this.rd_visa.Text = "簽證";
            this.rd_visa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.7931F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(396, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "出國必備文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // rd_atmopened
            // 
            this.rd_atmopened.AutoSize = true;
            this.rd_atmopened.Location = new System.Drawing.Point(34, 605);
            this.rd_atmopened.Name = "rd_atmopened";
            this.rd_atmopened.Size = new System.Drawing.Size(354, 19);
            this.rd_atmopened.TabIndex = 10;
            this.rd_atmopened.Text = "(金融卡/信用卡)已開通(國外提款/國外交易)之功能";
            this.rd_atmopened.UseVisualStyleBackColor = true;
            // 
            // rd_safepassport
            // 
            this.rd_safepassport.AutoSize = true;
            this.rd_safepassport.Location = new System.Drawing.Point(34, 568);
            this.rd_safepassport.Name = "rd_safepassport";
            this.rd_safepassport.Size = new System.Drawing.Size(394, 19);
            this.rd_safepassport.TabIndex = 11;
            this.rd_safepassport.Text = "已準備至少一個護照影本+ 2 張 6 個月內之 2 吋大頭貼照";
            this.rd_safepassport.UseVisualStyleBackColor = true;
            // 
            // rd_visaok
            // 
            this.rd_visaok.AutoSize = true;
            this.rd_visaok.Checked = true;
            this.rd_visaok.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rd_visaok.Location = new System.Drawing.Point(34, 643);
            this.rd_visaok.Name = "rd_visaok";
            this.rd_visaok.Size = new System.Drawing.Size(236, 19);
            this.rd_visaok.TabIndex = 13;
            this.rd_visaok.Text = "我不知道入境某些國家需要簽證";
            this.rd_visaok.UseVisualStyleBackColor = true;
            this.rd_visaok.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(34, 688);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 15);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "免簽證資訊";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(786, 651);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(102, 44);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "下一步";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // blank1
            // 
            this.blank1.AutoSize = true;
            this.blank1.Location = new System.Drawing.Point(96, 253);
            this.blank1.Name = "blank1";
            this.blank1.Size = new System.Drawing.Size(41, 15);
            this.blank1.TabIndex = 16;
            this.blank1.Text = "label3";
            this.blank1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(34, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "遊戲進度";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_visa
            // 
            this.pb_visa.Image = global::LetMePassTheCustom.Properties.Resources.visa;
            this.pb_visa.Location = new System.Drawing.Point(419, 525);
            this.pb_visa.Name = "pb_visa";
            this.pb_visa.Size = new System.Drawing.Size(263, 178);
            this.pb_visa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_visa.TabIndex = 12;
            this.pb_visa.TabStop = false;
            this.pb_visa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_visa_MouseDown);
            this.pb_visa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_visa_MouseMove);
            this.pb_visa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_visa_MouseUp);
            // 
            // pb_atmcard
            // 
            this.pb_atmcard.Image = global::LetMePassTheCustom.Properties.Resources._20180718165455_8c570a02bf03ec8bf7323722ff8cb5bb_mobile;
            this.pb_atmcard.Location = new System.Drawing.Point(374, 534);
            this.pb_atmcard.Name = "pb_atmcard";
            this.pb_atmcard.Size = new System.Drawing.Size(224, 142);
            this.pb_atmcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_atmcard.TabIndex = 8;
            this.pb_atmcard.TabStop = false;
            this.pb_atmcard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_atmcard_MouseDown);
            this.pb_atmcard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_atmcard_MouseMove);
            this.pb_atmcard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_atmcard_MouseUp);
            // 
            // pb_id
            // 
            this.pb_id.Image = global::LetMePassTheCustom.Properties.Resources.ROC_ID_2005_specimen_front;
            this.pb_id.Location = new System.Drawing.Point(554, 455);
            this.pb_id.Name = "pb_id";
            this.pb_id.Size = new System.Drawing.Size(216, 132);
            this.pb_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_id.TabIndex = 7;
            this.pb_id.TabStop = false;
            this.pb_id.Click += new System.EventHandler(this.pb_id_Click);
            this.pb_id.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_id_MouseDown);
            this.pb_id.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_id_MouseMove);
            this.pb_id.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_id_MouseUp);
            // 
            // pb_passport
            // 
            this.pb_passport.Image = ((System.Drawing.Image)(resources.GetObject("pb_passport.Image")));
            this.pb_passport.Location = new System.Drawing.Point(400, 439);
            this.pb_passport.Name = "pb_passport";
            this.pb_passport.Size = new System.Drawing.Size(150, 208);
            this.pb_passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_passport.TabIndex = 1;
            this.pb_passport.TabStop = false;
            this.pb_passport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_passport_MouseDown);
            this.pb_passport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_passport_MouseMove);
            this.pb_passport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_passport_MouseUp);
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 737);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blank1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rd_visaok);
            this.Controls.Add(this.pb_visa);
            this.Controls.Add(this.rd_safepassport);
            this.Controls.Add(this.rd_atmopened);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_atmcard);
            this.Controls.Add(this.pb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rd_visa);
            this.Controls.Add(this.rd_atmcard);
            this.Controls.Add(this.rd_id);
            this.Controls.Add(this.rd_passport);
            this.Controls.Add(this.pb_passport);
            this.Controls.Add(this.lb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Document";
            this.Text = "Document";
            this.Load += new System.EventHandler(this.Document_Load);
            this.Click += new System.EventHandler(this.Document_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_visa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_atmcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_passport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.PictureBox pb_passport;
        private System.Windows.Forms.CheckBox rd_passport;
        private System.Windows.Forms.CheckBox rd_id;
        private System.Windows.Forms.CheckBox rd_visa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_id;
        private System.Windows.Forms.PictureBox pb_atmcard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rd_atmopened;
        private System.Windows.Forms.CheckBox rd_safepassport;
        private System.Windows.Forms.PictureBox pb_visa;
        private System.Windows.Forms.CheckBox rd_visaok;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label blank1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox rd_atmcard;
        private System.Windows.Forms.Button button1;
    }
}
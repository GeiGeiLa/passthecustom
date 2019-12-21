namespace LetMePassTheCustom
{
    partial class Passport
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
            this.lb_applyForPassport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.jan = new System.Windows.Forms.RadioButton();
            this.march = new System.Windows.Forms.RadioButton();
            this.check = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Feb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_applyForPassport
            // 
            this.lb_applyForPassport.AutoSize = true;
            this.lb_applyForPassport.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_applyForPassport.Location = new System.Drawing.Point(113, 73);
            this.lb_applyForPassport.Name = "lb_applyForPassport";
            this.lb_applyForPassport.Size = new System.Drawing.Size(148, 24);
            this.lb_applyForPassport.TabIndex = 0;
            this.lb_applyForPassport.Text = "請修改text (8/1)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(113, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "提示：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(174, 376);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(472, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.boca.gov.tw/cp-56-3012-9e168-1.html";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // jan
            // 
            this.jan.AutoSize = true;
            this.jan.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jan.Location = new System.Drawing.Point(117, 203);
            this.jan.Name = "jan";
            this.jan.Size = new System.Drawing.Size(58, 28);
            this.jan.TabIndex = 7;
            this.jan.Text = "1/1";
            this.jan.UseVisualStyleBackColor = true;
            // 
            // march
            // 
            this.march.AutoSize = true;
            this.march.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.march.Location = new System.Drawing.Point(117, 296);
            this.march.Name = "march";
            this.march.Size = new System.Drawing.Size(58, 28);
            this.march.TabIndex = 9;
            this.march.Text = "3/1";
            this.march.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.check.Location = new System.Drawing.Point(560, 415);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(86, 45);
            this.check.TabIndex = 10;
            this.check.Text = "檢查";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // next
            // 
            this.next.Enabled = false;
            this.next.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.next.Location = new System.Drawing.Point(659, 415);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 45);
            this.next.TabIndex = 11;
            this.next.Text = "下一步";
            this.next.UseVisualStyleBackColor = true;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_result.Location = new System.Drawing.Point(113, 340);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(86, 24);
            this.lb_result.TabIndex = 12;
            this.lb_result.Text = "作答結果";
            this.lb_result.Click += new System.EventHandler(this.lb_result_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(113, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "注意：若沒遵守此規定，將有機會被拒絕登機。";
            // 
            // Feb
            // 
            this.Feb.AutoSize = true;
            this.Feb.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Feb.Location = new System.Drawing.Point(117, 249);
            this.Feb.Name = "Feb";
            this.Feb.Size = new System.Drawing.Size(58, 28);
            this.Feb.TabIndex = 14;
            this.Feb.Text = "2/1";
            this.Feb.UseVisualStyleBackColor = true;
            // 
            // Passport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 497);
            this.Controls.Add(this.Feb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.next);
            this.Controls.Add(this.check);
            this.Controls.Add(this.march);
            this.Controls.Add(this.jan);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_applyForPassport);
            this.Name = "Passport";
            this.Text = "申請護照";
            this.Load += new System.EventHandler(this.Passport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_applyForPassport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton jan;
        private System.Windows.Forms.RadioButton march;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Feb;
    }
}
namespace LetMePassTheCustom
{
    partial class GameGuide
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_intro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "遊戲介紹";
            // 
            // lb_intro
            // 
            this.lb_intro.AutoSize = true;
            this.lb_intro.Font = new System.Drawing.Font("微軟正黑體", 11.17241F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_intro.Location = new System.Drawing.Point(196, 197);
            this.lb_intro.Name = "lb_intro";
            this.lb_intro.Size = new System.Drawing.Size(230, 24);
            this.lb_intro.TabIndex = 1;
            this.lb_intro.Text = "請修改Texts.Introduction";
            this.lb_intro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_intro.Click += new System.EventHandler(this.label2_Click);
            // 
            // GameGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 620);
            this.Controls.Add(this.lb_intro);
            this.Controls.Add(this.label1);
            this.Name = "GameGuide";
            this.Text = "GameGuide";
            this.Load += new System.EventHandler(this.GameGuide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_intro;
    }
}
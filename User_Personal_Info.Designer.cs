namespace Billing_System
{
    partial class User_Personal_Info
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Personal_Info));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sign_Out = new System.Windows.Forms.Button();
            this.btn_Personal_Info = new System.Windows.Forms.Button();
            this.Pic_Headpic = new System.Windows.Forms.PictureBox();
            this.lab_Email = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Headpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "消费账号";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 911);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_Sign_Out);
            this.panel2.Controls.Add(this.btn_Personal_Info);
            this.panel2.Controls.Add(this.Pic_Headpic);
            this.panel2.Controls.Add(this.lab_Email);
            this.panel2.Controls.Add(this.lab_Name);
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 728);
            this.panel2.TabIndex = 2;
            // 
            // btn_Sign_Out
            // 
            this.btn_Sign_Out.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Sign_Out.FlatAppearance.BorderSize = 0;
            this.btn_Sign_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign_Out.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Sign_Out.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sign_Out.Location = new System.Drawing.Point(3, 547);
            this.btn_Sign_Out.Name = "btn_Sign_Out";
            this.btn_Sign_Out.Size = new System.Drawing.Size(774, 90);
            this.btn_Sign_Out.TabIndex = 2;
            this.btn_Sign_Out.Text = "退出账号";
            this.btn_Sign_Out.UseVisualStyleBackColor = false;
            this.btn_Sign_Out.Click += new System.EventHandler(this.btn_Sign_Out_Click);
            // 
            // btn_Personal_Info
            // 
            this.btn_Personal_Info.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Personal_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personal_Info.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Personal_Info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Personal_Info.Location = new System.Drawing.Point(3, 436);
            this.btn_Personal_Info.Name = "btn_Personal_Info";
            this.btn_Personal_Info.Size = new System.Drawing.Size(774, 90);
            this.btn_Personal_Info.TabIndex = 2;
            this.btn_Personal_Info.Text = "修改个人信息";
            this.btn_Personal_Info.UseVisualStyleBackColor = false;
            this.btn_Personal_Info.Click += new System.EventHandler(this.btn_Personal_Info_Click);
            // 
            // Pic_Headpic
            // 
            this.Pic_Headpic.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Headpic.Image")));
            this.Pic_Headpic.Location = new System.Drawing.Point(297, 42);
            this.Pic_Headpic.Name = "Pic_Headpic";
            this.Pic_Headpic.Size = new System.Drawing.Size(180, 190);
            this.Pic_Headpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Headpic.TabIndex = 0;
            this.Pic_Headpic.TabStop = false;
            // 
            // lab_Email
            // 
            this.lab_Email.Font = new System.Drawing.Font("隶书", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Email.Location = new System.Drawing.Point(3, 303);
            this.lab_Email.Name = "lab_Email";
            this.lab_Email.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lab_Email.Size = new System.Drawing.Size(769, 54);
            this.lab_Email.TabIndex = 1;
            this.lab_Email.Text = "106778****@qq.com";
            this.lab_Email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_Name
            // 
            this.lab_Name.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Name.Location = new System.Drawing.Point(3, 249);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(769, 54);
            this.lab_Name.TabIndex = 1;
            this.lab_Name.Text = "奋斗蚂蚁";
            this.lab_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // User_Personal_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "User_Personal_Info";
            this.Size = new System.Drawing.Size(790, 911);
            this.Load += new System.EventHandler(this.User_Personal_Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Headpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_Headpic;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_Email;
        private System.Windows.Forms.Button btn_Personal_Info;
        private System.Windows.Forms.Button btn_Sign_Out;
    }
}

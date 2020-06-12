namespace Billing_System
{
    partial class User_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.text_Uid = new System.Windows.Forms.TextBox();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.check_Aoto_Login = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Sign_in = new System.Windows.Forms.Button();
            this.lab_Uid_Tips = new System.Windows.Forms.Label();
            this.lab_Pwd_Tips = new System.Windows.Forms.Label();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.btn_UId = new MyControls.TriangleButton();
            this.lab_Error_Tips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Uid
            // 
            resources.ApplyResources(this.text_Uid, "text_Uid");
            this.text_Uid.Name = "text_Uid";
            this.text_Uid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // text_pwd
            // 
            resources.ApplyResources(this.text_pwd, "text_pwd");
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // check_Aoto_Login
            // 
            resources.ApplyResources(this.check_Aoto_Login, "check_Aoto_Login");
            this.check_Aoto_Login.ForeColor = System.Drawing.Color.Gray;
            this.check_Aoto_Login.Name = "check_Aoto_Login";
            this.check_Aoto_Login.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // btn_Sign_in
            // 
            this.btn_Sign_in.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_Sign_in, "btn_Sign_in");
            this.btn_Sign_in.ForeColor = System.Drawing.Color.White;
            this.btn_Sign_in.Name = "btn_Sign_in";
            this.btn_Sign_in.UseVisualStyleBackColor = false;
            this.btn_Sign_in.Click += new System.EventHandler(this.btn_Sign_in_Click);
            // 
            // lab_Uid_Tips
            // 
            resources.ApplyResources(this.lab_Uid_Tips, "lab_Uid_Tips");
            this.lab_Uid_Tips.BackColor = System.Drawing.Color.Transparent;
            this.lab_Uid_Tips.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lab_Uid_Tips.ForeColor = System.Drawing.Color.Silver;
            this.lab_Uid_Tips.Name = "lab_Uid_Tips";
            this.lab_Uid_Tips.Click += new System.EventHandler(this.lab_Uid_Tips_Click);
            // 
            // lab_Pwd_Tips
            // 
            resources.ApplyResources(this.lab_Pwd_Tips, "lab_Pwd_Tips");
            this.lab_Pwd_Tips.BackColor = System.Drawing.Color.Transparent;
            this.lab_Pwd_Tips.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lab_Pwd_Tips.ForeColor = System.Drawing.Color.Silver;
            this.lab_Pwd_Tips.Name = "lab_Pwd_Tips";
            this.lab_Pwd_Tips.Click += new System.EventHandler(this.lab_Uid_Tips_Click);
            // 
            // metroContextMenu1
            // 
            resources.ApplyResources(this.metroContextMenu1, "metroContextMenu1");
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Name = "metroContextMenu1";
            // 
            // btn_UId
            // 
            this.btn_UId.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btn_UId, "btn_UId");
            this.btn_UId.Name = "btn_UId";
            this.btn_UId.UseVisualStyleBackColor = false;
            this.btn_UId.Click += new System.EventHandler(this.btn_UId_Click);
            // 
            // lab_Error_Tips
            // 
            resources.ApplyResources(this.lab_Error_Tips, "lab_Error_Tips");
            this.lab_Error_Tips.ForeColor = System.Drawing.Color.Firebrick;
            this.lab_Error_Tips.Name = "lab_Error_Tips";
            // 
            // User_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lab_Error_Tips);
            this.Controls.Add(this.btn_UId);
            this.Controls.Add(this.lab_Pwd_Tips);
            this.Controls.Add(this.btn_Sign_in);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.check_Aoto_Login);
            this.Controls.Add(this.text_pwd);
            this.Controls.Add(this.lab_Uid_Tips);
            this.Controls.Add(this.text_Uid);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "User_Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_Uid;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.CheckBox check_Aoto_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Sign_in;
        private System.Windows.Forms.Label lab_Uid_Tips;
        private System.Windows.Forms.Label lab_Pwd_Tips;
        private MyControls.TriangleButton btn_UId;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.Label lab_Error_Tips;
    }
}

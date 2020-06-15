using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.BLL;
using System.Diagnostics;

namespace Billing_System
{
    public partial class User_Personal_Info : UserControl
    {
        public User_Personal_Info()
        {
            InitializeComponent();
        }
        #region 全局变量
        /// <summary>
        /// 宽度
        /// </summary>
        public int width = 0;
        /// <summary>
        /// Label变量
        /// </summary>
        public Label label;
        /// <summary>
        /// PictureBox变量
        /// </summary>
        public PictureBox pictureBox;
        /// <summary>
        /// 容器属性
        /// </summary>
        public Panel panel { get; set; }
        #endregion

        #region 布局方法
        /// <summary>
        /// 布局方法
        /// </summary>
        private void SetLayout()
        {
            int x = width / 2;
            panel2.Location = new Point(x - 200, panel2.Location.Y);
        }
        #endregion

        #region 设置图片框为圆形方法
        /// <summary>
        /// 设置图片框为圆形方法
        /// </summary>
        private void SetPictruea()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(this.Pic_Headpic.ClientRectangle);
            Region region = new Region(gp);
            this.Pic_Headpic.Region = region;
            gp.Dispose();
            region.Dispose();
        }
        #endregion

        #region 用户控件加载事件
        private void User_Personal_Info_Load(object sender, EventArgs e)
        {
            SetLayout();
            SetPictruea();

        }
        #endregion

        #region 修改个人信息
        private void btn_Personal_Info_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 退出账号
        private void btn_Sign_Out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("注销此账号?", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                label.Text = "未登录";
                string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Form_pictrue\\ch07.png";
                pictureBox.Load(path);
                panel.Controls.Clear();
                User_Login login = new User_Login();
                login.Dock = DockStyle.Fill;
                login.panel = panel;
                panel.Controls.Add(login);
            }
        }
        #endregion

       
    }
}

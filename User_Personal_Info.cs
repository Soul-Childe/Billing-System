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

namespace Billing_System
{
    public partial class User_Personal_Info : UserControl
    {
        public User_Personal_Info()
        {
            InitializeComponent();
        }
        #region 全局变量
        public int width = 0;
        public Label label;
        public PictureBox pictureBox;
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
            gp.AddEllipse(this.pic3.ClientRectangle);
            Region region = new Region(gp);
            this.pic3.Region = region;
            gp.Dispose();
            region.Dispose();
        }
        #endregion

        #region Load
        private void User_Personal_Info_Load(object sender, EventArgs e)
        {
            SetLayout();
            SetPictruea();

        }
        #endregion

        #region 退出账号
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("注销此账号?", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                label.Text = "未登录";
                string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase+"Form_pictrue\\ch06.png";
                pictureBox.Load(path);// = Image.FromFile(path);
            }
        }
        #endregion
    }
}

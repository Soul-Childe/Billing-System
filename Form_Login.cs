using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class Form_Login : MetroFramework.Forms.MetroForm
    {
        public Form_Login()
        {
            InitializeComponent();

        }

        #region 窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            SetPictrue(Pic_Head_Pic);
            if (Login_User.user_Info != null)//已登陆
            {
                User_Personal_Info user_Personal_Info = new User_Personal_Info();
                user_Personal_Info.Dock = DockStyle.Fill;
                user_Personal_Info.width = panel2.Width;
                MyControl.lab_Name = lab_Name;
                MyControl.panel = panel2;
                MyControl.Pic_Head_Pic = Pic_Head_Pic;
                panel2.Controls.Add(user_Personal_Info);
            }
            else//未登录
            {
                User_Login login = new User_Login();
                login.Dock = DockStyle.Fill;
                login.Width = panel2.Width;
                MyControl.lab_Name = lab_Name;
                MyControl.panel = panel2;
                MyControl.Pic_Head_Pic = Pic_Head_Pic;
                panel2.Controls.Add(login);
            }
        }
        #endregion 

        #region 设置图片框为圆形方法
        /// <summary>
        /// 设置图片框为圆形方法
        /// </summary>
        private void SetPictrue(PictureBox pictureBox)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox.ClientRectangle);
            Region region = new Region(gp);
            pictureBox.Region = region;
            gp.Dispose();
            region.Dispose();
        }
        #endregion


        private void label_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                Label label = (Label)flowLayoutPanel1.Controls[i];
                if (((Label)sender).Name == label.Name)
                {
                    label.BackColor = Color.FromArgb(50, Color.AliceBlue); //设置半透明和背景颜色
                    label.ForeColor = Color.White;
                }
                else
                {
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.LightGray;
                }
            } 
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = ((Label)sender);
            label.ForeColor = Color.White;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = ((Label)sender);
            label.ForeColor = Color.LightGray;
        }

        #region Label控件 用户名称点击事件
        private void lab_Name_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            if (Login_User.user_Info != null)//已登陆
            {
                User_Personal_Info user_Personal_Info = new User_Personal_Info();
                user_Personal_Info.Dock = DockStyle.Fill;
                user_Personal_Info.width = panel2.Width;
                MyControl.lab_Name = lab_Name;
                MyControl.panel = panel2;
                MyControl.Pic_Head_Pic = Pic_Head_Pic;
                panel2.Controls.Add(user_Personal_Info);
            }
            else//未登录
            {
                User_Login login = new User_Login();
                login.Dock = DockStyle.Fill;
                login.Width = panel2.Width;
                MyControl.lab_Name = lab_Name;
                MyControl.panel = panel2;
                MyControl.Pic_Head_Pic = Pic_Head_Pic;
                panel2.Controls.Add(login);
            }
        }
        #endregion 
    }
}

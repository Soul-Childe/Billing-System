using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Model;
using System.BLL;

namespace Billing_System
{
    public partial class User_Login : UserControl
    {
        public User_Login()
        {
            InitializeComponent();
            text_Uid.LostFocus += TextBox_LostFocus;
            text_pwd.LostFocus += TextBox_LostFocus;
            text_Uid.GotFocus += TextBox_GotFocus;
            text_pwd.GotFocus += TextBox_GotFocus;
        }

        #region 文本框失去焦点事件
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == "text_Uid" && textBox.Text.Length <= 0)
            {
                lab_Uid_Tips.Visible = true;
            }
            if (textBox.Name == "text_pwd" && textBox.Text.Length <= 0)
            {
                lab_Pwd_Tips.Visible = true;
            }
        }
        #endregion

        #region 文本框获取焦点事件
        private void TextBox_GotFocus(object sender,EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == "text_Uid" )
            {
                lab_Uid_Tips.Visible = false;
            }
            if (textBox.Name == "text_pwd")
            {
                lab_Pwd_Tips.Visible = false;
            }
        }
        #endregion

        #region 文本框获取焦点事件
        #endregion

        #region 水印Label提示点击事件
        private void lab_Uid_Tips_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Name == "lab_Uid_Tips")
            {
                text_Uid.Focus();
                lab_Uid_Tips.Visible = false;
            }
            else
            {
                text_pwd.Focus();
                lab_Pwd_Tips.Visible = false;
            }
        }
        #endregion

        #region 用户控件加载事件
        private void User_Login_Load(object sender, EventArgs e)
        {            
            btn_Sign_in.BackColor = Color.FromArgb(98,Color.DodgerBlue);
            for (int i = 0; i < 3; i++)
            {
                metroContextMenu1.Items.Add("aaaaaaaaaaaaaa").AutoSize=false;
                metroContextMenu1.Items[i].Width = 298;
                metroContextMenu1.Items[i].Click += ContetextMenu_Click;
            }
        }
        #endregion

        #region 下拉菜单点击事件
        private void ContetextMenu_Click(object sender,EventArgs e)
        {
           ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            text_Uid.Text = menu.Text;
            if (text_Uid.Text.Length > 0)
                lab_Uid_Tips.Visible = false;
        }
        #endregion 

        #region 文本框释放按键事件
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (text_Uid.Text.Length > 0 && text_pwd.Text.Length > 0)
            {
                lab_Uid_Tips.Visible = text_Uid.Text.Length > 0 ? false : true;
                lab_Pwd_Tips.Visible = text_pwd.Text.Length > 0 ? false : true;
                btn_Sign_in.BackColor = Color.DodgerBlue;
                btn_Sign_in.Enabled = true;
            }
            else
            {
                btn_Sign_in.BackColor = Color.FromArgb(98, Color.DodgerBlue);
                btn_Sign_in.Enabled = false;
            }
        }
        #endregion

        #region 三角形按钮点击事件
        private void btn_UId_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(btn_UId,new Point(text_Uid.Location.X-502,text_Uid.Location.Y-124));
        }
        #endregion

        #region 登录
        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            List<register_info> list = bll.DataQueryMethod<register_info>();

        }
        #endregion 
    }
}

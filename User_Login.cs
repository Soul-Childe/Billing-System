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
using System.Xml;
using System.Configuration;

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
        #region 全局变量
        /// <summary>
        /// LoginConfig配置文件路径
        /// </summary>
        string path = Application.StartupPath + "\\LoginConfig.xml";
        /// <summary>
        /// LoginConfig配置文件元素对象
        /// </summary>
        XmlDocument document = new XmlDocument();
        /// <summary>
        /// LoginConfig配置文件Login节点
        /// </summary>
        XmlNode login = null;
        /// <summary>
        /// 密码
        /// </summary>
        string pwd;
        /// <summary>
        /// 是否为输入密码
        /// </summary>
        bool istrue;
        /// <summary>
        /// 容器控件
        /// </summary>
        public Panel panel { get; set; }
        #endregion

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
            document.Load(path);
            login = document.SelectSingleNode("root").SelectSingleNode("Login");
            foreach (XmlNode item in login.ChildNodes)
            {
                ToolStripMenuItem toolStrip = new ToolStripMenuItem();
                toolStrip.Text = item.FirstChild.InnerText;
                toolStrip.AutoSize = false;
                toolStrip.Width = 298;
                toolStrip.Height = 30;
                toolStrip.Font = new Font("黑体",18);
                toolStrip.Click += ContetextMenu_Click;
                metroContextMenu1.Items.Add(toolStrip);
                metroContextMenu1.Height += toolStrip.Height;

            }
        }
        #endregion

        #region 下拉菜单点击事件
        private void ContetextMenu_Click(object sender,EventArgs e)
        {
           ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            text_Uid.Text = menu.Text;
            text_pwd.Text = "";
            //便利login下的所有row节点
            foreach (XmlNode item in login.ChildNodes)
            {
                if(item.FirstChild.InnerText==menu.Text)
                {
                    for (int i = 0; i < int.Parse(item.ChildNodes[2].InnerText); i++)
                    {
                        text_pwd.Text += "*";
                    }
                    pwd = item.ChildNodes[1].InnerText;
                    istrue = true;
                }
            }
            if (text_Uid.Text.Length > 0)
            {
                lab_Uid_Tips.Visible = false;
                lab_Pwd_Tips.Visible = false;
                btn_Sign_in.Enabled = true;
                btn_Sign_in.BackColor = Color.DodgerBlue;
            }
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
                if (istrue == false)
                    pwd = bll.MD5Encryption(text_pwd.Text);
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
            string[] vs = new string[] { " and (phone='"+text_Uid.Text+"' or email='"+ text_Uid.Text+"') and [password]='"+pwd+"' " };
            register_info info = bll.DataQuery<register_info>(vs);
            if(info!=null)
            {
                //自动登录
                if (check_Aoto_Login.Checked == true)
                {
                    try
                    {
                        foreach (XmlNode item in login.ChildNodes)
                        {
                            //当前为row节点
                            if (item.FirstChild.InnerText == text_Uid.Text)
                            {
                                login.RemoveChild(item);
                                document.Save(path);
                            }
                        }
                        //添加row节点
                        XmlNode row = document.CreateElement("row");
                        XmlNode uid = document.CreateElement("uid");
                        XmlNode pwd = document.CreateElement("pwd");
                        XmlNode pwdLen = document.CreateElement("pwdLen");
                        XmlNode date = document.CreateElement("date");
                        uid.InnerText = text_Uid.Text;
                        pwd.InnerText = bll.MD5Encryption(text_pwd.Text);
                        pwdLen.InnerText = text_pwd.Text.Length.ToString();
                        date.InnerText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        row.AppendChild(uid);
                        row.AppendChild(pwd);
                        row.AppendChild(pwdLen);
                        row.AppendChild(date);
                        login.AppendChild(row);
                        document.Save(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }                 
                }
                panel.Controls.Clear();
                User_Personal_Info user_Personal_Info = new User_Personal_Info();
                user_Personal_Info.Dock = DockStyle.Fill;
                user_Personal_Info.width = panel.Width;
                //user_Personal_Info.label = lab_Name;
               // user_Personal_Info.pictureBox = Pic_Head_Pic;
                //user_Personal_Info.panel = panel2;
                panel.Controls.Add(user_Personal_Info);
            }
            else
            {
                lab_Error_Tips.Visible = true;
                return;
            }
          

        }
        #endregion 
    }
}

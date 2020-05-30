using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPictrue();            
        }


        private void myButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("adf");
        }



        #region 设置图片框为圆形方法
        /// <summary>
        /// 设置图片框为圆形方法
        /// </summary>
        private void SetPictrue()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(this.pictureBox2.ClientRectangle);
            Region region = new Region(gp);
            this.pictureBox2.Region = region;
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
    }
}

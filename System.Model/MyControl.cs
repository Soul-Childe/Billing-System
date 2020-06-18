using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Model
{
    /// <summary>
    /// 控件对象类
    /// </summary>
    public class MyControl
    {
        /// <summary>
        /// 主界面的Label名字
        /// </summary>
        public static Windows.Forms.Label lab_Name { get; set; }
        /// <summary>
        /// 主界面的picturebox头像
        /// </summary>
        public static PictureBox Pic_Head_Pic { get; set; }
        /// <summary>
        /// 主界面的容器
        /// </summary>
        public static Panel panel { get; set; }
        public MyControl()
        {

        }
        public MyControl(Label label,PictureBox pictureBox,Panel panel1)
        {
            lab_Name = label;
            Pic_Head_Pic = pictureBox;
            panel = panel1;
        }
    }
}

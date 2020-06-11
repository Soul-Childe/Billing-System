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

namespace MyControls
{
    public partial class TriangleButton : Button
    {
        public TriangleButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.CreateGraphics().DrawLine(Pens.Black, new Point(100, 100), new Point(200, 200));
            this.Refresh();
            GraphicsPath gp = new GraphicsPath();
            List<PointF> arrPoints = new List<PointF>();
            arrPoints.Add(new PointF(5, 15));
            arrPoints.Add(new PointF(20, 15));
            arrPoints.Add(new PointF(12.5F, 22.5f));
            gp.AddLines(arrPoints.ToArray());
            gp.CloseFigure();
            this.CreateGraphics().DrawPath(Pens.Black, gp);
            Region r = new Region(gp);
            this.Region = r;
            this.BackColor = Color.RoyalBlue;
        }
    }
}

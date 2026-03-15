using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WenDingpku
{
    public partial class Display : Form
    {
        #region 字段

        private List<MapObject.Point> mTempPoints;

        #endregion

        #region 构造函数

        public Display()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗口时间管理

        public void Display_Load(object sender, EventArgs e)
        {
            mTempPoints = CreatePoints();
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {
            DrawPoints(e.Graphics);
        }

        #endregion

        #region 私有方法

        private List<MapObject.Point> CreatePoints()
        {
            Random sRnd = new Random();

            List<MapObject.Point> sTempPoints = new List<MapObject.Point>();
            for (int i = 0; i < 100; i++)
            {
                double x = sRnd.NextDouble() * this.Width;
                double y = sRnd.NextDouble() * this.Height;
                MapObject.Point sPoint = new MapObject.Point(x, y, 0);
                sTempPoints.Add(sPoint);
            }

            return sTempPoints;
        }

        private void DrawPoints(Graphics g)
        {
            SolidBrush sBrush = new SolidBrush(Color.Red);
            for (int i = 0; i <= mTempPoints.Count - 1; i++)
            {
                DrawPoint(g, mTempPoints[i]);
            }
        }

        private void DrawPoint(Graphics g, MapObject.Point point)
        {
            SolidBrush sBrush = new SolidBrush(Color.Red);
            RectangleF sRect = new RectangleF(
                                (float)point.X - 3,
                                (float)point.Y - 3,
                                6, 6
                                );
            g.FillEllipse(sBrush, sRect);
            sBrush.Dispose();
        }

        #endregion

    }
}

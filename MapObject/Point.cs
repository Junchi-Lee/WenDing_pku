using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapObject
{
    /// <summary>
    /// 继承自Geometry类
    /// 表示一个点对象
    /// </summary>
    public class Point: Geometry
    {
        #region 字段

        private double _X; // X坐标
        private double _Y; // Y坐标
        private double _Z = 0; // Z坐标, 默认为0

        #endregion

        #region 构建函数

        /// <summary>
        /// Point类的构造函数，接受X、Y、Z坐标参数，默认为原点
        /// </summary>
        /// <param name="x"> X坐标，默认为0 </param>
        /// <param name="y"> Y坐标，默认为0 </param>
        /// <param name="z"> Z坐标，默认为0 </param>
        public Point(double x = 0, double y = 0, double z = 0)
        {
            _X = x;
            _Y = y;
            _Z = z;
        }

        #endregion

        #region 属性

        /// <summary>
        /// Point类的X坐标，可以通过get和set访问和修改
        /// </summary>
        public double X
        {
            get { return _X; }
            set { _X = value; }
        }
        /// <summary>
        /// Point类的Y坐标，可以通过get和set访问和修改
        /// </summary>
        public double Y
        {
            get { return _Y; }
            set { _Y = value; }
        }
        /// <summary>
        /// Point类的Z坐标，可以通过get和set访问和修改
        /// </summary>
        public double Z
        {
            get { return _Z; }
            set { _Z = value; }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 克隆当前Point对象
        /// </summary>
        /// <returns>一个新的Point实例</returns>
        public Point Clone()
        {
            return new Point(X, Y, Z);
        }

        /// <summary>
        /// 输出Point对象的字符串表示，格式为"Point(X, Y, Z)"，其中X、Y、Z分别是Point的坐标
        /// </summary>
        /// <returns>字符串"Point(X, Y, Z)"</returns>
        public override string ToString()
        {
            return "Point(" + X + ", " + Y + ", " + Z + ")";
        }
        #endregion
    }
}

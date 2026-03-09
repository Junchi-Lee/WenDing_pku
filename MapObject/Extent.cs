using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapObject
{
    /// <summary>
    /// 继承自Shape类，
    /// 表示一个矩形/长方体范围，
    /// 注意：不是一个具体的矩形/长方体对象，而是一个抽象的范围，可以用来表示地图上的一个区域或者一个图层的边界等
    /// 默认情况下为2D范围，即Z坐标默认为0，如果需要表示3D范围，可以通过设置Z坐标来实现
    /// </summary>
    public class Extent:Shape
    {
        #region 字段
    
        private double _MinX; // 最小X坐标
        private double _MaxX; // 最大X坐标
        private double _MinY; // 最小Y坐标
        private double _MaxY; // 最大Y坐标

        private double _MinZ = 0; // 最小Z坐标，默认为0
        private double _MaxZ = 0; // 最大Z坐标，默认为0

        #endregion

        #region 构建函数

        /// <summary>
        /// Extent的构造函数，默认为原点处的一个零范围
        /// </summary>
        /// <param name="minX"> Extent的最小X坐标，默认为0 </param>
        /// <param name="maxX"> Extent的最大X坐标，默认为0 </param>
        /// <param name="minY"> Extent的最小Y坐标，默认为0 </param>
        /// <param name="maxY"> Extent的最大Y坐标，默认为0 </param>
        /// <param name="minZ"> Extent的最小Z坐标，默认为0 </param>
        /// <param name="maxZ"> Extent的最大Z坐标，默认为0 </param>
        public Extent(double minX = 0, double maxX = 0, double minY = 0, double maxY = 0, double minZ = 0, double maxZ = 0)
        {
            _MinX = minX;
            _MaxX = maxX;
            _MinY = minY;
            _MaxY = maxY;
            _MinZ = minZ;
            _MaxZ = maxZ;
        }
        #endregion

        #region 属性

        /// <summary>
        /// Extent的最小X坐标，可以通过get和set访问和修改
        /// </summary>
        public double MinX
        {
            get { return _MinX; }
            set { _MinX = value; }
        }

        /// <summary>
        /// Extent的最大X坐标，可以通过get和set访问和修改
        /// </summary>
        public double MaxX
        {
            get { return _MaxX; }
            set { _MaxX = value; }
        }

        /// <summary>
        /// Extent的最小Y坐标，可以通过get和set访问和修改
        /// </summary>
        public double MinY
        {
            get { return _MinY; }
            set { _MinY = value; }
        }

        /// <summary>
        /// Extent的最大Y坐标，可以通过get和set访问和修改
        /// </summary>
        public double MaxY
        {
            get { return _MaxY; }
            set { _MaxY = value; }
        }

        /// <summary>
        /// Extent的最小X坐标，可以通过get和set访问和修改
        /// </summary>
        public double MinZ
        {
            get { return _MinZ; }
            set { _MinZ = value; }
        }

        /// <summary>
        /// Extent的最大Z坐标，可以通过get和set访问和修改
        /// </summary>
        public double MaxZ
        {
            get { return _MaxZ; }
            set { _MaxZ = value; }
        }

        /// <summary>
        /// Extent的水平宽度，即最大X坐标与最小X坐标之差，可以通过get访问，不能修改
        /// </summary>
        public double Width
        {
            get { return _MaxX - _MinX; }
        }

        /// <summary>
        /// Extent的水平高度，即最大Y坐标与最小Y坐标之差，可以通过get访问，不能修改
        /// </summary>
        public double Height
        {
            get { return _MaxY - _MinY; }
        }

        /// <summary>
        /// Extent的垂直高度，即最大Z坐标与最小Z坐标之差，可以通过get访问，不能修改
        /// </summary>
        public double Depth
        {
            get { return _MaxZ - _MinZ; }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 克隆当前Extent对象
        /// </summary>
        /// <returns> 一个新的Extent实例 </returns>
        public Extent Clone()
        {
            return new Extent(_MinX, _MaxX, _MinY, _MaxY, _MinZ, _MaxZ);

        }

        /// <summary>
        /// 输出当前Extent对象的字符串表示，格式为"Extent(MinX: x, MaxX: x, MinY: y, MaxY: y, MinZ: z, MaxZ: z)"
        /// </summary>
        /// <returns> 字符串"Extent(MinX: x, MaxX: x, MinY: y, MaxY: y, MinZ: z, MaxZ: z)"</returns>
        public override string ToString()
        {
            return "Extent(MinX: " + MinX + ", MaxX: " + MaxX + ", MinY: " + MinY + ", MaxY: " + MaxY + ", MinZ: " + MinZ + ", MaxZ: " + MaxZ + ")";
        }
        #endregion

    }
}

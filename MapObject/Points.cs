using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapObject
{
    /// <summary>
    /// 多点对象，表示点的集合
    /// </summary>
    public class Points
    {
        #region 字段

        private List<Point> _Points; // 点的集合

        #endregion

        #region 构造函数

        /// <summary>
        /// 空构造函数，初始化一个空的点集合
        /// </summary>
        public Points()
        {
            _Points = new List<Point>();
        }

        /// <summary>
        /// 从一个点的列表构造Points对象，接受一个List<Point>类型的参数，并将其赋值给_Points字段
        /// </summary>
        /// <param name="points">List<Point> </param>
        public Points(List<Point> points)
        {
            _Points = points;
        }

        /// <summary>
        /// 从一个点的数组构造Points对象，接受一个Point[]类型的参数，并将其转换为List<Point>类型赋值给_Points字段
        /// </summary>
        /// <param name="points">Point[]</param>
        public Points(Point[] points)
        {
            _Points = new List<Point>();
            _Points.AddRange(points);
        }
        #endregion

        #region 属性

        public Int32 Count
        {
            get { return _Points.Count; }
        
        }

        public Extent Extent
        {
            get { return GetExtent(); }
        }
        #endregion

        #region 方法

        /// <summary>
        /// 获取指定索引位置的点
        /// </summary>
        /// <param name="index">点在集合中的索引位置</param>
        /// <returns>返回指定索引位置的Point对象</returns>
        public Point GetItem(Int32 index)
        {
            return _Points[index]; 
        }

        /// <summary>
        /// 向点集合中添加一个点
        /// </summary>
        /// <param name="point">要添加的Point对象</param>
        public void Add(Point point)
        {
            _Points.Add(point);
        }

        /// <summary>
        /// 向点集合中批量添加多个点
        /// </summary>
        /// <param name="points">要添加的点数组</param>
        public void AddRange(Point[] points)
        {
            _Points.AddRange(points);
        }

        /// <summary>
        /// 在指定索引位置插入一个点
        /// </summary>
        /// <param name="index">要插入的索引位置</param>
        /// <param name="point">要插入的Point对象</param>
        public void Insert(Int32 index, Point point)
        {
            _Points.Insert(index, point);
        }

        /// <summary>
        /// 删除指定索引位置的点
        /// </summary>
        /// <param name="index">要删除的点的索引位置</param>
        public void RemoveAt(Int32 index)
        {
            _Points.RemoveAt(index);
        }
        /// <summary>
        /// 清空点集合中的所有点
        /// </summary>
        public void Clear()
        {
            _Points.Clear();
        }

        /// <summary>
        /// 将点集合转换为点数组
        /// </summary>
        /// <returns>返回包含所有点的数组</returns>
        public Point[] ToArray()
        {
            return _Points.ToArray();
        }

        /// <summary>
        /// 克隆当前点集合对象，创建一个包含相同点的新Points对象
        /// </summary>
        /// <returns>返回克隆后的Points对象</returns>
        public Points Clone()
        {
            return new Points(new List<Point>(_Points));
        }


        /// <summary>
        /// 获取点集的范围，计算点集合中所有点的最小和最大坐标值，并返回一个Extent对象表示范围
        /// </summary>
        /// <returns> Extent对象</returns>
        public Extent GetExtent()
        {
            double minX = double.MaxValue;
            double minY = double.MaxValue;
            double maxX = double.MinValue;
            double maxY = double.MinValue;
            double minZ = double.MaxValue;
            double maxZ = double.MinValue;

            foreach (var point in _Points)
            {
                if (point.X < minX) minX = point.X;
                if (point.X > maxX) maxX = point.X;
                if (point.Y < minY) minY = point.Y;
                if (point.Y > maxY) maxY = point.Y;
                if (point.Z < minZ) minZ = point.Z;
                if (point.Z > maxZ) maxZ = point.Z;
            }

            return new Extent
            {
                MinX = minX,
                MaxX = maxX,
                MinY = minY,
                MaxY = maxY,
                MinZ = minZ,
                MaxZ = maxZ
            };
        }
        #endregion
    }
}

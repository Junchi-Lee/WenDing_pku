using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapObject
{
    /// <summary>
    /// 多部件对象，表示多个点集合（Points）的集合
    /// </summary>
    public class Parts
    {
        #region 字段

        private List<Points> _Parts; // 部件集合
        #endregion

        #region 构造函数

        /// <summary>
        /// 空构造函数，初始化一个空的部件集合
        /// </summary>
        public Parts()
        {
            _Parts = new List<Points>();
        }

        /// <summary>
        /// 从一个部件数组构造Parts对象，并将其转换为List<Points>赋值给_Parts字段
        /// </summary>
        /// <param name="parts">Points数组</param>
        public Parts(Points[] parts)
        {
            _Parts = new List<Points>();
            _Parts.AddRange(parts);
        }

        #endregion

        #region 属性

        /// <summary>
        /// 获取部件数量
        /// </summary>
        public Int32 Count
        {
            get { return _Parts.Count; }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 获取指定索引位置的部件
        /// </summary>
        /// <param name="index">部件在集合中的索引位置</param>
        /// <returns>返回指定索引位置的Points对象</returns>
        public Points GetItem(Int32 index)
        {
            return _Parts[index];
        }

        /// <summary>
        /// 设置指定索引位置的部件
        /// </summary>
        /// <param name="index">要设置的索引位置</param>
        /// <param name="part">要设置的Points对象</param>
        public void SetItem(Int32 index, Points part)
        {
            _Parts[index] = part;
        }

        /// <summary>
        /// 向部件集合中添加一个部件
        /// </summary>
        /// <param name="part">要添加的Points对象</param>
        public void Add(Points part)
        {
            _Parts.Add(part);
        }

        /// <summary>
        /// 向部件集合中批量添加多个部件
        /// </summary>
        /// <param name="parts">要添加的Points数组</param>
        public void AddRange(Points[] parts)
        {
            _Parts.AddRange(parts);
        }

        /// <summary>
        /// 在指定索引位置插入一个部件
        /// </summary>
        /// <param name="index">要插入的索引位置</param>
        /// <param name="part">要插入的Points对象</param>
        public void Insert(Int32 index, Points part)
        {
            _Parts.Insert(index, part);
        }

        /// <summary>
        /// 删除指定索引位置的部件
        /// </summary>
        /// <param name="index">要删除的部件的索引位置</param>
        public void RemoveAt(Int32 index)
        {
            _Parts.RemoveAt(index);
        }

        /// <summary>
        /// 清空部件集合中的所有部件
        /// </summary>
        public void Clear()
        {
            _Parts.Clear();
        }

        /// <summary>
        /// 克隆当前Parts对象，创建一个包含相同部件（深拷贝Points）的新Parts对象
        /// </summary>
        /// <returns>返回克隆后的Parts对象</returns>
        public Parts Clone()
        {
            Parts clone = new Parts();
            foreach (Points part in _Parts)
            {
                clone.Add(part.Clone());
            }
            return clone;
        }

        #endregion
    }
}

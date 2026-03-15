using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapObject
{
    
    public class Parts
    {
        #region 字段

        private List<Points> _Parts;
        #endregion

        #region 构造函数

        public Parts()
        {
            _Parts = new List<Points>();
        }

        public Parts(Points[] parts)
        {
            _Parts = new List<Points>();
            _Parts.AddRange(parts);
        }


        #endregion

        #region 属性

        public Int32 Count
        {
            get { return _Parts.Count; }
        }

        #endregion

        #region 方法

        public Points GetItem(Int32 index)
        {
            return _Parts[index]; 
        }

        public void SetItem(Int32 index, Points part)
        {
            _Parts[index] = part;
        }

        public void Add(Points part)
        {
            _Parts.Add(part);
        }

        public void AddRange(Points[] parts)
        {
            _Parts.AddRange(parts);
        }

        public void Insert(Int32 index, Points part)
        {
            _Parts.Insert(index, part);
        }

        public void RemoveAt(Int32 index)
        {
            _Parts.RemoveAt(index);
        }

        public void Clear()
        {
            _Parts.Clear(); 
        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetMePassTheCustom
{
    /// <summary>
    /// 設定允許攜帶的類型
    /// </summary>
    public enum Bring {
            /// <summary>任意</summary>
        All,
            /// <summary> 只能託運 </summary>
        Checkin,
            /// <summary>只能隨身攜帶</summary>
        Carryon,
            /// <summary> 違禁品</summary>
        Forbidden
    };
    /// <summary>
    /// 物件 class
    /// </summary>
    public class ItemClass: Form
    {
        public readonly string itemName;
        /// <summary>允許攜帶的方式</summary>
        public readonly Bring canBring;
        public readonly int weight;
        public string comment;
        public ItemClass(string name, Bring allowtype, int w, string cmt="")
        {
            itemName = name; canBring = allowtype; weight = w; comment = cmt;
        }
        public PictureBox Picture;
    }
    public abstract class Container
    {
        Bring bringMethod;
        int capacity;
        List<ItemClass> myitem;
        public Container(Bring b, int c)
        {
            bringMethod = b; capacity = c;
        }
        public virtual Bring BringMethod
        {
            get { return bringMethod; }
            set { bringMethod = value; }
        }
        public virtual int Capacity
        {
            get { return Capacity; }
            set
            {
                if (value < 0) throw new Exception("容量不能是負的");
                capacity = value;
            }
        }
        public virtual List<ItemClass> MyItems
        {
            get { return myitem; }
        }

    }
    /// <summary>這是背包</summary>
    public class Backpack : Container
    {
        public Backpack(Bring b, int c) : base(b, c)
        {

        }
    }
    /// <summary>這是行李</summary>
    public class Lugguage : Container
    {
        public Lugguage(Bring b, int c) : base(b, c)
        {

        }
    }
}

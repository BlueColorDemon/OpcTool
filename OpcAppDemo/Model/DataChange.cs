using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcAppDemo.Model
{
    /// <summary>
    /// 线程参数封装
    /// </summary>
    public class DataChangeModel
    {
        public int TransactionID { get; set; }
        public int NumItems { get; set; }
        public Array ClientHandles { get; set; }
        public Array ItemValues { get; set; }
        public Array Qualities { get; set; }
        public Array TimeStamps { get; set; }
    }
}

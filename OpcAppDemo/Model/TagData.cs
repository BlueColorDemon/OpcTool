using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcAppDemo.Model
{
    /// <summary>
    /// Tag数据实体
    /// </summary>
    public class TagData
    {

        public int Id { get; set; }
        public string ServerName { get; set; }
        public string AliasName { get; set; }
        public string TagValue { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

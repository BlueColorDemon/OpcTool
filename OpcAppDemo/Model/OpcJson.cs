using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcAppDemo.Model
{
    /// <summary>
    /// OpcJson模型
    /// </summary>
    public class OpcJson
    {
        public OpcJson()
        {
            DefaultGroupIsActive = true;
            DefaultGroupDeadband = 0;
            UpdateRate = 250;
            IsActive = true;
            IsSubscribed = true;
        }

        /// <summary>
        /// 主机IP
        /// </summary>
        public string HostIP { get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServerName { get; set; }

        #region 组属性

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool DefaultGroupIsActive { get; set; }
        /// <summary>
        /// 死区
        /// </summary>
        public int DefaultGroupDeadband { get; set; }
        /// <summary>
        /// 更新频率
        /// </summary>
        public int UpdateRate { get; set; }
        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// 是否订阅Group事件(订阅式/异步读写时必须为true)
        /// </summary>
        public bool IsSubscribed { get; set; }

        #endregion

        /// <summary>
        /// 变量列表
        /// </summary>
        public List<string> AliasList { get; set; }
    }
}

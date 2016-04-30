using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcAppDemo.Common
{
    /// <summary>
    /// 配置信息
    /// </summary>
    public static class ConfigInfo
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        /// <summary>
        /// opcJson文件名
        /// </summary>
        public static string OpcJson = ConfigurationManager.AppSettings["OpcJson"];
        /// <summary>
        /// opcJson文件名
        /// </summary>
        public static string UpdateRate = ConfigurationManager.AppSettings["UpdateRate"];
    }
}

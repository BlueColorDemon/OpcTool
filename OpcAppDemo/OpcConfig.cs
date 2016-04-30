using Newtonsoft.Json;
using OpcAppDemo.Common;
using OpcAppDemo.Model;
using OPCAutomation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpcAppDemo
{
    public partial class OpcConfig : Form
    {
        public OpcConfig()
        {
            InitializeComponent();
        }

        #region 私有变量
        /// <summary>
        /// OPCServer Object
        /// </summary>
        OPCServer KepServer;
        /// <summary>
        /// OPCGroups Object
        /// </summary>
        OPCGroups KepGroups;
        /// <summary>
        /// OPCGroup Object
        /// </summary>
        OPCGroup KepGroup;
        /// <summary>
        /// OPCItems Object
        /// </summary>
        OPCItems KepItems;
        /// <summary>
        /// OPCItem Object
        /// </summary>
        OPCItem KepItem;
        /// <summary>
        /// 主机IP
        /// </summary>
        string strHostIP = "";
        /// <summary>
        /// 主机名称
        /// </summary>
        string strHostName = "";
        /// <summary>
        /// 连接状态
        /// </summary>
        bool opc_connected = false;
        /// <summary>
        /// 客户端句柄
        /// </summary>
        int itmHandleClient = 0;
        /// <summary>
        /// 服务端句柄
        /// </summary>
        int itmHandleServer = 0;
        #endregion

        #region 功能函数

        /// <summary>
        /// 枚举本地OPC服务器
        /// </summary>
        private void GetLocalServer()
        {
            strHostName = Dns.GetHostName();

            var mIPHostEntry = Dns.GetHostEntry(strHostName);
            strHostIP = mIPHostEntry.AddressList[1].ToString();

            txtRemoteServerIP.Text = strHostIP;
            cmbServerName.Items.Clear();

            //获取本地计算机上的OPCServerName
            try
            {
                KepServer = new OPCServer();
                object serverList = KepServer.GetOPCServers(strHostName);


                foreach (string turn in (Array)serverList)
                {
                    cmbServerName.Items.Add(turn);
                }

                cmbServerName.SelectedIndex = 0;
                btnConnServer.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("枚举本地OPC服务器出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// 连接服务器
        /// </summary>
        private void ConnectServer()
        {
            try
            {
                if (!ConnectRemoteServer(txtRemoteServerIP.Text, cmbServerName.Text))
                {
                    return;
                }

                opc_connected = true;

                GetServerInfo();

                RecurBrowse(KepServer.CreateBrowser());
                btnSaveConfig.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("初始化出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 连接OPC服务器
        /// </summary>
        /// <param name="remoteServerIP">OPCServerIP</param>
        /// <param name="remoteServerName">OPCServer名称</param>
        private bool ConnectRemoteServer(string remoteServerIP, string remoteServerName)
        {
            try
            {
                KepServer.Connect(remoteServerName, remoteServerIP);

                if (KepServer.ServerState == (int)OPCServerState.OPCRunning)
                {
                    tsslServerState.Text = "已连接到-" + KepServer.ServerName + "   ";
                }
                else
                {
                    //这里你可以根据返回的状态来自定义显示信息，请查看自动化接口API文档
                    tsslServerState.Text = "状态：" + KepServer.ServerState.ToString() + "   ";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("连接远程服务器出现错误：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取服务器信息，并显示在窗体状态栏上
        /// </summary>
        private void GetServerInfo()
        {
            tsslServerStartTime.Text = "开始时间:" + KepServer.StartTime.ToString() + "    ";
            tsslversion.Text = "版本:" + KepServer.MajorVersion.ToString() + "." + KepServer.MinorVersion.ToString() + "." + KepServer.BuildNumber.ToString();
        }

        /// <summary>
        /// 列出OPC服务器中所有节点
        /// </summary>
        /// <param name="oPCBrowser"></param>
        private void RecurBrowse(OPCBrowser oPCBrowser)
        {
            listboxAlias.Items.Clear();
            //展开分支
            oPCBrowser.ShowBranches();
            //展开叶子
            oPCBrowser.ShowLeafs(true);
            foreach (object turn in oPCBrowser)
            {
                listboxAlias.Items.Add(turn.ToString());
            }
        }

        /// <summary>
        /// 保存配置文件
        /// </summary>
        private void SaveConfig()
        {
            List<string> aliasList = new List<string>();
            foreach (var item in listboxAlias.Items)
            {
                aliasList.Add(item.ToString());
            }
            var mOpcJson = new OpcJson()
            {
                HostIP = strHostIP,
                HostName = strHostName,
                ServerName = cmbServerName.SelectedItem.ToString(),
                UpdateRate = Convert.ToInt32(ConfigInfo.UpdateRate),
                AliasList = aliasList
            };

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigInfo.OpcJson);

            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, mOpcJson);
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        private void Disconnect()
        {

            btnConnServer.Enabled = false;
            btnSaveConfig.Enabled = false;
            if (!opc_connected)
            {
                return;
            }

            if (KepServer != null)
            {
                KepServer.Disconnect();
                KepServer = null;
            }

            opc_connected = false;
        }

        #endregion

        #region 窗台按钮事件

        private void OpcConfig_Load(object sender, EventArgs e)
        {
            GetLocalServer();
        }

        private void btnRefreshLoacalServer_Click(object sender, EventArgs e)
        {
            Disconnect();
            GetLocalServer();
        }

        private void btnConnServer_Click(object sender, EventArgs e)
        {
            ConnectServer();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfig();
            this.Close();
        }

        private void OpcConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void listboxAlias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTagName.Text = listboxAlias.SelectedItem.ToString();
        }

        #endregion

    }
}

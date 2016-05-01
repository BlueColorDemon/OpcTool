///@说明
///@开发环境：vs2015
///@.Net framework版本：  4.5
///@Opc相关库：OPCDAAuto.dll
///@Nugget库：Newtonsoft.Json
///@Opc服务模拟器：MatrikonOPC Server for Simulation，ICONICS Simulator OPC Server 3.12
///@数据库sql文件：CreateTable.sql
///
///@完成时间：2016-5-1 12:24:48
///
///@作者：蓝色
///@QQ：214909012
///@Emnail：   214909012@qq.com
///请保留原作者信息
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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpcAppDemo
{
    public partial class Main : Form
    {
        /// <summary>
        /// Opc-配置
        /// </summary>
        OpcJson mOpcJson = new OpcJson();

        public Main()
        {
            InitializeComponent();
        }

        #region 委托

        public delegate void dele_txtTagValue(string text);

        public delegate void dele_txtQualities(string text);

        public delegate void dele_txtTimeStamps(string text);

        public delegate void dele_rtxtRecord(string text);

        dele_txtTagValue mdele_txtTagValue;

        dele_txtQualities mdele_txtQualities;

        dele_txtTimeStamps mdele_txtTimeStamps;

        dele_rtxtRecord mdele_rtxtRecord;

        #endregion

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
        /// 初始化
        /// </summary>
        private void Init()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigInfo.OpcJson);

            //判断Opc-配置文件是否存在
            if (File.Exists(filePath))
            {
                this.rtxtRecord.Text = "";
                this.rtxtRecordDb.Text = "";
                // deserialize JSON directly from a file
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    mOpcJson = (OpcJson)serializer.Deserialize(file, typeof(OpcJson));
                }

                txtHostIP.Text = mOpcJson.HostIP;
                txtHostName.Text = mOpcJson.HostName;
                txtServerName.Text = mOpcJson.ServerName;

                listboxAlias.Items.Clear();
                foreach (var item in mOpcJson.AliasList)
                {
                    listboxAlias.Items.Add(item);
                }

                if (ConnectServer())
                {
                    btnReadDb.Enabled = true;
                    btnWriteDb.Enabled = true;
                    btnWrite.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Opc-配置不存在，请先配置！", "提示信息");
                var opcConfig = new OpcConfig();
                opcConfig.ShowDialog();
                Init();
            }
        }

        /// <summary>
        /// 连接服务器
        /// </summary>
        private bool ConnectServer()
        {
            try
            {
                if (!ConnectRemoteServer(txtHostIP.Text, txtServerName.Text))
                {
                    return false;
                }

                opc_connected = true;

                GetServerInfo();

                if (!CreateGroup())
                {
                    return false;
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("初始化出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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
        /// 创建组
        /// </summary>
        private bool CreateGroup()
        {
            try
            {
                KepGroups = KepServer.OPCGroups;
                KepGroup = KepGroups.Add("BlueColorOpcClient01");
                SetGroupProperty();
                KepGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange);
                KepGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(KepGroup_AsyncWriteComplete);
                KepItems = KepGroup.OPCItems;
            }
            catch (Exception err)
            {
                MessageBox.Show("创建组出现错误：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 设置组属性
        /// </summary>
        private void SetGroupProperty()
        {
            KepServer.OPCGroups.DefaultGroupIsActive = mOpcJson.DefaultGroupIsActive;
            KepServer.OPCGroups.DefaultGroupDeadband = mOpcJson.DefaultGroupDeadband;
            KepGroup.UpdateRate = mOpcJson.UpdateRate;
            KepGroup.IsActive = mOpcJson.IsActive;
            KepGroup.IsSubscribed = mOpcJson.IsSubscribed;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        private void Disconnect()
        {
            //btnConnServer.Enabled = false;
            //btnSaveConfig.Enabled = false;
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

        /// <summary>
        /// 订阅事件数据处理
        /// </summary>
        private void DataChange(object obj)
        {
            var dcm = obj as DataChangeModel;

            //为了测试，所以加了控制台的输出，来查看事物ID号
            //Console.WriteLine("********" + TransactionID.ToString() + "*********");
            for (int i = 1; i <= dcm.NumItems; i++)
            {
                this.txtTagValue.Invoke(mdele_txtTagValue, new object[] { dcm.ItemValues.GetValue(i).ToString() });
                this.txtQualities.Invoke(mdele_txtQualities, new object[] { dcm.Qualities.GetValue(i).ToString() });
                this.txtTimeStamps.Invoke(mdele_txtTimeStamps, new object[] { dcm.TimeStamps.GetValue(i).ToString() });
                string str1 = "Tag值：" + dcm.ItemValues.GetValue(i).ToString() + "\t";
                string str2 = "品质：" + dcm.Qualities.GetValue(i).ToString() + "\t";
                string str3 = "时间戳：" + dcm.TimeStamps.GetValue(i).ToString();
                this.rtxtRecord.Invoke(mdele_rtxtRecord, new object[] { str1 + str2 + str3 + "\r\n" });
            }
        }

        #endregion

        #region opc事件

        /// <summary>
        /// 写入TAG值时执行的事件
        /// </summary>
        /// <param name="TransactionID"></param>
        /// <param name="NumItems"></param>
        /// <param name="ClientHandles"></param>
        /// <param name="Errors"></param>
        void KepGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array Errors)
        {
            lblState.Text = "";
            for (int i = 1; i <= NumItems; i++)
            {
                lblState.Text += "Tran:" + TransactionID.ToString() + "   CH:" + ClientHandles.GetValue(i).ToString() + "   Error:" + Errors.GetValue(i).ToString();
            }
        }

        /// <summary>
        /// 每当项数据有变化时执行的事件
        /// </summary>
        /// <param name="TransactionID">处理ID</param>
        /// <param name="NumItems">项个数</param>
        /// <param name="ClientHandles">项客户端句柄</param>
        /// <param name="ItemValues">TAG值</param>
        /// <param name="Qualities">品质</param>
        /// <param name="TimeStamps">时间戳</param>
        void KepGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            var obj = new DataChangeModel()
            {
                TransactionID = TransactionID,
                NumItems = NumItems,
                ClientHandles = ClientHandles,
                ItemValues = ItemValues,
                Qualities = Qualities,
                TimeStamps = TimeStamps
            };
            ThreadPool.QueueUserWorkItem(new WaitCallback(DataChange), obj);
        }
        #endregion

        #region 窗体按钮事件

        private void Main_Load(object sender, EventArgs e)
        {
            KepServer = new OPCServer();
            mdele_txtTagValue = delegate (string text)
            {
                this.txtTagValue.Text = text;
            };
            mdele_txtQualities = delegate (string text)
            {
                this.txtQualities.Text = text;
            };
            mdele_txtTimeStamps = delegate (string text)
            {
                this.txtTimeStamps.Text = text;
            };
            mdele_rtxtRecord = delegate (string text)
            {
                this.rtxtRecord.Text += text;
            };
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }


        private void tbtnInit_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void tbtnOpcConfig_Click(object sender, EventArgs e)
        {
            var opcConfig = new OpcConfig();
            opcConfig.ShowDialog();
            Init();
        }


        private void btnWriteDb_Click(object sender, EventArgs e)
        {
            if (listboxAlias.SelectedIndex < 0)
            {
                MessageBox.Show("未选中变量！", "提示信息");
            }
            else
            {
                try
                {
                    //注意array在函数内部做参数时，数据下标是从1开始的所以要考虑将第0位空出来，n个Item，就要定义n+1列数组，添加一个0，但在函数使用时，又是从左开始读取的。(针对opc)
                    //否则会报错
                    OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
                    int[] temp = new int[2] { 0, bItem.ServerHandle };
                    Array serverHandles = (Array)temp;
                    Array values;
                    Array Errors;
                    object qualities;
                    object timeStamps;
                    KepGroup.SyncRead(1, 1, ref serverHandles, out values, out Errors, out qualities, out timeStamps);

                    bool result = (Errors.GetValue(1).ToString() == "0") ? true : false;
                    object tagValue = values.GetValue(1);

                    if (result)
                    {
                        int addResult = TagDataOper.Add(new TagData()
                        {
                            ServerName = txtServerName.Text,
                            AliasName = listboxAlias.SelectedItem.ToString(),
                            TagValue = tagValue.ToString()
                        });
                        if (addResult == 1)
                        {
                            MessageBox.Show("入库成功！", "提示信息");
                        }
                        else
                        {
                            MessageBox.Show("入库失败！", "提示信息");
                        }
                    }
                    GC.Collect();
                }
                catch (Exception err)
                {
                }

            }
        }

        private void btnReadDb_Click(object sender, EventArgs e)
        {
            if (listboxAlias.SelectedIndex < 0)
            {
                MessageBox.Show("未选中变量！", "提示信息");
            }
            else
            {
                List<TagData> list = TagDataOper.Read(txtServerName.Text, listboxAlias.SelectedItem.ToString());
                this.rtxtRecordDb.Text = "";
                foreach (var item in list)
                {
                    string str1 = "Tag值：" + item.TagValue + "\t";
                    string str4 = "入库时间：" + item.CreateTime.ToString();
                    this.rtxtRecordDb.Text += str1 + str4 + "\r\n";
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (listboxAlias.SelectedIndex < 0)
            {
                MessageBox.Show("未选中变量！", "提示信息");
            }
            else
            {
                OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
                int[] temp = new int[2] { 0, bItem.ServerHandle };
                Array serverHandles = (Array)temp;
                object[] valueTemp = new object[2] { "", txtWriteTagValue.Text };
                Array values = (Array)valueTemp;
                Array Errors;
                int cancelID;
                KepGroup.AsyncWrite(1, ref serverHandles, ref values, out Errors, 2009, out cancelID);
                GC.Collect();
            }
        }


        private void listboxAlias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (itmHandleClient != 0)
                {
                    this.txtTagValue.Text = "";
                    this.txtQualities.Text = "";
                    this.txtTimeStamps.Text = "";

                    Array Errors;
                    OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
                    //注：OPC中以1为数组的基数
                    int[] temp = new int[2] { 0, bItem.ServerHandle };
                    Array serverHandle = (Array)temp;
                    //移除上一次选择的项
                    KepItems.Remove(KepItems.Count, ref serverHandle, out Errors);
                }
                itmHandleClient = 1234;
                KepItem = KepItems.AddItem(listboxAlias.SelectedItem.ToString(), itmHandleClient);
                itmHandleServer = KepItem.ServerHandle;
            }
            catch (Exception err)
            {
                //没有任何权限的项，都是OPC服务器保留的系统项，此处可不做处理。
                itmHandleClient = 0;
                txtTagValue.Text = "Error ox";
                txtQualities.Text = "Error ox";
                txtTimeStamps.Text = "Error ox";
                MessageBox.Show("此项为系统保留项:" + err.Message, "提示信息");
            }
        }

        private void rtxtRecord_TextChanged(object sender, EventArgs e)
        {
            this.rtxtRecord.Focus();
            int p = rtxtRecord.TextLength;
            rtxtRecord.Select(p - 2, p - 1);
        }

        private void rtxtRecordDb_TextChanged(object sender, EventArgs e)
        {
            this.rtxtRecord.Focus();
            int p = rtxtRecord.TextLength;
            rtxtRecord.Select(p - 2, p - 1);
        }

        #endregion

        private void Main_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}

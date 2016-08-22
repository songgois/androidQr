using BarcodeScan.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BarcodeScan
{

    
    public partial class FormMain : Form
    {
        Encoding encode = Encoding.Default;
        SynchronizationContext m_SyncContext = null;
        int port = 12345;
        bool isRun = true;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_SyncContext = SynchronizationContext.Current;
            Thread thread = new Thread(run);
            thread.Start();     
        }

        //线程方法
        private void run()
        {          
            Socket listenSocket = 
                new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            listenSocket.Listen(100);
            while (isRun)
            {
                Socket acceptSocket = listenSocket.Accept();
                string receiveData = Receive(acceptSocket, 5000);
                m_SyncContext.Post(Add, receiveData);
                DestroySocket(acceptSocket);
            }
        }

        //更新UI 实际业务处理逻辑放这儿
        private void Add(Object barcode){
            string bar = barcode.ToString() + "\r\n";
            new BarcodeHandlerImpl().Post(bar);
            if (radioButtonList.Checked)
            {
                textBoxReceive.AppendText(bar);
            }
            else
            {
                SendKeys.Send(bar);
            }

            if (notifyIcon.Visible)
            {
                notifyIcon.BalloonTipText = bar;
                notifyIcon.ShowBalloonTip(300);
            }
        }

        //接收数据
        private  string Receive(Socket socket, int timeout)
        {
            string result = string.Empty;
            socket.ReceiveTimeout = timeout;
            List<byte> data = new List<byte>();
            byte[] buffer = new byte[1024];
            int length = 0;
            try
            {
                while ((length = socket.Receive(buffer)) > 0)
                {
                    for (int j = 0; j < length; j++)
                    {
                        data.Add(buffer[j]);
                    }
                    if (length < buffer.Length)
                    {
                        break;
                    }
                }
            }
            catch { }
            if (data.Count > 0)
            {
                result = encode.GetString(data.ToArray(), 0, data.Count);
            }
            return result;
        }

        //关闭接收端Socket
        private static void DestroySocket(Socket socket)
        {
            if (socket.Connected)
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            socket.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRun = false;
            System.Environment.Exit(0);
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
    }
}

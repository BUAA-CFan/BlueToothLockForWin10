using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;

namespace BluetoothLock
{
    public partial class Form1 : Form
    {
        private BluetoothRadio Radio;
        private BluetoothClient client = new BluetoothClient();
        private BluetoothClient discoryClient = new BluetoothClient();
        private bool isConnected = false;
        private System.Timers.Timer discoryTimer = new System.Timers.Timer();
        private bool isSearching = false;
        private bool isReconnect = false;
        

        public Form1()
        {
            InitializeComponent();
            this.notifyIcon_Main.Visible = true;
            this.discoryTimer.Interval = 5000;

            this.FormClosing += Form1_FormClosing;
            this.notifyIcon_Main.DoubleClick += NotifyIcon1_DoubleClick;
            this.button_Exit.Click += Button_Exit_Click;
            this.discoryTimer.Elapsed += DiscoryTimer_Elapsed;
            this.toolStripMenuItem_Show.Click += ToolStripMenuItem_Show_Click;
            this.toolStripMenuItem_Exit.Click += ToolStripMenuItem_Exit_Click;
            
            
            this.button_DisConnect.Click += Button_DisConnect_Click;

            if(BluetoothRadio.PrimaryRadio!=null)
            {
                Radio = BluetoothRadio.PrimaryRadio;
                this.button_Connect.Click += Button_Connect_Click;
                //this.timer.Start();
                this.discoryTimer.Start();
            }
            else
            {
                this.notifyIcon_Main.BalloonTipText = "电脑没开蓝牙啊！！！";
                this.notifyIcon_Main.ShowBalloonTip(5);

            }
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.notifyIcon_Main.Visible = false;
            this.Dispose();
            this.Close();
        }

        private void ToolStripMenuItem_Show_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                //this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;



            }
        }

        private void DiscoryTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.discoryTimer.Enabled = false;

            if (!isSearching)
            {
                discoryClient.BeginDiscoverDevices(5, true, true, false, true, DiscoryComplete, new object());
                this.isSearching = true;


            }
        }

        private void DiscoryComplete(IAsyncResult result)
        {
            this.isSearching = false;
            //this.discoryTimer.Interval = 5000;
            if (result != null)
            {
                BluetoothDeviceInfo[] deviceinfos = discoryClient.EndDiscoverDevices(result);
                foreach (BluetoothDeviceInfo device in deviceinfos)
                {

                    if (device.DeviceAddress == BluetoothAddress.Parse("A0999B3BA930"))
                    {
                        
                        Connect();
                        this.discoryTimer.Enabled = true;
                        return;
                    }
                }
                
                this.isConnected = false;
                this.button_Status.BackColor = Color.Red;
            }
            this.discoryTimer.Enabled = true;

        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            this.Close();
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                //this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                

                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                
                //this.ShowInTaskbar = false;
                this.Visible = false;
                
            }
        }

        private void Button_DisConnect_Click(object sender, EventArgs e)
        {
            if(this.isConnected)
            {
                client.Close();
                client.Dispose();
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            Connect();

        }

        private void Connect()
        {
            BluetoothAddress address = BluetoothAddress.Parse("A0999B3BA930");
            BluetoothEndPoint endPoint = new BluetoothEndPoint(address, BluetoothService.SerialPort);
            if (!this.isConnected)
            {
                if(this.isReconnect)
                {
                    client.Dispose();
                    client = new BluetoothClient();
                }
                try
                {
                    client.Connect(endPoint);
                    this.isConnected = true;
                    this.isReconnect = true;
                    this.button_Status.BackColor = Color.Green;
                    this.notifyIcon_Main.BalloonTipText = "连上爪机啦！！！";
                    this.notifyIcon_Main.ShowBalloonTip(5);
                }
                catch
                {
                    this.isConnected = false;
                    this.button_Status.BackColor = Color.Red;
                    this.notifyIcon_Main.BalloonTipText = "连不上爪机啊！！！";
                    this.notifyIcon_Main.ShowBalloonTip(5);
                }
                    
                
            }
            
        }
    }
}

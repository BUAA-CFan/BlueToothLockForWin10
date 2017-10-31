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
        BluetoothRadio Radio;
        BluetoothClient client = new BluetoothClient();
        public Form1()
        {
            InitializeComponent();
            this.notifyIcon1.Visible = true;

            this.FormClosing += Form1_FormClosing;
            this.notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;
            this.button_Exit.Click += Button_Exit_Click;
            this.button_GetDevice.Click += Button_GetDevice_Click;
            this.button_DisConnect.Click += Button_DisConnect_Click;

            if(BluetoothRadio.PrimaryRadio!=null)
            {
                Radio = BluetoothRadio.PrimaryRadio;
                this.button_Connect.Click += Button_Connect_Click;
            }
            else
            {
                MessageBox.Show("电脑蓝牙没开呀！！！");
                
            }
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
            if(client.Connected)
            {
                client.Close();
                client.Dispose();
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            
            BluetoothAddress address = BluetoothAddress.Parse("A0999B3BA930");
            BluetoothEndPoint endPoint = new BluetoothEndPoint(address, BluetoothService.SerialPort);
            if(client.Client==null)
            {
                client.Dispose();
                client = new BluetoothClient();
                
            }
            try
            {

                client.Connect(endPoint);
                
            }
            catch
            {
                this.notifyIcon1.BalloonTipText = "连不上爪机啊！！！";
                this.notifyIcon1.ShowBalloonTip(5);
            }
            if(client.Connected)
            {
                this.textBox_DeviceList.Text = client.RemoteMachineName;

                this.notifyIcon1.BalloonTipText = "连上爪机啦！！！";
                this.notifyIcon1.ShowBalloonTip(5);
            }
            
        }

        private void Button_GetDevice_Click(object sender, EventArgs e)
        {
            
        }
    }
}

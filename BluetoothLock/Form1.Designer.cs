namespace BluetoothLock
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_GetDevice = new System.Windows.Forms.Button();
            this.textBox_DeviceList = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_DisConnect = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_GetDevice
            // 
            this.button_GetDevice.Location = new System.Drawing.Point(114, 72);
            this.button_GetDevice.Name = "button_GetDevice";
            this.button_GetDevice.Size = new System.Drawing.Size(104, 23);
            this.button_GetDevice.TabIndex = 0;
            this.button_GetDevice.Text = "获取设备列表";
            this.button_GetDevice.UseVisualStyleBackColor = true;
            // 
            // textBox_DeviceList
            // 
            this.textBox_DeviceList.Location = new System.Drawing.Point(118, 157);
            this.textBox_DeviceList.Multiline = true;
            this.textBox_DeviceList.Name = "textBox_DeviceList";
            this.textBox_DeviceList.Size = new System.Drawing.Size(483, 227);
            this.textBox_DeviceList.TabIndex = 1;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(248, 72);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "连接爪机";
            this.button_Connect.UseVisualStyleBackColor = true;
            // 
            // button_DisConnect
            // 
            this.button_DisConnect.Location = new System.Drawing.Point(355, 72);
            this.button_DisConnect.Name = "button_DisConnect";
            this.button_DisConnect.Size = new System.Drawing.Size(75, 23);
            this.button_DisConnect.TabIndex = 3;
            this.button_DisConnect.Text = "断开爪机";
            this.button_DisConnect.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(482, 72);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "退出程序";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 455);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_DisConnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_DeviceList);
            this.Controls.Add(this.button_GetDevice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GetDevice;
        private System.Windows.Forms.TextBox textBox_DeviceList;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_DisConnect;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button_Exit;
    }
}


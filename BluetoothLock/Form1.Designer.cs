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
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_DisConnect = new System.Windows.Forms.Button();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Status = new System.Windows.Forms.Button();
            this.contextMenuStrip_NotifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_NotifyIconMenu.SuspendLayout();
            this.SuspendLayout();
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
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.contextMenuStrip_NotifyIconMenu;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "notifyIcon1";
            this.notifyIcon_Main.Visible = true;
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
            // button_Status
            // 
            this.button_Status.BackColor = System.Drawing.Color.Red;
            this.button_Status.Location = new System.Drawing.Point(143, 210);
            this.button_Status.Name = "button_Status";
            this.button_Status.Size = new System.Drawing.Size(75, 23);
            this.button_Status.TabIndex = 5;
            this.button_Status.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip_NotifyIconMenu
            // 
            this.contextMenuStrip_NotifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Show,
            this.toolStripMenuItem_Exit});
            this.contextMenuStrip_NotifyIconMenu.Name = "contextMenuStrip_NotifyIconMenu";
            this.contextMenuStrip_NotifyIconMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // toolStripMenuItem_Show
            // 
            this.toolStripMenuItem_Show.Image = global::BluetoothLock.Properties.Resources.television;
            this.toolStripMenuItem_Show.Name = "toolStripMenuItem_Show";
            this.toolStripMenuItem_Show.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Show.Text = "显示窗口";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Image = global::BluetoothLock.Properties.Resources.cross;
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Exit.Text = "退出程序";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 455);
            this.Controls.Add(this.button_Status);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_DisConnect);
            this.Controls.Add(this.button_Connect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip_NotifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_DisConnect;
        private System.Windows.Forms.NotifyIcon notifyIcon_Main;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NotifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Show;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
    }
}


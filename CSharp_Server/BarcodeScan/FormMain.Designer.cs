namespace BarcodeScan
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonSend = new System.Windows.Forms.RadioButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(12, 68);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(601, 341);
            this.textBoxReceive.TabIndex = 0;
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Checked = true;
            this.radioButtonList.Location = new System.Drawing.Point(12, 28);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(107, 16);
            this.radioButtonList.TabIndex = 1;
            this.radioButtonList.TabStop = true;
            this.radioButtonList.Text = "条码显示在下面";
            this.radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonSend
            // 
            this.radioButtonSend.AutoSize = true;
            this.radioButtonSend.Location = new System.Drawing.Point(122, 28);
            this.radioButtonSend.Name = "radioButtonSend";
            this.radioButtonSend.Size = new System.Drawing.Size(107, 16);
            this.radioButtonSend.TabIndex = 2;
            this.radioButtonSend.TabStop = true;
            this.radioButtonSend.Text = "发送到光标所在";
            this.radioButtonSend.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 421);
            this.Controls.Add(this.radioButtonSend);
            this.Controls.Add(this.radioButtonList);
            this.Controls.Add(this.textBoxReceive);
            this.Name = "FormMain";
            this.Text = "条码服务器主窗体C#版";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonSend;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

